// ✅ OrderEditForm.cs - 加入訂單明細分頁功能 + 僅支援唯讀模式
using MiddleProject1.功能區塊.商品.Helpers;
using MiddleProject1.功能區塊.商品.訂單.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.商品.訂單
{
    public partial class OrderEditFrom : Form
    {
        public long OrderID { get; set; } // 僅支援編輯模式，不再處理 null
        public bool ReadOnlyMode { get; set; } = true;

        private IOrderRepository _repo = new OrderRepository();
        private DataTable _allDetails;
        private PaginationHelper _detailPaginator;
        private int detailPageSize = 5; // ✅ 可自行調整每頁筆數

        public OrderEditFrom()
        {
            InitializeComponent();
            this.Load += OrderEditForm_Load;
        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            if (!OrderID.Equals(null))
            {
                LoadOrderData(OrderID);
                this.Text = "查看訂單";
                if (ReadOnlyMode) SetReadOnly();
            }
            else
            {
                MessageBox.Show("無效的訂單 ID");
                this.Close();
            }
        }

        private void SetReadOnly()
        {
            dtpOrderTime.Enabled = false;
            txtBuyerName.ReadOnly = true;
            txtReceiverName.ReadOnly = true;
            txtReceiverPhone.ReadOnly = true;
            cmbPaymentMethod.Enabled = false;
            cmbDeliveryMethod.Enabled = false;
            txtDeliveryAddress.ReadOnly = true;
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            txtTotal.ReadOnly = true;
            btnSave.Enabled = false;
        }

        private void LoadOrderData(long orderId)
        {
            var dt = _repo.GetOrderById(orderId);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("找不到該筆訂單");
                return;
            }

            var row = dt.Rows[0];
            dtpOrderTime.Value = Convert.ToDateTime(row["OrderTime"]);
            txtBuyerName.Text = row["BuyerName"].ToString();
            txtReceiverName.Text = row["ReceiverName"].ToString();
            txtReceiverPhone.Text = row["ReceiverPhone"].ToString();
            cmbPaymentMethod.Text = row["PaymentMethod"].ToString();
            cmbDeliveryMethod.Text = row["DeliveryMethod"].ToString();
            txtDeliveryAddress.Text = row["DeliveryAddress"].ToString();

            // ✅ 載入訂單明細總表
            _allDetails = _repo.GetOrderDetails(orderId);
            _detailPaginator = new PaginationHelper(_allDetails.Rows.Count, detailPageSize);
            LoadCurrentDetailPage();

            // 顯示訂單明細
            var detailTable = _repo.GetOrderDetails(orderId);
            dgvOrderDetails.DataSource = detailTable;

            // ✅ 計算總金額
            decimal total = detailTable.AsEnumerable()
                .Sum(r => r.Field<int>("SubTotal"));

            txtTotal.Text = total.ToString("N2"); // 顯示小數點兩位
        }

        private void LoadCurrentDetailPage()
        {
            int start = _detailPaginator.GetStartIndex();
            int size = _detailPaginator.GetPageSize();

            var pageRows = _allDetails.AsEnumerable()
                .Skip(start)
                .Take(size);

            dgvOrderDetails.DataSource = pageRows.Any()
                ? pageRows.CopyToDataTable()
                : _allDetails.Clone();

            lblDetailPageInfo.Text = $"第 {_detailPaginator.CurrentPage} 頁 / 共 {_detailPaginator.TotalPages} 頁";
        }

        private void btnPrevDetailPage_Click(object sender, EventArgs e)
        {
            _detailPaginator.PreviousPage();
            LoadCurrentDetailPage();
        }

        private void btnNextDetailPage_Click(object sender, EventArgs e)
        {
            _detailPaginator.NextPage();
            LoadCurrentDetailPage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}