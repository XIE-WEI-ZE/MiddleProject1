using System;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.床位
{
    public partial class FrmConfirmationToRoomTable : Form
    {
        public string Message
        {
            get => lblMessage.Text;
            set => lblMessage.Text = value;
        }

        public FrmConfirmationToRoomTable()
        {
            InitializeComponent();

            // 設定 DialogResult
            btnConfirm.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            // 鍵盤支援
            this.AcceptButton = btnConfirm;
            this.CancelButton = btnCancel;
        }

        private void FrmConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
