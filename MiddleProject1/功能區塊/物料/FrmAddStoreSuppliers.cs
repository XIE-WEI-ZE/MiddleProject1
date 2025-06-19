using MiddleProject1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.物料
{
    public partial class FrmAddStoreSuppliers : Form
    {
        public FrmAddStoreSuppliers()
        {
            InitializeComponent();
        }
        private void FrmStoreAddSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            SqlTransaction txn = null;
            SqlConnection conn = null;
            string supplierName = txtSupplierName.Text;
            string contactName = txtContactName.Text;
            string contactNumber = txtContactNumber.Text;
            string Address = txtAddress.Text;


            if (int.TryParse(txtSupplierGUI.Text, out int supplierGUI))
            {
                supplierGUI = int.Parse(txtSupplierGUI.Text);
            }
            else
            {
                MessageBox.Show("輸入錯誤");
                DialogResult = DialogResult.Cancel;
            }
            try
            {
                conn = new SqlConnection();

                conn.ConnectionString = connString;
                conn.Open();
                SqlCommand command = new SqlCommand();
                txn = conn.BeginTransaction();

                command.Connection = conn;

                command.Transaction = txn;


                command.CommandText = "Insert into StoreSuppliers(SupplierName, SupplierGUI, Contact, ContactNumber, Address) values(@supplierName, @supplierGUI, @contact, @contactNumber, @address)";

                command.Parameters.AddWithValue("@supplierName", supplierName);
                command.Parameters.AddWithValue("@supplierGUI", supplierGUI);
                command.Parameters.AddWithValue("@contact", contactName);
                command.Parameters.AddWithValue("@contactNumber", contactNumber);
                command.Parameters.AddWithValue("@address", Address);

                command.ExecuteNonQuery();


                txn.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txn.Rollback();
                DialogResult = DialogResult.Cancel;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
