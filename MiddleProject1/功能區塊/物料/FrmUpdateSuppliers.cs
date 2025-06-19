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
    public partial class FrmUpdateSuppliers : Form
    {
        private int supplierID;
        public FrmUpdateSuppliers(int supplierID)
        {
            InitializeComponent();
            this.supplierID = supplierID;
            LoadSupplierData();
        }
        private void LoadSupplierData()
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM StoreSuppliers WHERE SupplierID = @id";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", supplierID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtSupplierName.Text = reader["SupplierName"].ToString();
                            txtSupplierGUI.Text = reader["SupplierGUI"].ToString();
                            txtContactName.Text = reader["Contact"].ToString();
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string updateQuery = "UPDATE StoreSuppliers SET SupplierName = @name, SupplierGUI = @supplierGUI, Contact = @contactName, ContactNumber = @contactNumber, Address = @address WHERE SupplierID = @id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@supplierGUI", txtSupplierGUI.Text);
                    cmd.Parameters.AddWithValue("@contactName", txtContactName.Text);
                    cmd.Parameters.AddWithValue("@contactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@id", supplierID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("資料已更新");
            this.Close();
        }
    }
}
