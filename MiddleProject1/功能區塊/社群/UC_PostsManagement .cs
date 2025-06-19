using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.社群
{
    public partial class UC_PostsManagement : UserControl
    {
        public UC_PostsManagement()
        {
            InitializeComponent();
        }

        private void UC_PostsManagement_Load(object sender, EventArgs e)
        {
            SetupListView(); // 設定 ListView 方法
            LoadData(1); // 預設載入第 1 頁資料
            LoadYears(); // **載入年份**
            cmbPostMonth.Enabled = false; // **禁用月份選單**
        }

        // 設定 ListView 的欄位
        private void SetupListView()
        {
            listView1.Columns.Clear(); // 清空舊的 ColumnHeader，避免重複添加
            listView1.View = View.Details;
            listView1.FullRowSelect = true; // 確保可以選擇整行
            listView1.Font = new Font("Microsoft JhengHei", 12);

            // 修改：將「貼文ID」放在第一個欄位
            listView1.Columns.Add("貼文ID", 100);
            listView1.Columns.Add("貼文標題", 426);
            listView1.Columns.Add("發佈日期", 175);
            listView1.Columns.Add("更新日期", 175);
            listView1.Columns.Add("狀態", 100);
        }

        private int currentPage = 1;
        private int pageSize = 15; // 每頁顯示 10 筆
        private int totalRecords = 0; // 資料總筆數

        // 載入資料到 ListView
        private void LoadData(int page)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;

                    conn.Open();

                    // 計算總筆數
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM CommunityPosts", conn);
                    totalRecords = (int)countCmd.ExecuteScalar();

                    // 計算總頁數
                    int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                    // 取得指定頁的資料
                    string query = "SELECT PostID, PostTitle, CreatedAt, UpdatedAt, PostStatuses FROM CommunityPosts ORDER BY PostID DESC OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@offset", (page - 1) * pageSize);
                    command.Parameters.AddWithValue("@pageSize", pageSize);

                    SqlDataReader reader = command.ExecuteReader();

                    listView1.Items.Clear(); // 清空 ListView 但不刪除欄位

                    while (reader.Read())
                    {
                        // 建立新項目並加入 ListView
                        ListViewItem item = new ListViewItem(reader["PostID"].ToString()); // 第一列
                        item.SubItems.Add(reader["PostTitle"].ToString()); // 第二列
                        item.SubItems.Add(reader["CreatedAt"].ToString()); // 第三列
                        item.SubItems.Add(reader["UpdatedAt"].ToString()); // 第四列
                        item.SubItems.Add(reader["PostStatuses"].ToString()); // 第五列
                        item.Tag = reader["PostID"].ToString(); // 儲存 PostID 以便後續操作

                        listView1.Items.Add(item);
                    }

                    // 更新標籤顯示當前頁數
                    labPageInfo.Text = $"第 {page} 頁 / 共 {totalPages} 頁";

                } //Auto call conn.Close()=>conn.Dispose()  關連接 /釋放資源

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 載入年份和月份到下拉選單，根據 cmbYear 內選擇的年份，查詢所有有資料的月份
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = cmbPostYear.SelectedItem?.ToString(); // **取得選擇的年份**

            if (!string.IsNullOrEmpty(selectedYear))
            {
                cmbPostMonth.Enabled = true; // **選擇年份後，啟用月份**
                LoadMonthsByYear(selectedYear); // **載入該年份的月份**
            }
            else
            {
                cmbPostMonth.Enabled = false; // **如果沒有選年份，仍保持禁用**
            }
        }

        //讓 LoadYears() 只載入所有年份，而 cmbMonth 會根據年份動態更新
        private void LoadMonthsByYear(string year)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string query = "SELECT DISTINCT MONTH(CreatedAt) AS Month FROM CommunityPosts WHERE YEAR(CreatedAt) = @year ORDER BY Month ASC";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@year", year);
                SqlDataReader reader = cmd.ExecuteReader();

                cmbPostMonth.Items.Clear(); // 清空舊的月份

                while (reader.Read())
                {
                    cmbPostMonth.Items.Add(reader["Month"].ToString()); // **加入該年份有資料的月份**
                }
            }
        }

        // 載入所有年份到 cmbYear 下拉選單
        private void LoadYears()
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string query = "SELECT DISTINCT YEAR(CreatedAt) AS Year FROM CommunityPosts ORDER BY Year DESC";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cmbPostYear.Items.Clear();
                while (reader.Read())
                {
                    cmbPostYear.Items.Add(reader["Year"].ToString()); // **加入年份**
                }
            }
        }

        // 當使用者選擇狀態下拉選單時，載入對應的文章
        private void cmbPostStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPostStatuses.SelectedItem != null)
            {
                string selectedStatus = cmbPostStatuses.SelectedItem.ToString();
            }
        }

        //頁首按鈕
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(currentPage);
        }
        //上一頁按鈕
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(currentPage);
            }
        }
        //下一頁按鈕
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage * pageSize < totalRecords) // 確保不超過總筆數
            {
                currentPage++;
                LoadData(currentPage);
            }
        }
        //頁尾按鈕
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = (int)Math.Ceiling((double)totalRecords / pageSize);
            LoadData(currentPage);
        }

        //點擊後顯示詳細文章
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                // 從 Tag 屬性獲取 PostID
                string postID = selectedItem.Tag.ToString(); // 文章標題

                string createdAtText = selectedItem.SubItems[1].Text;
                //string updatedAt = selectedItem.SubItems[2].Text;

                // 查詢會員編號 & 文章內容
                string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
                string query = "SELECT MemberID, PostTitle, PostContent, CreatedAt FROM CommunityPosts WHERE PostID = @postID";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@postID", postID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string postAuthorID = reader["MemberID"].ToString(); // 發表者 ID
                        string title = reader["PostTitle"].ToString();       // 獲取文章標題 (用於傳給 FrmPostDetails)
                        string content = reader["PostContent"].ToString();
                        string createdAt = reader["CreatedAt"].ToString();

                        // 開啟文章詳細視窗
                        FrmPostDetails detailsForm = new FrmPostDetails(postID, postAuthorID, null, title, content, createdAt);
                        detailsForm.ShowDialog();
                    }
                }
            }
        }

        //搜尋按鈕
        private void btnSearchPosts_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string query = "SELECT PostID, PostTitle, CreatedAt, UpdatedAt, PostStatuses FROM CommunityPosts WHERE 1=1"; // **避免 SQL 語法錯誤**

            List<SqlParameter> parameters = new List<SqlParameter>();

            // 關鍵字搜尋：同時搜尋 PostTitle 和 PostID
            if (!string.IsNullOrWhiteSpace(txtSearchPostTitle.Text))
            {
                // 同時搜尋 PostTitle 和 PostID
                query += " AND (PostTitle LIKE @keyword OR PostID LIKE @keyword)";
                parameters.Add(new SqlParameter("@keyword", "%" + txtSearchPostTitle.Text + "%"));
            }

            // 狀態過濾
            if (cmbPostStatuses.SelectedItem != null)
            {
                string selectedStatus = cmbPostStatuses.SelectedItem.ToString();
                query += " AND PostStatuses = @status";
                parameters.Add(new SqlParameter("@status", selectedStatus));
            }

            // 年份過濾
            if (cmbPostYear.SelectedItem != null)
            {
                string selectedYear = cmbPostYear.SelectedItem.ToString();
                query += " AND YEAR(CreatedAt) = @year";
                parameters.Add(new SqlParameter("@year", selectedYear));
            }

            // 月份過濾（如果有選擇）
            if (cmbPostMonth.SelectedItem != null)
            {
                string selectedMonth = cmbPostMonth.SelectedItem.ToString().PadLeft(2, '0');
                query += " AND FORMAT(CreatedAt, 'MM') = @month";
                parameters.Add(new SqlParameter("@month", selectedMonth));
            }

            // 加入分頁邏輯
            query += " ORDER BY PostID DESC OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";
            parameters.Add(new SqlParameter("@offset", (currentPage - 1) * pageSize)); // **計算當前頁的起始位置**
            parameters.Add(new SqlParameter("@pageSize", pageSize)); // **限制為 10 筆**

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                listView1.Items.Clear(); // 清空 ListView 但不刪除欄位

                while (reader.Read())
                {
                    // 修改：確保將 PostID 作為 ListViewItem 的主文本，並將 PostTitle 作為 SubItem
                    ListViewItem item = new ListViewItem(reader["PostID"].ToString());
                    item.SubItems.Add(reader["PostTitle"].ToString());
                    item.SubItems.Add(reader["CreatedAt"].ToString());
                    item.SubItems.Add(reader["UpdatedAt"].ToString());
                    item.SubItems.Add(reader["PostStatuses"].ToString());
                    item.Tag = reader["PostID"].ToString(); // 確保 Tag 儲存 PostID

                    listView1.Items.Add(item);
                }
            }
        }

        // 重置搜尋條件按鈕
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchPostTitle.Text = "";        //*清空關鍵字輸入框
            cmbPostStatuses.SelectedIndex = -1; // 清空狀態選擇
            cmbPostYear.SelectedIndex = -1; // 清空年份選擇
            cmbPostMonth.SelectedIndex = -1; // 清空月份選擇
        }

        // 刪除貼文按鈕
        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string postID = selectedItem.Tag.ToString();

                DialogResult result = MessageBox.Show("確定要刪除此文章嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
                    string query = "UPDATE CommunityPosts SET PostStatuses = '已刪除' WHERE PostID = @postID";

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@postID", postID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("文章狀態已更改為「已刪除」！");
                    selectedItem.SubItems[4].Text = "已刪除"; // 即時更新 UI
                }
            }
        }

        // 還原貼文按鈕
        private void btnRestorePost_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string postID = selectedItem.Tag.ToString();

                DialogResult result = MessageBox.Show("確定要還原此文章嗎？", "還原確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
                    string query = "UPDATE CommunityPosts SET PostStatuses = '已發布' WHERE PostID = @postID";

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@postID", postID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("文章狀態已更改為「已發布」！");
                    selectedItem.SubItems[4].Text = "已發布"; // **即時更新 UI**
                }
            }
        }

        // 顯示前台按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            FrmShowAllPosts frmShowAllPosts = new FrmShowAllPosts();
            frmShowAllPosts.Show();
        }

    }
}
