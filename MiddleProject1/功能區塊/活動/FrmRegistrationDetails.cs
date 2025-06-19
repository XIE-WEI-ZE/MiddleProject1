using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.活動
{
    public partial class FrmRegistrationDetails : Form
    {
        public FrmRegistrationDetails()
        {
            InitializeComponent();
        }
        internal int? RegistrationID = null;
        public FrmRegistrationDetails(int registrationID)
        {
            InitializeComponent();
            this.RegistrationID = registrationID;
        }

        private void registrationDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationDetailsBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.nhEventDataSet);

        }

        private void FrmRegistrationDetails_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'nhEventDataSet.RegistrationDetails' 資料表。您可以視需要進行移動或移除。
            this.registrationDetailsTableAdapter1.Fill(this.nhEventDataSet.RegistrationDetails);
            if (RegistrationID.HasValue && RegistrationID.Value > 0) {
                this.registrationDetailsTableAdapter1.FillByRegistrationDetails_RegistrationID(this.nhEventDataSet.RegistrationDetails, RegistrationID.Value);
            }
            else {
                this.registrationDetailsBindingSource1.AddNew();
            }
            //欄位僅能讀取
            internalRemarksTextBox.Visible = false;
            lastModifiedByTextBox.Visible = false;
            lastModifiedAtDateTimePicker.Visible = false;


        }
    }
}
