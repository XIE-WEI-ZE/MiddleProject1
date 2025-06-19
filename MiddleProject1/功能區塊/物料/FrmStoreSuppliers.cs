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
    public partial class FrmStoreSuppliers : Form
    {
        public FrmStoreSuppliers()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreSuppliers", conn);
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

        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            using (FrmAddStoreSuppliers formSuppliers = new FrmAddStoreSuppliers())
            {
                var result = formSuppliers.ShowDialog();

                string connString = Settings.Default.NursingHomeConnectionString;
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = connString;
                            conn.Open();

                            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreSuppliers", conn);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                (
                "確定要刪除該供應商嗎？",
                "刪除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                string connString = Settings.Default.NursingHomeConnectionString;
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            int selectedSupplierID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SupplierID"].Value);
                            conn.ConnectionString = connString;
                            conn.Open();

                            string deleteQuery = "Delete From StoreSuppliers Where SupplierID = @id";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", selectedSupplierID);
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                        }
                        MessageBox.Show("資料已刪除");
                        try
                        {
                            using (SqlConnection conn = new SqlConnection())
                            {
                                conn.ConnectionString = connString;
                                conn.Open();

                                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreSuppliers", conn);
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
                    else
                    {
                        MessageBox.Show("未選取資料");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("未選取資料");
                return;
            }
            int supplierID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SupplierID"].Value);
            FrmUpdateSuppliers updateSuppliers = new FrmUpdateSuppliers(supplierID);
            var result = updateSuppliers.ShowDialog();
            string connString = Settings.Default.NursingHomeConnectionString;
            if (result == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = connString;
                        conn.Open();

                        SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From StoreSuppliers", conn);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
