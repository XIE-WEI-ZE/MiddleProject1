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
    public partial class FrmStoreSalesOrders : Form
    {
        public FrmStoreSalesOrders()
        {
            InitializeComponent();
        }

        private void FrmStoreSalesOrders_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreSalesOrders", conn);
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

        private void btnAddSalesOrder_Click(object sender, EventArgs e)
        {
            DateTime orderDate = DateTime.Now.Date;
            int newRecordID = -1;
            string connString = Settings.Default.NursingHomeConnectionString;
            //object receivedDate = null;

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Insert into StoreSalesOrders(OrderDate, CustomerName, ReceivedDate, OrderStatus) Output Inserted.SalesOrderID Values (@orderDate, @customerName, @receivedDate, @orderStatus)";
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@orderDate", orderDate);
                    command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
                    command.Parameters.AddWithValue("@receivedDate", orderDate);
                    command.Parameters.AddWithValue("@orderStatus", 1);

                    newRecordID = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            using (FrmAddStoreSalesOrder formPurchase = new FrmAddStoreSalesOrder(newRecordID))
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

                            string deleteQuery = "Delete From StoreSalesOrders Where SalesOrderID = @id";
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
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreSalesOrders", conn);
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
                FrmStoreSalesOrderDetails f = new FrmStoreSalesOrderDetails(Id);
                f.Show();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
