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
    public partial class FrmStoreProductsDate : Form
    {
        public FrmStoreProductsDate()
        {
            InitializeComponent();
        }

        private void FrmStoreProductsDate_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreProductsDate", conn);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    this.storeProductsDateDataGridView.DataSource = dataSet.Tables[0];
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
