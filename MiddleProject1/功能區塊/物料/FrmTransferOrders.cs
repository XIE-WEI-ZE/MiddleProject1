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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiddleProject1.功能區塊.物料
{
    public partial class FrmTransferOrders : Form
    {
        public FrmTransferOrders()
        {
            InitializeComponent();
        }

        private void FrmTransferOrders_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From TransferOrders", conn);
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

        private void btnAddTransferOrder_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            DateTime orderDate = DateTime.Now.Date;
            bool orderStatus = true;
            int newRecordID = -1;
            //剛按下按鈕時就先新增一列資料
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Insert into TransferOrders(OrderDate,TransferDate,OrderStatus) Output Inserted.TransferOrderID Values (@orderDate,@transferDate,@orderStatus)";
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@orderDate", orderDate);
                    command.Parameters.AddWithValue("@transferDate", orderDate);
                    command.Parameters.AddWithValue("@orderStatus", orderStatus);

                    newRecordID = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //如果新增表單按下取消就刪除剛新增的資料列
            using (FrmAddTransferOrder formTransfer = new FrmAddTransferOrder(newRecordID))
            {
                var result = formTransfer.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = connString;
                            conn.Open();

                            string deleteQuery = "Delete From TransferOrders Where TransferOrderID = @id";
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

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From TransferOrders", conn);
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
                FrmTransferOrderDetails f = new FrmTransferOrderDetails(Id);
                f.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
