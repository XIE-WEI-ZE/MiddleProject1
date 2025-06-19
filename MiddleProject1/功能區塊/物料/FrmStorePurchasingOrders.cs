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
    public partial class FrmStorePurchasingOrders : Form
    {
        public FrmStorePurchasingOrders()
        {
            InitializeComponent();
        }

        private void FrmStorePurchasingOrders_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StorePurchasingOrders", conn);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    this.dataGridView1.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool SupplierExists(int supplierID)
        {
            bool exists = false;
            string connString = Settings.Default.NursingHomeConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM StoreSuppliers WHERE SupplierID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplierID);

                    int count = (int)cmd.ExecuteScalar();
                    exists = count > 0;
                }
            }

            return exists;
        }
        private void btnAddPurchasingOrder_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            if (int.TryParse(txtSupplierID.Text, out int supplierID))
            {
                if (!SupplierExists(supplierID))
                {
                    MessageBox.Show("查無此供應商編號");
                    return;
                }
                supplierID = int.Parse(txtSupplierID.Text);
            }
            else
            {
                MessageBox.Show("請先輸入供應商編號");
                return;
            }
            DateTime arrivalDate = DateTime.Now.Date;
            int newRecordID = -1;
            //剛按下按鈕時就先新增一列資料
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Insert into StorePurchasingOrders(SupplierID,ArrivalDate) Output Inserted.StorePurchasingOrderID Values (@supplierID,@arrivalDate)";
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@supplierID", supplierID);
                    command.Parameters.AddWithValue("@arrivalDate", arrivalDate);

                    newRecordID = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //如果新增表單按下取消就刪除剛新增的資料列
            using (FrmAddStorePurchasingOrder formPurchase = new FrmAddStorePurchasingOrder(newRecordID, supplierID))
            {
                var result = formPurchase.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = connString;
                            conn.Open();

                            string deleteQuery = "Delete From StorePurchasingOrders Where StorePurchasingOrderID = @id";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", newRecordID);
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //變更完後即時顯示變更
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StorePurchasingOrders", conn);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    this.dataGridView1.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = (int)this.dataGridView1.CurrentRow.Cells[1].Value;
            if (e.ColumnIndex == 0)
            {
                FrmStorePurchasingOrderDetails f = new FrmStorePurchasingOrderDetails(Id);
                f.Show();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
