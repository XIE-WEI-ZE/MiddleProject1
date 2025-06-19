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
    public partial class FrmTransferOrderDetails : Form
    {
        internal int TranferOrderID;
        public FrmTransferOrderDetails()
        {
            InitializeComponent();
        }
        //利用多載來接上個表單回傳的值
        public FrmTransferOrderDetails(int p)
        {
            InitializeComponent();
            this.TranferOrderID = p;
        }


        private void FrmTransferOrderDetails_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "SELECT * FROM TransferOrderDetails WHERE TransferOrderID = @ID";
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@ID", TranferOrderID);

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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
