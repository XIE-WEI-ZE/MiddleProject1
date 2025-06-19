using MiddleProject1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.活動
{
    public partial class UC_EventRecord : UserControl
    {
        private List<EventRecordsModel> eventRecord = new List<EventRecordsModel>();//allevent
        private BindingSource bindingSource = new BindingSource();
        private int pageSize = 20;
        public UC_EventRecord()
        {
            InitializeComponent();
            LoadEventRecord();
            GetEventRecordColumnNames();
            dataGridView1.AllowUserToAddRows = false;//不讓新增
        }

        private void GetEventRecordColumnNames()
        {
            var columnMapping = new Dictionary<string, string>()
    {
        { "活動明細編號", "EventRecordID" },
        { "活動編號", "BatchID" },
        { "內容", "Content" },
        { "狀態", "Status" },

    };

            comboBox1.DataSource = new BindingSource(columnMapping, null);
            comboBox1.DisplayMember = "Key";   // 顯示中文名稱
            comboBox1.ValueMember = "Value";   // 實際值為欄位英文名稱
        }

        private void LoadEventRecord()
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string value = textBox1.Text.Trim(); // 若未使用可刪除
                    SqlCommand cmd = new SqlCommand("SELECT * FROM EventRecords;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    eventRecord.Clear(); // 確保 eventRecord 是 List<EventRecordsModel>

                    while (reader.Read())
                    {
                        eventRecord.Add(new EventRecordsModel
                        {
                            EventRecordID = reader.GetInt32(0),
                            BatchID = reader.GetInt32(1),
                            Content = reader.GetString(2),
                            Status = reader.GetInt32(3),
                            StatusName = 活動.Events.getStatusName(reader.GetInt32(3)),
                            InternalRemarks = reader.IsDBNull(4) ? null : reader.GetString(4),
                            CreatedAt = reader.GetDateTime(5),
                            CreatedBy = reader.GetInt32(6),
                            LastModifiedAt = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7),
                            LastModifiedBy = reader.IsDBNull(8) ? (int?)null : reader.GetInt32(8)

                            // 額外導出資料（若需要顯示名稱）
                            //StatusName = 活動.Events.getStatusName(reader.GetInt32(3)),
                            //CreatedByName = 員工.Employee.getEmployeeName(reader.GetInt32(6))
                        });
                    }
                }

                SetupPagination();
                DisplayPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetupPagination()
        {
            int totalPages = (int)Math.Ceiling((double)eventRecord.Count / pageSize);
            bindingSource.DataSource = Enumerable.Range(0, totalPages).ToList();
            bindingSource.Position = 0;
        }
        private void DisplayPage()
        {
            int pageIndex = bindingSource.Position;
            int start = pageIndex * pageSize;
            var currentPage = eventRecord.Skip(start).Take(pageSize).ToList(); // 假設 eventRecord 是 List<EventRecordsModel>

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 編輯連結欄位
            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.Name = "Edit";
            editLink.HeaderText = "";
            editLink.Text = "修改";
            editLink.UseColumnTextForLinkValue = true;

            DataGridViewLinkColumn editLinkPhoto = new DataGridViewLinkColumn();
            editLinkPhoto.HeaderText = "";
            editLinkPhoto.Text = "照片";
            editLinkPhoto.UseColumnTextForLinkValue = true;

            // 欄位名稱 (依EventRecords欄位設計調整)
            dataGridView1.Columns.Add("EventRecordID", "活動紀錄編號");
            dataGridView1.Columns.Add("BatchID", "梯次編號");
            dataGridView1.Columns.Add("Content", "內容說明");
            dataGridView1.Columns.Add("Status", "狀態代碼");
            //dataGridView1.Columns.Add("StatusName", "狀態名稱");
            //dataGridView1.Columns.Add("InternalRemarks", "內部備註");
            //dataGridView1.Columns.Add("CreatedAt", "建立日期");
            //dataGridView1.Columns.Add("CreatedBy", "建立人員");
            //dataGridView1.Columns.Add("LastModifiedAt", "最後修改日期");
            //dataGridView1.Columns.Add("LastModifiedBy", "最後修改人員");
            dataGridView1.Columns.Add(editLink);
            dataGridView1.Columns.Add(editLinkPhoto);

            foreach (var item in currentPage)
            {
                dataGridView1.Rows.Add(

                    item.EventRecordID,
                    item.BatchID,
                    item.Content,
                    item.Status + item.StatusName,
                    //item.Status,
                    //item.InternalRemarks ?? "",
                    //item.CreatedAt.ToString("yyyy-MM-dd HH:mm"),
                    //item.CreatedBy,
                    //item.LastModifiedAt?.ToString("yyyy-MM-dd HH:mm") ?? "",
                    //item.LastModifiedBy?.ToString() ?? "",
                    "修改",
                    "圖片"
                );
            }

            //0603
            int totalPages = (int)Math.Ceiling((double)eventRecord.Count / pageSize);
            label3.Text = $"第 {pageIndex + 1} 頁 / 共 {totalPages} 頁";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // 避免標題列錯誤點擊

            int eventRecordID = (int)this.dataGridView1.Rows[e.RowIndex].Cells["EventRecordID"].Value;

            // 判斷是否點擊 "修改"
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                dataGridView1.Columns[e.ColumnIndex].HeaderText == "")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "修改")
                {
                    FrmEventRecord editForm = new FrmEventRecord(eventRecordID);
                    editForm.ShowDialog();
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "照片")
                {
                    FrmEventPhotoUpload photoForm = new FrmEventPhotoUpload(eventRecordID, "eventRecord");
                    photoForm.ShowDialog();
                }

                //重新載入頁面
                LoadEventRecord();       // 重新載入資料
                SetupPagination();     // 重建分頁來源
                DisplayPage();         // 顯示目前頁
            }

        }

        // 分頁按鈕事件處理器

        private void uiButton1_Click(object sender, EventArgs e)
        {
            bindingSource.Position = 0;
            DisplayPage();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position--;
                DisplayPage();
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
                DisplayPage();
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            bindingSource.Position = bindingSource.Count - 1;
            DisplayPage();
        }

        private void uiButton6_Click(object sender, EventArgs e)//搜尋
        {//select
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string colname = comboBox1.SelectedValue.ToString();
                    string value = textBox1.Text.Trim();
                    SqlCommand cmd;

                    if (value == "")
                    {
                        cmd = new SqlCommand($"SELECT * FROM EventRecords ", conn);
                    }
                    else
                    {
                        cmd = new SqlCommand($"SELECT * FROM EventRecords WHERE {colname} = @value", conn);
                    }

                    cmd.Parameters.AddWithValue("@value", value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    eventRecord.Clear();
                    while (reader.Read())
                    {
                        eventRecord.Add(new EventRecordsModel
                        {
                            EventRecordID = reader.GetInt32(0),
                            BatchID = reader.GetInt32(1),
                            Content = reader.GetString(2),
                            Status = reader.GetInt32(3),
                            StatusName = 活動.Events.getStatusName(reader.GetInt32(3)),
                            InternalRemarks = reader.IsDBNull(4) ? null : reader.GetString(4),
                            CreatedAt = reader.GetDateTime(5),
                            CreatedBy = reader.GetInt32(6),
                            LastModifiedAt = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7),
                            LastModifiedBy = reader.IsDBNull(8) ? (int?)null : reader.GetInt32(8)


                        });
                    }
                }
                DisplayPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            FrmEventRecord f = new FrmEventRecord();
            f.ShowDialog();
            LoadEventRecord();
        }
    }
}
