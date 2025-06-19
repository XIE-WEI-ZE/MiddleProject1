using MiddleProject1.Properties;
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
    public partial class FrmSelectEventList : Form
    {
        //private string Style;

        string style;
        public FrmSelectEventList(string style)
        {
            InitializeComponent();
            this.style = style;
            //CreateListViewColumns();//抓取column
            LoadListView();


            //if (style == "EventCategory")
            //{
            listView1.DoubleClick += listView1_DoubleClick;

            //}
            //else if (style == "EventList")
            //{
            //    listView1.DoubleClick += listView1_DoubleClick_EventList;
            //}
        }



        private void LoadListView()
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd;
                    if (style == "EventCategory")
                    {
                        cmd = new SqlCommand("SELECT CategoryID,CategoryName FROM EventCategory", conn);
                    }
                    else if (style == "EventList")
                    {
                        cmd = new SqlCommand("SELECT * FROM EventDetails", conn);
                    }
                    else if (style == "Employee")
                    {
                        cmd = new SqlCommand("  SELECT EmployeeID,Name FROM Employee", conn);
                    }
                    else
                    {
                        MessageBox.Show("查無資料表");
                        return;
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    listView1.Items.Clear();
                    listView1.Columns.Clear();

                    // ➤ 加入欄位 (一次性建置 Columns)
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        listView1.Columns.Add(reader.GetName(i));
                    }

                    // ➤ 加入資料列
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader[0].ToString());

                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            lvi.SubItems.Add(reader[i].ToString());
                        }

                        listView1.Items.Add(lvi);
                    }
                    listView1.FullRowSelect = true;//0601
                    listView1.View = View.Details; // ✅ 確保是表格模式
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // 自動調整欄寬
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料載入失敗：" + ex.Message);
            }
        }
        public int SelectedEventID { get; private set; } = -1;
        private void listView1_DoubleClick_EventList(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // 取得整列第1欄 (EventID)
                string eventIdStr = selectedItem.SubItems[0].Text;

                if (int.TryParse(eventIdStr, out int eventId))
                {
                    //MessageBox.Show($"雙擊選擇 EventID: {eventId}");
                    SelectedEventID = eventId;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("無法解析 EventID");
                }

            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // 取得整列第1欄 (EventID)
                string eventIdStr = selectedItem.SubItems[0].Text;

                if (int.TryParse(eventIdStr, out int eventId))
                {
                    //MessageBox.Show($"雙擊選擇 EventID: {eventId}");
                    SelectedEventID = eventId;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("無法解析 EventID");
                }

            }


        }
    }
}
