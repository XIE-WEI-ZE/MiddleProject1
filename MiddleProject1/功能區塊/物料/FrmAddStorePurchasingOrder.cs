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
    public partial class FrmAddStorePurchasingOrder : Form
    {
        private int recordID;
        private int supplierID;
        public FrmAddStorePurchasingOrder(int recordID,int supplierID)
        {
            InitializeComponent();
            this.recordID = recordID;
            this.supplierID = supplierID;
        }
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommandBuilder commandBuilder;
        private void FrmAddStorePurchasingOrder_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand("Select * From StorePurchasingOrderDetails Where StorePurchasingOrderID = @id", conn);
                    command.Parameters.AddWithValue("@id", recordID);
                    dataAdapter = new SqlDataAdapter(command);
                    commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataTable.Columns["StorePurchasingOrderID"].DefaultValue = recordID;

                    this.dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["StorePurchasingOrderID"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool IsSupplierItemValid(SqlConnection conn, SqlTransaction transaction, int storeProductID, int supplierID)
        {
            string query = "SELECT COUNT(*) FROM StoreProducts WHERE StoreProductID = @storeProductID AND SupplierID = @supplierID";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@storeProductID", storeProductID);
                cmd.Parameters.AddWithValue("@supplierID", supplierID);
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
                        decimal quantityIn = decimal.Parse(row.Cells["QuantityIn"].Value.ToString());
                        object expiryDate = row.Cells["ExpiryDate"].Value;
                        if(expiryDate != null && DateTime.TryParse(expiryDate.ToString(), out DateTime dateValue)) 
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
                        if (!IsSupplierItemValid(conn, transaction, storeProductID, supplierID)) 
                        {
                            throw new Exception($"供應商 {supplierID} 不提供 {storeProductID} 的商品");
                        }
                        string insertDetail = @"INSERT INTO StorePurchasingOrderDetails (StorePurchasingOrderID, StoreProductID, QuantityIn, ExpiryDate) VALUES (@storePurchasingOrderID, @storeProductID, @quantityIn, @expiryDate)";

                        using (SqlCommand cmd = new SqlCommand(insertDetail, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@storePurchasingOrderID", recordID);
                            cmd.Parameters.AddWithValue("@storeProductID", storeProductID);
                            cmd.Parameters.AddWithValue("@quantityIn", quantityIn);
                            cmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                            cmd.ExecuteNonQuery();
                        }

                        string insertProductsDate = @"Insert Into StoreProductsDate (StoreProductID, [ExpiryDate/ArrivalDate], RemainingStocks, StocksStatus) Values (@storeProductID2, @expiryDatearrivalDate, @remainingStocks, @stocksStatus)";

                        using(SqlCommand cmd = new SqlCommand(insertProductsDate, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@storeProductID2", storeProductID);
                            if(expiryDate == null)
                            {  expiryDate = DateTime.Now.Date; }
                            cmd.Parameters.AddWithValue("@expiryDatearrivalDate", expiryDate);
                            cmd.Parameters.AddWithValue("@remainingStocks", quantityIn);
                            cmd.Parameters.AddWithValue("@stocksStatus", 1);
                            cmd.ExecuteNonQuery();
                        }

                        string updateStock = @"UPDATE StoreProducts SET UnitsInStock = UnitsInStock + @quantityIn2 WHERE StoreProductID = @storeProductID3";

                        using (SqlCommand cmd = new SqlCommand(updateStock, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@quantityIn2", quantityIn);
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
