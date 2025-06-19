using MiddleProject1.功能區塊.商品.Helpers;
using MiddleProject1.功能區塊.商品.Repositories;
using MiddleProject1.功能區塊.商品.訂單.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.商品.訂單
{
    public partial class UC_Order : UserControl
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();
        private DataTable _allOrders;
        private PaginationHelper _paginator;
        private int _pageSize = 10;

        public UC_Order()
        {
            InitializeComponent();
            LoadAllOrders();
        }

        private void LoadAllOrders()
        {
            try
            {
                _allOrders = _orderRepository.GetAllOrders();
                _paginator = new PaginationHelper(_allOrders.Rows.Count, _pageSize);
                LoadCurrentPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入訂單資料失敗：" + ex.Message);
            }
        }

        private void LoadCurrentPage()
        {
            int start = _paginator.GetStartIndex();
            int size = _paginator.GetPageSize();

            var pagedRows = _allOrders.AsEnumerable()
                .Skip(start)
                .Take(size);

            dgvOrders.DataSource = pagedRows.Any()
                ? pagedRows.CopyToDataTable()
                : _allOrders.Clone(); // 空表格但保留欄位

            lblPageInfo.Text = $"第 {_paginator.CurrentPage} 頁 / 共 {_paginator.TotalPages} 頁";
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("請選擇要查看的訂單");
                return;
            }

            long orderId = Convert.ToInt64(dgvOrders.CurrentRow.Cells["OrderID"].Value);

            using (var form = new OrderEditFrom())
            {
                form.OrderID = orderId;
                form.ReadOnlyMode = true; // ← 新增屬性控制唯讀

                form.ShowDialog();
                dgvOrders.ClearSelection();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("請先選擇要刪除的訂單");
                return;
            }

            long orderId = Convert.ToInt64(dgvOrders.CurrentRow.Cells["OrderID"].Value);

            var result = MessageBox.Show($"確定要刪除訂單編號 {orderId} 嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _orderRepository.DeleteOrder(orderId);
                    if (success)
                    {
                        MessageBox.Show("刪除成功");
                        LoadAllOrders(); // 重新載入列表
                        dgvOrders.ClearSelection(); // 清除選取狀態
                    }
                    else
                    {
                        MessageBox.Show("刪除失敗，可能找不到此訂單");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("刪除時發生錯誤：" + ex.Message);
                }
            }
        }



        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            _paginator.PreviousPage();
            LoadCurrentPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _paginator.NextPage();
            LoadCurrentPage();
        }
    }
}
