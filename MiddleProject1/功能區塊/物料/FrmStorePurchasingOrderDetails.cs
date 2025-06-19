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
    public partial class FrmStorePurchasingOrderDetails : Form
    {
        internal int PurchasingOrderID;

        public FrmStorePurchasingOrderDetails()
        {
            InitializeComponent();
        }
        public FrmStorePurchasingOrderDetails(int p)
        {
            InitializeComponent();
            this.PurchasingOrderID = p;
        }


        private void FrmStorePurchasingOrderDetails_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "SELECT * FROM StorePurchasingOrderDetails WHERE StorePurchasingOrderID = @ID";
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@ID", PurchasingOrderID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
