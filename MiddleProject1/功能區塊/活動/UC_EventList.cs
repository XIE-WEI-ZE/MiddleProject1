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
    public partial class UC_EventList : UserControl
    {
        private List<EventModel> allEvents = new List<EventModel>();
        private BindingSource bindingSource = new BindingSource();
        private int pageSize = 20;

        public UC_EventList()
        {
            InitializeComponent();
            LoadAllEvents();        // 載入資料
            SetupPagination();      // 初始化分頁來源
            DisplayPage();          // 顯示第一頁
            dataGridView1.AllowUserToAddRows = false;//不讓新增
            GetEventDetailsColumnNames();
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
        }

        private void GetEventDetailsColumnNames()
        {
            var columnMapping = new Dictionary<string, string>()
    {
        { "活動明細編號", "EventID" },
        { "活動名稱", "EventName" },
        { "主辦單位", "Organizer" },
        { "活動對象", "TargetAudience" },
        { "需要家屬保險", "RequiresFamilyInsurance" },
        { "類別編號", "CategoryID" },
        { "狀態", "Status" },
        { "聯繫窗口", "ContactPersonID" },
        { "聯絡電話", "ContactPhone" },
        { "活動地點", "EventLocation" },
        { "名額", "Quota" },
        { "活動內容", "Description" },
        { "醫療與安全措施", "MedicalAid" },
        { "是否付費", "IsPaid" },
        { "總金額", "TotalAmount" },
        { "建立時間", "CreatedAt" },
        { "建立人員", "CreatedBy" },
        { "最後修改時間", "LastModifiedAt" },
        { "最後修改人員", "LastModifiedBy" }
    };

            comboBox1.DataSource = new BindingSource(columnMapping, null);
            comboBox1.DisplayMember = "Key";   // 顯示中文名稱
            comboBox1.ValueMember = "Value";   // 實際值為欄位英文名稱
        }


        private void LoadAllEvents()
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM EventDetails ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    allEvents.Clear();
                    while (reader.Read())
                    {
                        allEvents.Add(new EventModel
                        {
                            EventID = reader.GetInt32(0),
                            EventName = reader.GetString(1),
                            Organizer = reader.GetString(2),
                            //TargetAudience = reader.GetString(3),
                            //RequiresFamilyInsurance = reader.GetBoolean(4),
                            CategoryID = reader.GetInt32(5),
                            CategoryName = getCategoryName(reader.GetInt32(5)),
                            Status = reader.GetInt32(6),
                            StatusName = 活動.Events.getStatusName(reader.GetInt32(6)),
                            ContactPersonID = reader.GetInt32(7),
                            ContactPersonName = getContactPersonName(reader.GetInt32(7)),
                            ContactPhone = reader.GetString(8),
                            EventLocation = reader.GetString(9),
                            Quota = reader.IsDBNull(10) ? (int?)null : reader.GetInt32(10),
                            Description = reader.IsDBNull(11) ? null : reader.GetString(11),
                            //MedicalAid = reader.IsDBNull(12) ? null : reader.GetString(12),
                            IsPaid = reader.GetBoolean(13),
                            TotalAmount = reader.IsDBNull(14) ? (decimal?)null : reader.GetDecimal(14),


                            //TotalAmount = reader.IsDBNull(14) ? null : reader.GetDecimal(14),

                            //Recurrence = reader.IsDBNull(7) ? null : reader.GetString(7),
                            //CreatedAt = reader.GetDateTime(15)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getContactPersonName(int PersonID)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($" SELECT Name FROM Employee WHERE EmployeeID={PersonID} ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }

                    return "未知姓名";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "未知姓名";
            }
        }

        private string getCategoryName(int categoryID)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT CategoryName FROM EventCategory where CategoryID={categoryID} ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }

                    return "未知類別";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "未知類別";
            }

        }


        private void SetupPagination()
        {
            int totalPages = (int)Math.Ceiling((double)allEvents.Count / pageSize);
            bindingSource.DataSource = Enumerable.Range(0, totalPages).ToList();
            bindingSource.Position = 0;
        }

        private void DisplayPage()
        {
            int pageIndex = bindingSource.Position;
            int start = pageIndex * pageSize;
            var currentPage = allEvents.Skip(start).Take(pageSize).ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 加入欄位
            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.HeaderText = "";
            editLink.Text = "修改";
            editLink.UseColumnTextForLinkValue = true;
            DataGridViewLinkColumn editLinkPhoto = new DataGridViewLinkColumn();
            editLinkPhoto.HeaderText = "";
            editLinkPhoto.Text = "照片";
            editLinkPhoto.UseColumnTextForLinkValue = true;


            dataGridView1.Columns.Add("EventID", "活動明細編號");
            dataGridView1.Columns.Add("EventName", "活動名稱");
            dataGridView1.Columns.Add("Organizer", "主辦單位");
            dataGridView1.Columns.Add("CategoryID", "類別編號");
            //dataGridView1.Columns.Add("CategoryName", "類別");
            dataGridView1.Columns.Add("StatusName", "狀態");
            dataGridView1.Columns.Add("ContactPersonName", "聯繫窗口");
            dataGridView1.Columns.Add("ContactPhone", "聯繫電話");
            dataGridView1.Columns.Add("EventLocation", "活動地點");
            dataGridView1.Columns.Add("Quota", "名額");
            dataGridView1.Columns.Add("Description", "活動內容");
            dataGridView1.Columns.Add("IsPaid", "是否需付款");
            dataGridView1.Columns.Add("TotalAmount", "金額");
            dataGridView1.Columns.Add(editLink);
            dataGridView1.Columns.Add(editLinkPhoto);

            // 設定所有欄位不可排序
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (var item in currentPage)
            {
                dataGridView1.Rows.Add(
                    item.EventID,
                    item.EventName,
                    item.Organizer,
                    item.CategoryID+ item.CategoryName,
                    item.Status + item.StatusName,
                    item.ContactPersonID+ item.ContactPersonName,
                    item.ContactPhone,
                    item.EventLocation,
                    item.Quota,
                    item.Description,
                    item.IsPaid,
                    item.TotalAmount,
                    "修改",
                    "照片"
                );
            }
            //0603
            int totalPages = (int)Math.Ceiling((double)allEvents.Count / pageSize);
            label2.Text = $"第 {pageIndex + 1} 頁 / 共 {totalPages} 頁";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        // 分頁按鈕事件處理器

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            bindingSource.Position = 0;
            DisplayPage();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position--;
                DisplayPage();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
                DisplayPage();
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            bindingSource.Position = bindingSource.Count - 1;
            DisplayPage();
        }



        private void uiButton5_Click(object sender, EventArgs e)//新增
        {
            FrmEventList f = new FrmEventList();
            f.ShowDialog();
            LoadAllEvents();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // 避免標題列錯誤點擊

            int eventID = (int)this.dataGridView1.Rows[e.RowIndex].Cells["EventID"].Value;

            // 判斷是否點擊 "修改"
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                dataGridView1.Columns[e.ColumnIndex].HeaderText == "")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "修改")
                {
                    FrmEventList editForm = new FrmEventList(eventID);
                    editForm.ShowDialog();
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "照片")
                {
                    FrmEventPhotoUpload photoForm = new FrmEventPhotoUpload(eventID,"eventlist");
                    photoForm.ShowDialog();
                }

                //重新載入頁面
                LoadAllEvents();       // 重新載入資料
                SetupPagination();     // 重建分頁來源
                DisplayPage();         // 顯示目前頁
            }
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
                        cmd = new SqlCommand($"SELECT * FROM EventDetails ", conn);
                    }
                    else
                    {
                        cmd = new SqlCommand($"SELECT * FROM EventDetails WHERE {colname} = @value", conn);
                    }

                    cmd.Parameters.AddWithValue("@value", value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    allEvents.Clear();
                    while (reader.Read())
                    {
                        allEvents.Add(new EventModel
                        {
                            EventID = reader.GetInt32(0),
                            EventName = reader.GetString(1),
                            Organizer = reader.GetString(2),
                            //TargetAudience = reader.GetString(3),
                            //RequiresFamilyInsurance = reader.GetBoolean(4),
                            CategoryID = reader.GetInt32(5),
                            CategoryName = getCategoryName(reader.GetInt32(5)),
                            Status = reader.GetInt32(6),
                            StatusName = 活動.Events.getStatusName(reader.GetInt32(6)),
                            ContactPersonID = reader.GetInt32(7),
                            ContactPersonName = getContactPersonName(reader.GetInt32(7)),
                            ContactPhone = reader.GetString(8),
                            EventLocation = reader.GetString(9),
                            Quota = reader.IsDBNull(10) ? (int?)null : reader.GetInt32(10),
                            Description = reader.IsDBNull(11) ? null : reader.GetString(11),
                            //MedicalAid = reader.IsDBNull(12) ? null : reader.GetString(12),
                            IsPaid = reader.GetBoolean(13),
                            TotalAmount = reader.IsDBNull(14) ? (decimal?)null : reader.GetDecimal(14),
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
        //0604
        //private void 依照類別ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // 排序 allEvents 清單
        //    allEvents = allEvents.OrderBy(ev => ev.CategoryID).ToList();

        //    // 重新設定分頁與顯示
        //    SetupPagination();
        //    DisplayPage();


        //}

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "" &&
                (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "修改" ||
                 dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "新增照片"))
            {
                // 取消該欄的選擇，讓使用者點擊無效
                dataGridView1.ClearSelection();
                return;
            }
            // 0604如果是右鍵點擊且點到有效列，選中該列並顯示右鍵選單
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];

                if (contextMenuStrip1 != null)
                    contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void ID遞增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            排序("ID遞增");
        }
        private void ID遞減ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            排序("ID遞減");
        }
        private void 類別遞增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            排序("類別遞增");
        }
        private void 排序(string sortBy)
        {
            switch (sortBy)
            {
                case "ID遞增":
                    allEvents = allEvents.OrderBy(ev => ev.EventID).ToList();
                    break;
                case "ID遞減":
                    allEvents = allEvents.OrderByDescending(ev => ev.EventID).ToList();
                    break;
                case "類別遞增":
                    allEvents = allEvents.OrderBy(ev => ev.CategoryID).ToList();
                    break;
                case "類別遞減":
                    allEvents = allEvents.OrderByDescending(ev => ev.CategoryID).ToList();
                    break;
                case "狀態遞增":
                    allEvents = allEvents.OrderByDescending(ev => ev.Status).ToList();
                    break;
                case "狀態遞減":
                    allEvents = allEvents.OrderByDescending(ev => ev.Status).ToList();
                    break;

                    //case "狀態遞增":
                    //    allEvents = allEvents.OrderBy(ev => ev.Status).ToList();
                    //    break;
                    // ...可依需求擴充
            }

            SetupPagination();
            DisplayPage();
        }

        private void 類別遞增ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            排序("類別遞增");
        }
        

        private void 類別遞減ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            排序("類別遞減");
        }
    

        private void 狀態遞增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            排序("狀態遞增");
        }

        private void 狀態遞減ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            排序("狀態遞減");
        }

        
    }
}


