using Microsoft.Extensions.Logging;
using MiddleProject1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleProject1.功能區塊.活動;

namespace MiddleProject1.功能區塊.活動
{
    public partial class UC_EventBatch : UserControl
    {
        private List<EventBatchModel> eventsBatch = new List<EventBatchModel>();//allevent
        private BindingSource bindingSource = new BindingSource();
        private int pageSize = 20;
        public UC_EventBatch()
        {
            InitializeComponent();
            LoadAllEventsBatch();        // 載入資料
            //SetupPagination();      // 初始化分頁來源
            dataGridView1.AllowUserToAddRows = false;//不讓新增
            //GetEventDetailsColumnNames();
            GetEventBatchColumnNames();//comboBox1欄位預設
        }

        private void LoadAllEventsBatch()
        {
            //select
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    //string colname = comboBox1.SelectedItem.ToString();
                    string value = textBox1.Text.Trim();
                    SqlCommand cmd;

                    //if (value == "")
                    //{
                         cmd = new SqlCommand($"SELECT * FROM EventBatch ; ", conn);
                    //}
                    //else {
                    //     cmd = new SqlCommand($"SELECT * FROM EventDetails WHERE {colname} = @value", conn);
                    //}
  
                    //cmd.Parameters.AddWithValue("@value", value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    eventsBatch.Clear();
                    while (reader.Read())
                    {
                        eventsBatch.Add(new EventBatchModel
                        {
                            EventID = reader.GetInt32(0),
                            EventName= 活動.Events.getEventName(reader.GetInt32(0)),

                            BatchID = reader.GetInt32(1),

                            EventDateTimeStar = reader.GetDateTime(2),

                            EventDateTimeEnd = reader.GetDateTime(3),

                            RegistrationDateStar = reader.GetDateTime(4),

                            RegistrationDateEnd = reader.GetDateTime(5),

                            Status = reader.GetInt32(6),
                            StatusName = 活動.Events.getStatusName(reader.GetInt32(6)),

                            Recurrence = reader.IsDBNull(7) ? null : reader.GetString(7),

                            CreatedAt = reader.GetDateTime(8),

                            CreatedBy= reader.GetInt32(9),
      
                            LastModifiedAt = reader.IsDBNull(10) ? (DateTime?)null : reader.GetDateTime(10),
                            LastModifiedBy = reader.IsDBNull(11) ? (int?)null : reader.GetInt32(11)


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
        private void DisplayPage()
        {
            int pageIndex = bindingSource.Position;
            int start = pageIndex * pageSize;
            var currentPage = eventsBatch.Skip(start).Take(pageSize).ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 加入欄位
            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.HeaderText = "";
            editLink.Text = "修改";
            editLink.UseColumnTextForLinkValue = true;

            //欄位名稱
            dataGridView1.Columns.Add("BatchID", "活動編號");
            dataGridView1.Columns.Add("EventID", "活動明細");
            //dataGridView1.Columns.Add("EventName", "活動名稱");
            dataGridView1.Columns.Add("EventDateTimeStar", "活動日期(起)");
            dataGridView1.Columns.Add("EventDateTimeEnd", "活動日期(迄)");
            dataGridView1.Columns.Add("RegistrationDateStar", "報名日期(起)");
            dataGridView1.Columns.Add("RegistrationDateEnd", "報名日期(迄)");
            dataGridView1.Columns.Add("Status", "狀態");
            //dataGridView1.Columns.Add("StatusName", "狀態");
            dataGridView1.Columns.Add("Recurrence", "週期性");
            dataGridView1.Columns.Add(editLink);

            foreach (var item in currentPage)
            {
                dataGridView1.Rows.Add(  //內容
                    item.BatchID,
                    item.EventID+item.EventName,
                    item.EventDateTimeStar.ToString("yyyy-MM-dd"),
                    item.EventDateTimeEnd.ToString("yyyy-MM-dd"),
                    item.RegistrationDateStar.ToString("yyyy-MM-dd"),
                    item.RegistrationDateEnd.ToString("yyyy-MM-dd"),
                    item.Status+item.StatusName,
                    item.Recurrence,
                    //item.CreatedAt,
                    //item.CreatedBy,
                    //item.LastModifiedAt,
                    //item.LastModifiedBy,
                     "修改"
                );
            }
            //0603
            int totalPages = (int)Math.Ceiling((double)eventsBatch.Count / pageSize);
            label2.Text = $"第 {pageIndex + 1} 頁 / 共 {totalPages} 頁";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // 避免標題列錯誤點擊

            int batchID = (int)this.dataGridView1.Rows[e.RowIndex].Cells["BatchID"].Value;

            // 判斷是否點擊 "修改"
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                dataGridView1.Columns[e.ColumnIndex].HeaderText == "")
            {
                
                    FrmEventBatchList editForm = new FrmEventBatchList(batchID);
                    editForm.ShowDialog();
               

                //重新載入頁面
                LoadAllEventsBatch();       // 重新載入資料
                SetupPagination();     // 重建分頁來源
                DisplayPage();         // 顯示目前頁
            }

        }

        private void SetupPagination()
        {
            int totalPages = (int)Math.Ceiling((double)eventsBatch.Count / pageSize);
            bindingSource.DataSource = Enumerable.Range(0, totalPages).ToList();
            bindingSource.Position = 0;
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
                         cmd = new SqlCommand($"SELECT * FROM EventBatch ", conn);
                    }
                    else {
                         cmd = new SqlCommand($"SELECT * FROM EventBatch WHERE {colname} = @value", conn);
                    }
  
                    cmd.Parameters.AddWithValue("@value", value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    eventsBatch.Clear();
                    while (reader.Read())
                    {
                        eventsBatch.Add(new EventBatchModel
                        {
                            EventID = reader.GetInt32(0),
                            EventName = 活動.Events.getEventName(reader.GetInt32(0)),

                            BatchID = reader.GetInt32(1),

                            EventDateTimeStar = reader.GetDateTime(2),

                            EventDateTimeEnd = reader.GetDateTime(3),

                            RegistrationDateStar = reader.GetDateTime(4),

                            RegistrationDateEnd = reader.GetDateTime(5),

                            Status = reader.GetInt32(6),
                            StatusName = 活動.Events.getStatusName(reader.GetInt32(6)),

                            Recurrence = reader.IsDBNull(7) ? null : reader.GetString(7),

                            CreatedAt = reader.GetDateTime(8),

                            CreatedBy = reader.GetInt32(9),

                            LastModifiedAt = reader.IsDBNull(10) ? (DateTime?)null : reader.GetDateTime(10),
                            LastModifiedBy = reader.IsDBNull(11) ? (int?)null : reader.GetInt32(11)


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
            FrmEventBatchList f = new FrmEventBatchList();
            f.Show();

        }

        private void GetEventBatchColumnNames()
        {
            var columns = new List<object>
    {
        new { Name = "活動編號", Value = "BatchID" },
        new { Name = "活動明細", Value = "EventID" },
        new { Name = "活動日期(起)", Value = "EventDateTimeStar" },
        new { Name = "活動日期(迄)", Value = "EventDateTimeEnd" },
        new { Name = "報名日期(起)", Value = "RegistrationDateStar" },
        new { Name = "報名日期(迄)", Value = "RegistrationDateEnd" },
        new { Name = "狀態編號", Value = "Status" },
        new { Name = "週期性", Value = "Recurrence" },
        new { Name = "建立時間", Value = "CreatedAt" },
        new { Name = "建立者", Value = "CreatedBy" },
        new { Name = "修改時間", Value = "LastModifiedAt" },
        new { Name = "修改者", Value = "LastModifiedBy" }
    };

            comboBox1.DataSource = columns;
            comboBox1.DisplayMember = "Name";   // 顯示中文名稱
            comboBox1.ValueMember = "Value";    // 實際查詢用的欄位
        
            //string connString = Settings.Default.NursingHomeConnectionString;
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connString))
            //    {
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM EventBatch", conn);
            //        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly);

            //        DataTable schemaTable = reader.GetSchemaTable();
            //        comboBox1.Items.Clear();

            //        foreach (DataRow row in schemaTable.Rows)
            //        {
            //            string columnName = row["ColumnName"].ToString();
            //            comboBox1.Items.Add(columnName);
            //        }

            //        if (comboBox1.Items.Count > 0)
            //        {
            //            comboBox1.SelectedIndex = 0; // 預設選第一個欄位
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("載入欄位名稱失敗：" + ex.Message);
            //}
        }

       
    }
}
