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
using MiddleProject1.Properties;

namespace MiddleProject1.功能區塊.物料
{
    public partial class FrmAddStoreProducts : Form
    {
        public FrmAddStoreProducts()
        {
            InitializeComponent();
        }

        //private bool IsSupplierValid(SqlConnection conn, int supplierID)
        //{

        //    string query = "SELECT COUNT(*) FROM StoreProducts WHERE SupplierID = @supplierID";
        //    using (SqlCommand cmd = new SqlCommand(query, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@supplierID", supplierID);
        //        conn.Open();
        //        int count = (int)cmd.ExecuteScalar();
        //        return count > 0;
        //    }
        //}


        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            SqlTransaction txn = null;
            SqlConnection conn = null;
            string storeProductName = txtStoreProductName.Text;
            string quantityPerUnit = txtQuantityPerUnit.Text;
            int unitsInStock = 0;


            if (int.TryParse(txtSupplierID.Text, out int supplierID))
            {
                //if (!IsSupplierValid(conn, supplierID))
                //{
                //    throw new Exception($"供應商 {supplierID} 不存在");
                //}
                //else
                //{
                    supplierID = int.Parse(txtSupplierID.Text);
                //}
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


                command.CommandText = "Insert into StoreProducts(StoreProductName,QuantityPerUnit,UnitsInStock, SupplierID) values(@storeProductName,@quantityPerUnit,@unitsInStock,@supplierID)";

                command.Parameters.AddWithValue("@storeProductName", storeProductName);
                command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
                command.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                command.Parameters.AddWithValue("@supplierID", supplierID);

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
