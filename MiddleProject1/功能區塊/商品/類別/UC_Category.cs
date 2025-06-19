using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MiddleProject1.功能區塊.商品.Helpers;
using MiddleProject1.功能區塊.商品.類別.Repositories;

namespace MiddleProject1.功能區塊.商品.類別
{
    public partial class UC_Category : UserControl
    {
        private readonly ICategoryRepository categoryRepository = new CategoryRepository();
        private DataTable allCategories;
        private PaginationHelper paginator;
        private int pageSize = 10;

        public UC_Category()
        {
            InitializeComponent();
            LoadAllCategories();
        }

        // 載入全部分類資料
        private void LoadAllCategories()
        {
            try
            {
                allCategories = categoryRepository.GetAllCategories();
                paginator = new PaginationHelper(allCategories.Rows.Count, pageSize);
                LoadCurrentPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取分類資料失敗：" + ex.Message);
            }
        }

        // 顯示目前頁面資料
        private void LoadCurrentPage()
        {
            int start = paginator.GetStartIndex();
            int size = paginator.GetPageSize();

            var pagedRows = allCategories.AsEnumerable()
                .Skip(start)
                .Take(size);

            if (pagedRows.Any())
                dgvCategories.DataSource = pagedRows.CopyToDataTable();
            else
                dgvCategories.DataSource = allCategories.Clone(); // ❗保留欄位結構

            // 設定欄位名稱（保險起見放外層）
            if (dgvCategories.Columns.Contains("CategoryID"))
            {
                dgvCategories.Columns["CategoryID"].HeaderText = "分類編號";
                dgvCategories.Columns["CategoryName"].HeaderText = "分類名稱";
                dgvCategories.Columns["Description"].HeaderText = "說明";
            }

            lblPageInfo.Text = $"第 {paginator.CurrentPage} 頁 / 共 {paginator.TotalPages} 頁";
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            paginator?.PreviousPage();
            LoadCurrentPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            paginator?.NextPage();
            LoadCurrentPage();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new CategoryAddForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadAllCategories();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇要編輯的分類！");
                return;
            }

            var rowView = dgvCategories.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                using (var form = new CategoryAddForm(rowView.Row))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        LoadAllCategories();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇要刪除的分類！");
                return;
            }

            var rowView = dgvCategories.SelectedRows[0].DataBoundItem as DataRowView;
            long categoryId = Convert.ToInt64(rowView["CategoryID"]);
            string name = rowView["CategoryName"].ToString();

            var confirm = MessageBox.Show($"確定要刪除「{name}」？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                bool success = categoryRepository.DeleteCategory(categoryId);
                if (success)
                {
                    MessageBox.Show("分類刪除成功！");
                    LoadAllCategories();
                }
                else
                {
                    MessageBox.Show("刪除失敗，可能已與商品關聯！");
                }
            }
        }
    }
}
