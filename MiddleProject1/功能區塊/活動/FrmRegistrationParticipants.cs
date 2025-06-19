using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MiddleProject1.功能區塊.活動
{
    public partial class FrmRegistrationParticipants : Form
    {
        public FrmRegistrationParticipants()
        {
            InitializeComponent();
        }
        internal int? RegistrationID = null;
        public FrmRegistrationParticipants(int registrationID)
        {
            InitializeComponent();
            this.RegistrationID = registrationID;
        }

        private void registrationParticipantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationParticipantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nhEventDataSet);

        }

        private void FrmRegistrationParticipants_Load(object sender, EventArgs e)
        {
        
            this.registrationParticipantsTableAdapter.Fill(this.nhEventDataSet.RegistrationParticipants);
            
            //this.registrationParticipantsTableAdapter.FillByRegistrationParticipants_RegistrationID(this.nhEventDataSet.RegistrationParticipants, RegistrationID.Value);
            if (RegistrationID.HasValue && RegistrationID.Value > 0)
            {
                this.registrationParticipantsTableAdapter.FillByRegistrationParticipants_RegistrationID(this.nhEventDataSet.RegistrationParticipants, RegistrationID.Value);
            }
            // 禁用 BindingNavigator 的新增、刪除、儲存按鈕
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            registrationParticipantsBindingNavigatorSaveItem.Enabled = false;
            //欄位僅能讀取
            createdAtDateTimePicker.Visible = false;
            internalRemarksTextBox.Visible = false;
            lastModifiedByTextBox.Visible = false;
            lastModifiedAtDateTimePicker.Visible = false;

        }

        private void registrationParticipantsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationParticipantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nhEventDataSet);
            // this.registrationParticipantsTableAdapter.UpdateQuery(this.nhEventDataSet.RegistrationParticipants);
            //foreach (DataRow row in this.nhEventDataSet.RegistrationParticipants.Rows)
            //{
            //    if (row.RowState == DataRowState.Modified)
            //    {
            //        DateTime birthDate = row.Field<DateTime?>("BirthDate") ?? DateTime.MinValue;
            //        DateTime lastModifiedAt = row.Field<DateTime?>("LastModifiedAt") ?? DateTime.Now;

            //        this.registrationParticipantsTableAdapter.UpdateQuery(
            //            row["Name"]?.ToString() ?? "",
            //            row["NationalID"]?.ToString() ?? "",
            //            row["Email"]?.ToString() ?? "",
            //            row["Address"]?.ToString() ?? "",
            //            row["Gender"]?.ToString() ?? "",
            //            birthDate.ToString(),  // 傳 DateTime
            //            row["ContactPhone"]?.ToString() ?? "",
            //            row["OtherRemarks"]?.ToString() ?? "",
            //            row["EmergencyContactName"]?.ToString() ?? "",
            //            row["EmergencyContactPhone"]?.ToString() ?? "",
            //            Convert.ToInt32(row["Status"]),
            //            row["InternalRemarks"]?.ToString() ?? "",
            //            lastModifiedAt,  // 傳 DateTime
            //            Convert.ToInt32(row["LastModifiedBy"]),// 若是 int 改用 Convert.ToInt32
            //            Convert.ToInt32(row["RegistrationID"]),
            //            Convert.ToInt32(row["CompanionID"])
            //        );
            //    }
            //}

        }
    }
}
