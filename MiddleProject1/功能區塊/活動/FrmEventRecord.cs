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
    public partial class FrmEventRecord : Form
    {
        public FrmEventRecord()
        {
            InitializeComponent();
        }

        internal int? EventRecordID = null;
        public FrmEventRecord(int eventRecordID)
        {
            InitializeComponent();
            this.EventRecordID = eventRecordID;
            //eventIDTextBox.ReadOnly = true;
        }

        private void eventRecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nhEventDataSet);

        }

        private void FrmEventRecord_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'nhEventDataSet.EventRecords' 資料表。您可以視需要進行移動或移除。
            this.eventRecordsTableAdapter.Fill(this.nhEventDataSet.EventRecords);
            if (EventRecordID.HasValue && EventRecordID.Value > 0)
            {
                // 編輯模式：根據 EventID 載入資料
                this.eventRecordsTableAdapter.FillByEventRecords_EventRecordID(this.nhEventDataSet.EventRecords, EventRecordID.Value);
            }
            else
            {
                this.eventRecordsBindingSource.AddNew();
            }
            //欄位僅能讀取
            eventRecordIDTextBox.ReadOnly = true;
            createdAtDateTimePicker.Visible = false;
            createdByTextBox.Visible = false;
            lastModifiedAtDateTimePicker.Visible = false;
            lastModifiedByTextBox.Visible = false;
            internalRemarksTextBox.Visible = false;
            createdAtDateTimePicker.Value = DateTime.Now;
            createdByTextBox.Text = "20";


        }

        private void eventRecordsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {// 檢查欄位是否為空
    if (string.IsNullOrWhiteSpace(eventRecordIDTextBox.Text) ||
        string.IsNullOrWhiteSpace(batchIDTextBox.Text) ||
        string.IsNullOrWhiteSpace(contentTextBox.Text) ||
        string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                MessageBox.Show("所有欄位皆必填", "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 檢查數字欄位是否為數字
            if (!int.TryParse(eventRecordIDTextBox.Text, out _) ||
                !int.TryParse(batchIDTextBox.Text, out _) ||
                !int.TryParse(statusTextBox.Text, out _))
            {
                MessageBox.Show("活動紀錄編號、梯次編號、狀態只能輸入數字", "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Validate();
            this.eventRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nhEventDataSet);

        }
    }
}
