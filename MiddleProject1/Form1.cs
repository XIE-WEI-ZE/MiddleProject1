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
using System.Data.SqlClient;
using MiddleProject1.功能區塊;

namespace MiddleProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            uiTextBox2.PasswordChar = '*';
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string username = uiTextBox1.Text.Trim();
            string password = uiTextBox2.Text.Trim();

            if (username == "admin" && password == "123456")
            {
                var connSetting = ConfigurationManager.ConnectionStrings["MyConnString"];
                if (connSetting == null)
                {
                    MessageBox.Show("找不到連線字串！");
                    return;
                }

                string connStr = connSetting.ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        FrmMain mainForm = new FrmMain();
                        mainForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("連線失敗：" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤，請重新輸入！");
                uiTextBox1.Text = "";
                uiTextBox2.Text = "";
                uiTextBox1.Focus();
            }
        }
    }
}