using MiddleProject1.功能區塊.商品.Repositories;
using MiddleProject1.功能區塊.商品.類別.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiddleProject1.功能區塊.商品
{
    public partial class ProductAddForm : Form
    {
        private readonly IProductRepository repository = new ProductRepository();
        private readonly ProductPhotoRepository photoRepo = new ProductPhotoRepository();
        private readonly ICategoryRepository categoryRepo = new CategoryRepository();

        private int? productId = null;
        private byte[] uploadedImage = null;
        private string uploadedFileName = null;

        public ProductAddForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        public ProductAddForm(DataRow row)
        {
            InitializeComponent();
            LoadCategories();

            this.Text = "編輯商品";
            productId = Convert.ToInt32(row["ProductID"]);
            txtName.Text = row["ProductName"].ToString();
            txtOriginalPrice.Text = row["OriginalPrice"].ToString();
            txtSalePrice.Text = row["SalePrice"].ToString();
            txtQuantity.Text = row["Quantity"].ToString();
            txtStock.Text = row["Stock"].ToString();
            chkDiscontinued.Checked = Convert.ToBoolean(row["Discontinued"]);

            if (row["CategoryID"] != DBNull.Value)
                cmbCategory.SelectedValue = Convert.ToInt64(row["CategoryID"]);

            if (row.Table.Columns.Contains("DiscountRate") && row["DiscountRate"] != DBNull.Value)
                txtDiscountRate.Text = row["DiscountRate"].ToString();

            if (row.Table.Columns.Contains("Summary") && row["Summary"] != DBNull.Value)
                txtSummary.Text = row["Summary"].ToString();

            if (row.Table.Columns.Contains("Content") && row["Content"] != DBNull.Value)
                txtContent.Text = row["Content"].ToString();


            var bytes = photoRepo.GetPhotoByProductId(productId.Value);
            if (bytes != null && bytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    picPreview.Image = Image.FromStream(ms);
                }
            }

        }

        private void LoadCategories()
        {
            var dt = new CategoryRepository().GetAllCategories();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = dt;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "圖片檔 (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        uploadedImage = File.ReadAllBytes(ofd.FileName);
                        uploadedFileName = Path.GetFileName(ofd.FileName);

                        using (MemoryStream ms = new MemoryStream(uploadedImage))
                        {
                            picPreview.Image = Image.FromStream(ms);
                        }

                        MessageBox.Show("圖片載入成功：" + uploadedFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("圖片載入錯誤：" + ex.Message);
                    }
                }
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                // 折扣驗證
                decimal? discountRate = null;
                if (string.IsNullOrWhiteSpace(name)) { MessageBox.Show("請輸入商品名稱"); return; }
                if (!int.TryParse(txtOriginalPrice.Text, out var originalPrice)) { MessageBox.Show("原價錯誤"); return; }
                if (!int.TryParse(txtSalePrice.Text, out var salePrice)) { MessageBox.Show("售價錯誤"); return; }
                if (!int.TryParse(txtQuantity.Text, out var quantity)) { MessageBox.Show("數量錯誤"); return; }
                if (!int.TryParse(txtStock.Text, out var stock)) { MessageBox.Show("庫存錯誤"); return; }
                if (!string.IsNullOrWhiteSpace(txtDiscountRate.Text))
                {
                    if (!decimal.TryParse(txtDiscountRate.Text, out var discount))
                    {
                        MessageBox.Show("折扣輸入錯誤，請輸入小數（例如 0.8）");
                        return;
                    }
                    if (discount < 0 || discount > 1)
                    {
                        MessageBox.Show("折扣必須介於 0 到 1 之間");
                        return;
                    }
                    discountRate = discount;
                }
                string summary = string.IsNullOrWhiteSpace(txtSummary.Text) ? null : txtSummary.Text.Trim();
                string content = string.IsNullOrWhiteSpace(txtContent.Text) ? null : txtContent.Text.Trim();

                long? categoryId = null;
                if (cmbCategory.SelectedValue != null)
                    categoryId = Convert.ToInt64(cmbCategory.SelectedValue);

                bool discontinued = chkDiscontinued.Checked;
                bool result = false;

                if (productId == null)
                {
                    int newId = repository.InsertProduct(name, originalPrice, salePrice, quantity, stock, discontinued, categoryId, discountRate, summary, content);

                    if (newId > 0)
                    {
                        productId = newId;
                        result = true;
                    }
                }
                else
                {
                    result = repository.UpdateProduct(productId.Value, name, originalPrice, salePrice, quantity, stock, discontinued, categoryId, discountRate, summary, content);

                }

                if (result && uploadedImage != null)
                {
                    byte[] thumb = CreateThumbnail(uploadedImage, 100, 100);
                    bool success = photoRepo.InsertPhoto(productId.Value, thumb, uploadedFileName, uploadedImage, uploadedFileName);
                    if (!success)
                    {
                        MessageBox.Show("圖片儲存失敗！");
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private int GetLastInsertedProductId()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString()))
            {
                string sql = "SELECT TOP 1 ProductID FROM ShopProducts ORDER BY ProductID DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private byte[] CreateThumbnail(byte[] originalImageBytes, int maxWidth, int maxHeight)
        {
            using (MemoryStream ms = new MemoryStream(originalImageBytes))
            using (Image originalImage = Image.FromStream(ms))
            {
                // 縮圖比例
                double scale = Math.Min((double)maxWidth / originalImage.Width, (double)maxHeight / originalImage.Height);
                int width = (int)(originalImage.Width * scale);
                int height = (int)(originalImage.Height * scale);

                using (Bitmap thumb = new Bitmap(width, height))
                using (Graphics g = Graphics.FromImage(thumb))
                {
                    g.Clear(Color.White);  // 避免黑底
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(originalImage, new Rectangle(0, 0, width, height));

                    using (MemoryStream thumbStream = new MemoryStream())
                    {
                        thumb.Save(thumbStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return thumbStream.ToArray();
                    }
                }
            }
        }

    }
}

