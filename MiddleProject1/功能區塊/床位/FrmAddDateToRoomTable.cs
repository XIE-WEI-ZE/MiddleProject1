using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.床位
{
    public partial class FrmAddDateToRoomTable : Form
    {
        public string MemberID => memberIDTextBox.Text.Trim();
        public string RoomNumber => roomNumberTextBox.Text.Trim();
        public string RoomName => roomNameTextBox.Text.Trim();
        public bool RoomType => roomTypeCheckBox.Checked;
        public int BedCount => int.TryParse(bedCountTextBox.Text, out var count) ? count : 0;
        public decimal RoomPrice => decimal.TryParse(roomPriceTextBox.Text, out var price) ? price : 0;

        public FrmAddDateToRoomTable()
        {
            InitializeComponent();
        }

        private void FrmAddDateToRoomTable_Load(object sender, EventArgs e)
        {

        }
        
        // 存檔
        private void btnSave_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(RoomNumber))
            {
                MessageBox.Show("房間編號不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 可擴充其他驗證條件...

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
