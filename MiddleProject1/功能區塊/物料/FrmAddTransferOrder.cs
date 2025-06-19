using MiddleProject1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.物料
{
    public partial class FrmAddTransferOrder : Form
    {
        private int recordID;
        public FrmAddTransferOrder(int id)
        {
            InitializeComponent();
            recordID = id;
        }
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommandBuilder commandBuilder;
        private void FrmAddTransferOrder_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand("Select * From TransferOrders Where TransferOrderID = @id", conn);
                    command.Parameters.AddWithValue("@id", recordID);
                    dataAdapter = new SqlDataAdapter(command);
                    commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataTable.Columns["TransferOrderID"].DefaultValue = recordID;

                    this.dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["TransferOrderID"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool IsItemValid(SqlConnection conn, SqlTransaction transaction, int storeProductID)
        {
            string query = "SELECT COUNT(*) FROM StoreProducts WHERE StoreProductID = @storeProductID";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@storeProductID", storeProductID);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int storeProductID = Convert.ToInt32(row.Cells["StoreProductID"].Value.ToString());
                        decimal quantityOfTransfer = decimal.Parse(row.Cells["QuantityOfTransfer"].Value.ToString());
                        object expiryDate = row.Cells["ExpiryDate"].Value;
                        if (expiryDate != null && DateTime.TryParse(expiryDate.ToString(), out DateTime dateValue))
                        {
                            expiryDate = dateValue;
                        }
                        else if (expiryDate == null)
                        {
                            expiryDate = null;
                        }
                        else
                        {
                            MessageBox.Show("輸入錯誤");
                        }
                        if (!IsItemValid(conn, transaction, storeProductID))
                        {
                            throw new Exception($"未存在 {storeProductID} 的商品");
                        }
                        string insertDetail = @"INSERT INTO TransferOrderDetails (TransferOrderID, StoreProductID, QuantityOfTransfer, ExpiryDate) VALUES (@transferOrderID, @storeProductID, @quantityOfTransfer, @expiryDate)";

                        using (SqlCommand cmd = new SqlCommand(insertDetail, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@transferOrderID", recordID);
                            cmd.Parameters.AddWithValue("@storeProductID", storeProductID);
                            cmd.Parameters.AddWithValue("@quantityOfTransfer", quantityOfTransfer);
                            cmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                            cmd.ExecuteNonQuery();
                        }

                        string insertProductsDate = @"Update StoreProductsDate SET RemainingStocks = RemainingStocks - @quantityOfTransfer2 Where StoreProductID = @storeProductID2 And [ExpiryDate/ArrivalDate] = @expiryDatearrivalDate";

                        using (SqlCommand cmd = new SqlCommand(insertProductsDate, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@quantityOfTransfer2", quantityOfTransfer);
                            cmd.Parameters.AddWithValue("@storeProductID2", storeProductID);
                            cmd.Parameters.AddWithValue("@expiryDatearrivalDate", expiryDate);
                            cmd.ExecuteNonQuery();
                        }

                        string updateStock = @"UPDATE StoreProducts SET UnitsInStock = UnitsInStock - @quantityOfTransfer3 WHERE StoreProductID = @storeProductID3";

                        using (SqlCommand cmd = new SqlCommand(updateStock, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@quantityOfTransfer3", quantityOfTransfer);
                            cmd.Parameters.AddWithValue("@storeProductID3", storeProductID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    MessageBox.Show("資料已新增");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存失敗：" + ex.Message);
                    DialogResult = DialogResult.Cancel;
                }
            }

        }
    }
}
