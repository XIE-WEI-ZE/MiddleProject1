using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MiddleProject1.Properties;
using System.Data.SqlClient;

namespace MiddleProject1.功能區塊.物料
{
    public partial class UC_Stock : UserControl
    {
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void UC_Stock_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreProducts", conn);
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

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            (new FrmStoreSuppliers()).Show();
        }

        private void btnProductsDate_Click(object sender, EventArgs e)
        {
            (new FrmStoreProductsDate()).Show();
        }

        private void btnPurchasingOrders_Click(object sender, EventArgs e)
        {
            (new FrmStorePurchasingOrders()).Show();
        }

        private void btnSalesOrders_Click(object sender, EventArgs e)
        {
            (new FrmStoreSalesOrders()).Show();
        }

        private void btnTransferOrders_Click(object sender, EventArgs e)
        {
            (new FrmTransferOrders()).Show();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreProducts", conn);
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

        private void btnAddStoreProducts_Click(object sender, EventArgs e)
        {
            using (FrmAddStoreProducts formTransfer = new FrmAddStoreProducts())
            {
                var result = formTransfer.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string connString = Settings.Default.NursingHomeConnectionString;
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = connString;
                            conn.Open();

                            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreProducts", conn);
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
            }

        }
    }
}
