using Microsoft.Extensions.Logging;
using MiddleProject1.Properties;
using MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters;
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

namespace MiddleProject1.功能區塊.活動
{
    public partial class FrmEventBatchList : Form
    {
        public FrmEventBatchList()
        {
            InitializeComponent();
            //eventIDTextBox.ReadOnly = true;
            LoadStatusComboBox();//下拉選單預設
        }

        

        internal int? BatchID = null;
        public FrmEventBatchList(int batchID)
        {
            InitializeComponent();
            this.BatchID = batchID;
            eventIDTextBox.ReadOnly = true;
            LoadStatusComboBox();//下拉選單預設
        }

        private void LoadStatusComboBox()
        {
            string connStr = Settings.Default.NursingHomeConnectionString;
            string query = "SELECT StatusID, StatusName FROM EventStatus where StatusCategory='活動總表'  ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox1.DisplayMember = "StatusName";
                    comboBox1.ValueMember = "StatusID";
                    comboBox1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        statusTextBox.Text = "";
                        return; // 無資料直接離開
                    }

                    //if (!string.IsNullOrEmpty(statusTextBox.Text))
                    //{
                    //    MessageBox.Show("有判斷");
                    //    // 如果已經有狀態值，就設定選項
                    //    comboBox1.SelectedValue = int.Parse(statusTextBox.Text);
                    //    //comboBox1.SelectedIndex = 3; //int.Parse(statusTextBox.Text);
                    //}
                    //else
                    //{
                    //    // 如果是空的，就選第一筆並同步到 statusTextBox
                    //    comboBox1.SelectedIndex = 0;
                    //    statusTextBox.Text = dt.Rows[0]["StatusID"].ToString();
                    //}
                    if (!string.IsNullOrEmpty(statusTextBox.Text) && int.TryParse(statusTextBox.Text, out int statusID))
                    {
                        DataRow[] matchingRows = dt.Select($"StatusID = {statusID}");
                        if (matchingRows.Length > 0)
                        {
                            comboBox1.SelectedValue = statusID;
                        }
                        else
                        {
                            comboBox1.SelectedIndex = 0;
                            statusTextBox.Text = dt.Rows[0]["StatusID"].ToString();
                        }
                    }
                    else
                    {
                        comboBox1.SelectedIndex = 0;
                        statusTextBox.Text = dt.Rows[0]["StatusID"].ToString();
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入狀態選單失敗：" + ex.Message);
            }
        }

        private void eventBatchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBatchBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nhEventDataSet);

        }

        private void FrmEventBatchList_Load(object sender, EventArgs e)
        {// TODO: 這行程式碼會將資料載入 'nhEventDataSet.EventBatch' 資料表。您可以視需要進行移動或移除。
            this.eventBatchTableAdapter.Fill(this.nhEventDataSet.EventBatch);
            //欄位僅能讀取
            batchIDTextBox.ReadOnly = true;
            eventIDTextBox.ReadOnly = true;
            createdAtDateTimePicker.Visible = false;
            createdByTextBox.Visible = false;
            lastModifiedByTextBox.Visible = false;
            lastModifiedAtDateTimePicker.Visible = false;

            
            if (BatchID.HasValue && BatchID.Value > 0)
            {
                // 編輯模式：根據 EventID 載入資料
                this.eventBatchTableAdapter.FillByEventBatch_BatchID(this.nhEventDataSet.EventBatch, BatchID.Value);
            }
            else
            {
                this.eventBatchBindingSource.AddNew();
                this.statusTextBox.Text ="4";
                this.eventDateTimeStarDateTimePicker.Value = DateTime.Now;
                this.eventDateTimeEndDateTimePicker.Value = DateTime.Now;
                this.registrationDateStarDateTimePicker.Value = DateTime.Now;
                this.registrationDateEndDateTimePicker.Value = DateTime.Now;
                this.createdAtDateTimePicker.Value = DateTime.Now;
                this.createdByTextBox.Text = "20";
            }
            LoadStatusComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSelectEventList f = new FrmSelectEventList("EventList");
            if (f.ShowDialog() == DialogResult.OK)
            {
                int selectedEventID = f.SelectedEventID;

                // ✅ 你可以把這個值顯示或用在其他地方
                //MessageBox.Show("選到的 EventID 為：" + selectedEventID);

                // TODO: 放入 TextBox 或做其他處理
                eventIDTextBox.Text = selectedEventID.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                statusTextBox.Text = comboBox1.SelectedValue.ToString();
            }

        }
        //存檔
        private void eventBatchBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {// 檢查必填欄位
            if (string.IsNullOrWhiteSpace(eventIDTextBox.Text))
            {
                MessageBox.Show("請選擇活動 (EventID 不得為空)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                MessageBox.Show("請選擇狀態 (Status 不得為空)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 若為新增狀態，設定預設值
            if (!BatchID.HasValue || BatchID.Value <= 0)
            {
                if (string.IsNullOrWhiteSpace(createdByTextBox.Text))
                {
                    createdByTextBox.Text = "20";
                }

                createdAtDateTimePicker.Value = DateTime.Now;
            }
            try
            {
                this.Validate();
                this.eventBatchBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.nhEventDataSet);

                MessageBox.Show("儲存成功");
                this.Close();//關閉視窗
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("資料已被其他人修改，請重新載入。");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // 主鍵或唯一索引衝突
                {
                    MessageBox.Show("儲存失敗：此記錄已存在，請檢查是否重複。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 547) // Foreign key constraint
                {
                    MessageBox.Show("儲存失敗：資料與其他資料表有關聯，無法進行此操作。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("發生資料庫錯誤：" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存過程發生錯誤：" + ex.Message);
            }


        }
        private void eventDetailsBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("確定要刪除這筆資料嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                eventBatchBindingSource.RemoveCurrent();

                this.Validate();
                eventBatchBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(nhEventDataSet);

                MessageBox.Show("刪除成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // FK 限制
                {
                    MessageBox.Show("刪除失敗：此資料與其他資料有關聯，無法刪除。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("資料庫錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
