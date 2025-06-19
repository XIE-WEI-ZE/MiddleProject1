using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MiddleProject1.功能區塊.商品.Repositories;
using MiddleProject1.功能區塊.商品.Helpers;

namespace MiddleProject1.功能區塊.商品
{
    public partial class UC_Product : UserControl
    {
        private readonly IProductRepository productRepository = new ProductRepository();
        private DataTable allProducts;
        private PaginationHelper paginator;
        private int pageSize = 10;

        public UC_Product()
        {
            InitializeComponent();
            SetupProductGrid();
            LoadAllProducts();
        }

        //dgvProducts.AutoGenerateColumns = false;，然後在設計階段或程式碼中手動加入所有欄位，即使沒有資料也會保留欄位顯示
        private void SetupProductGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductID",
                DataPropertyName = "ProductID",
                HeaderText = "商品編號"
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                DataPropertyName = "ProductName",
                HeaderText = "商品名稱"
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OriginalPrice",
                DataPropertyName = "OriginalPrice",
                HeaderText = "原價"
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SalePrice",
                DataPropertyName = "SalePrice",
                HeaderText = "售價"
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                DataPropertyName = "Quantity",
                HeaderText = "數量"
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                DataPropertyName = "Stock",
                HeaderText = "庫存"
            });
            dgvProducts.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Discontinued",
                DataPropertyName = "Discontinued",
                HeaderText = "下架"
            });
        }


        private void LoadAllProducts()
        {
            try
            {
                allProducts = productRepository.GetAllProducts();
                paginator = new PaginationHelper(allProducts.Rows.Count, pageSize);
                LoadCurrentPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取商品資料失敗：" + ex.Message);
            }
        }

        private void LoadCurrentPage()
        {
            int start = paginator.GetStartIndex();
            int size = paginator.GetPageSize();

            var pagedRows = allProducts.AsEnumerable()
                .Skip(start)
                .Take(size);

            if (pagedRows.Any())
            {
                var dt = pagedRows.CopyToDataTable();
                dgvProducts.DataSource = dt;

                // 安全設定欄位標題
                SetColumnHeadersIfExist();
            }
            else
            {
                dgvProducts.DataSource = allProducts.Clone();
            }

            lblPageInfo.Text = $"第 {paginator.CurrentPage} 頁 / 共 {paginator.TotalPages} 頁";
        }

        private void SetColumnHeadersIfExist()
        {
            SetHeaderIfExist("ProductID", "商品編號");
            SetHeaderIfExist("ProductName", "商品名稱");
            SetHeaderIfExist("OriginalPrice", "原價");
            SetHeaderIfExist("SalePrice", "售價");
            SetHeaderIfExist("Quantity", "數量");
            SetHeaderIfExist("Stock", "庫存");
            SetHeaderIfExist("Discontinued", "下架");
        }

        private void SetHeaderIfExist(string columnName, string headerText)
        {
            if (dgvProducts.Columns.Contains(columnName))
            {
                dgvProducts.Columns[columnName].HeaderText = headerText;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new ProductAddForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadAllProducts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇要編輯的商品！");
                return;
            }

            DataRowView rowView = dgvProducts.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                using (var form = new ProductAddForm(rowView.Row))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        LoadAllProducts();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇要刪除的商品！");
                return;
            }

            DataRowView rowView = dgvProducts.SelectedRows[0].DataBoundItem as DataRowView;
            int productId = Convert.ToInt32(rowView["ProductID"]);
            string name = rowView["ProductName"].ToString();

            var confirm = MessageBox.Show($"確定要刪除「{name}」？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                bool success = productRepository.DeleteProduct(productId);
                if (success)
                {
                    MessageBox.Show("商品刪除成功！");
                    LoadAllProducts();
                }
                else
                {
                    MessageBox.Show("刪除失敗！");
                }
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            paginator.PreviousPage();
            LoadCurrentPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            paginator.NextPage();
            LoadCurrentPage();
        }
    }
}
