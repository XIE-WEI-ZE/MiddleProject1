using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiddleProject1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Globalization;
using System.Net.NetworkInformation;

namespace MiddleProject1.功能區塊.社群
{
    public partial class FrmShowAllPosts : Form
    {
        private string memberID; // btnLogin_Click執行成功後，儲存會員編號
        public FrmShowAllPosts()
        {
            InitializeComponent();
            this.splitContainer1.Panel1.BackColor = Color.FromArgb(170, 200, 185);
        }

        // 當視窗載入時會做的事情
        private void FrmShowAllPosts_Load(object sender, EventArgs e)
        {
            btnPublishPost.Visible = false; // 預設隱藏發表按鈕
            btnLogout.Visible = false; // 預設隱藏登出按鈕
            LoadData(1); // 預設載入第 1 頁資料
        }

        private int currentPage = 1;
        private int pageSize = 10; // 每頁顯示 10 筆
        private int totalRecords = 0; // 資料總筆數
        public void LoadData(int page)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;

                    conn.Open();

                    // 計算總筆數
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM CommunityPosts WHERE PostStatuses = '已發布'", conn);
                    totalRecords = (int)countCmd.ExecuteScalar();

                    // 計算總頁數
                    int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                    // 取得指定頁的資料
                    string query = "SELECT PostTitle, CreatedAt, UpdatedAt FROM CommunityPosts WHERE PostStatuses = '已發布' ORDER BY UpdatedAt DESC OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@offset", (page - 1) * pageSize);
                    command.Parameters.AddWithValue("@pageSize", pageSize);

                    SqlDataReader dataReader = command.ExecuteReader();

                    listView1.Items.Clear(); // 清空 ListView 但不刪除欄位

                    if (listView1.Columns.Count == 0) // 確保只加入一次標題
                    {
                        listView1.View = View.Details;
                        listView1.Font = new Font("Microsoft JhengHei", 24);
                        listView1.Columns.Add("貼文標題", 860);
                        listView1.Columns.Add("發佈日期", 200);
                        listView1.Columns.Add("更新日期", 200);
                    }

                    while (dataReader.Read())
                    {
                        // 建立新項目並加入 ListView
                        ListViewItem item = new ListViewItem(dataReader["PostTitle"].ToString()); // 第一列
                        item.SubItems.Add(dataReader["CreatedAt"].ToString()); // 第二列
                        item.SubItems.Add(dataReader["UpdatedAt"].ToString()); // 第三列
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

        // 雙擊 ListView 項目時，開啟文章詳細視窗
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string title = selectedItem.Text; // 文章標題

                string createdAtText = selectedItem.SubItems[1].Text;
                //string updatedAt = selectedItem.SubItems[2].Text;

                // 查詢會員編號 & 文章內容
                string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
                string query = "SELECT PostID ,MemberID, PostContent, CreatedAt FROM CommunityPosts WHERE PostTitle = @title";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", title);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string postID = reader["PostID"].ToString(); // 從資料庫取得 PostId
                        string postAuthorID = reader["MemberID"].ToString(); // 發表者 ID
                        string content = reader["PostContent"].ToString();
                        string createdAt = reader["CreatedAt"].ToString();

                        // **開啟文章詳細視窗**
                        FrmPostDetails detailsForm = new FrmPostDetails(postID, postAuthorID, this.memberID, title, content, createdAt);
                        detailsForm.ShowDialog();
                    }
                }
            }

        }

        // 按下發表文章按鈕時開啟發表文章視窗
        private void btnPublishPost_Click(object sender, EventArgs e)
        {
            FrmPublishPost publishPost = new FrmPublishPost(this.memberID);
            publishPost.Show();
        }

        // 首頁按鈕
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(currentPage);
        }

        // 上一頁按鈕
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(currentPage);
            }
        }

        // 下一頁按鈕
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage * pageSize < totalRecords) // 確保不超過總筆數
            {
                currentPage++;
                LoadData(currentPage);
            }
        }

        // 尾頁按鈕
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = (int)Math.Ceiling((double)totalRecords / pageSize);
            LoadData(currentPage);
        }

        // 登入按鈕
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputMemberID = txtUserInput.Text.Trim(); // 取得使用者輸入

            if (!string.IsNullOrWhiteSpace(inputMemberID) && IsValidMemberID(inputMemberID))
            {
                this.memberID = inputMemberID; // 儲存會員編號
                MessageBox.Show($"歡迎您，會員 {inputMemberID}！");

                btnLogin.Visible = false; //隱藏登入按鈕
                label2.Visible = false; // 隱藏會員編號標籤
                txtUserInput.Visible = false; // 隱藏輸入框
                labWelcome.Text = $"歡迎您，會員 {inputMemberID}！"; //顯示會員名稱
                btnPublishPost.Visible = true; // 登入後允許發表文章
                btnLogout.Visible = true; // 顯示登出按鈕
            }
            else
            {
                MessageBox.Show("會員編號不存在，請重新輸入！");
            }

        }

        // 檢查會員編號是否存在於資料庫
        private bool IsValidMemberID(string memberID)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string query = "SELECT COUNT(*) FROM Member WHERE MemberID = @memberID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberID", memberID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // **回傳 `true` 代表 `MemberID` 存在**
                }
            }
        }

        // 登出按鈕
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.memberID = ""; // 清空會員編號
            labWelcome.Text = "訪客您好"; // 回到未登入狀態

            label2.Visible = true; // 顯示會員編號標籤
            txtUserInput.Visible = true; // 顯示輸入框
            txtUserInput.Text = string.Empty; // 清空輸入框

            btnLogin.Visible = true;  // 顯示登入按鈕
            btnLogout.Visible = false; // 隱藏登出按鈕
            btnPublishPost.Visible = false; // 隱藏發表文章按鈕

            MessageBox.Show("您已成功登出！");
        }

        // 刷新文章列表
        public void RefreshPosts()
        {
            LoadData(currentPage); //重新載入文章列表
        }
    }
}