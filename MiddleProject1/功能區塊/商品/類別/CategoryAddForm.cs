using System;
using System.Data;
using System.Windows.Forms;
using MiddleProject1.功能區塊.商品.類別.Repositories;

namespace MiddleProject1.功能區塊.商品.類別
{
    public partial class CategoryAddForm : Form
    {
        private readonly ICategoryRepository repository = new CategoryRepository();
        private long? categoryId = null;

        public CategoryAddForm()
        {
            InitializeComponent();
            this.Text = "新增類別";
        }

        public CategoryAddForm(DataRow row)
        {
            InitializeComponent();
            this.Text = "編輯類別";
            categoryId = Convert.ToInt64(row["CategoryID"]);
            txtName.Text = row["CategoryName"].ToString();
            txtDescription.Text = row["Description"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("請輸入類別名稱");
                txtName.Focus();
                return;
            }

            bool result;
            if (categoryId == null)
                result = repository.InsertCategory(name, description);
            else
                result = repository.UpdateCategory(categoryId.Value, name, description);

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("儲存失敗！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
