using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.員工
{
    public partial class FrmUserExceptionForm : Form
    {
        public FrmUserExceptionForm(int employeeID, string employeeName, string shiftID, string status, string lateMinutes, string overtimeMinutes)
        {
            InitializeComponent();
            uiTextBox1.Text = employeeID.ToString();
            uiTextBox2.Text = employeeName;
            uiTextBox3.Text = shiftID;
            uiTextBox4.Text = status;
            uiTextBox5.Text = lateMinutes;
            uiTextBox6.Text = overtimeMinutes;

            // 全部設為唯讀
            uiTextBox1.ReadOnly = true;
            uiTextBox2.ReadOnly = true;
            uiTextBox3.ReadOnly = true;
            uiTextBox4.ReadOnly = true;
            uiTextBox5.ReadOnly = true;
            uiTextBox6.ReadOnly = true;
        }
        private void uiButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();  // 或 DialogResult = DialogResult.Cancel;
        }

        private void uiButtonUserMissCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已送出忘刷申請單!");
            this.Close();
        }

        private void uiButtonUserLeaveRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已送出請假申請單!");
            this.Close();
        }

        private void uiButtonUserOvertime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已送出加班申請單!");
            this.Close();
        }

    }
}