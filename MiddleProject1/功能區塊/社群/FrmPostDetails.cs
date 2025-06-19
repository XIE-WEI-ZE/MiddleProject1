using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.社群
{
    public partial class FrmPostDetails : Form
    {
        private string currentPostID; // 貼文 ID
        private string postAuthorID; // 貼文發表者 ID
        private string loggedInMemberID; // 登入者 ID

        public FrmPostDetails(string postID, string postAuthorID, string loggedInMemberID, string title, string content, string createdAt)
        {
            InitializeComponent();
            this.currentPostID = postID; // 貼文 ID
            this.postAuthorID = postAuthorID; // 貼文發表者 ID
            this.loggedInMemberID = loggedInMemberID; // 存登入者 ID

            labMemberID.Text = postAuthorID; // 貼文發表者
            labTitla.Text = title.ToString();
            txtContent.Text = content.ToString();
            labCreatedAt.Text = createdAt.ToString();

            btnEditPost.Visible = false; // 預設隱藏編輯按鈕
            btnDeletePost.Visible = false; // 預設隱藏刪除按鈕

            CheckEditPermission(); // 檢查編輯文章權限
            CheckDeletePermission(); // 檢查刪除文章權限
            CheckReportPermission(); // 檢查檢舉權限

            labReplysMemberID.Text = loggedInMemberID; // 「說點什麼」的會員 ID

            currentPostID = postID;  // 儲存 PostID
            SetupDataGridView(); // 呼叫設定 DataGridView 欄位
            LoadPostImage(currentPostID); // 載入文章圖片
            LoadReplies(postID); // 載入回覆

            CheckLoginStatus(); // 執行登入檢查，如果沒有登入則隱藏「說點什麼」區塊
        }

        // 檢查是否有編輯權限
        private void CheckEditPermission()
        {
            if (loggedInMemberID == postAuthorID) // **只有發表者才能編輯**
            {
                btnEditPost.Visible = true; // **顯示編輯按鈕**
            }
            else
            {
                btnEditPost.Visible = false; // **保持隱藏**
            }
        }

        // 檢查是否有刪除權限
        private void CheckDeletePermission()
        {
            if (loggedInMemberID == postAuthorID) // **只有發表者能刪除**
            {
                btnDeletePost.Visible = true;
            }
            else
            {
                btnDeletePost.Visible = false; // **保持隱藏**
            }
        }

        // 檢查是否有檢舉權限
        private void CheckReportPermission()
        {
            if (loggedInMemberID != null) // **只有發表者才能編輯**
            {
                btnReport.Visible = true; // **顯示編輯按鈕**
            }
            else
            {
                btnReport.Visible = false; // **保持隱藏**
            }
        }

        // 檢查登入狀態，若未登入則隱藏「說點什麼」區塊
        private void CheckLoginStatus()
        {
            if (string.IsNullOrEmpty(loggedInMemberID)) // 未登入
            {
                groupBox3.Visible = false; // 隱藏「說點什麼」區塊
            }
            else
            {
                groupBox3.Visible = true; // **已登入，顯示內容**
            }
        }

        // 設定 DataGridVie 的欄位
        private void SetupDataGridView()
        {
            dataGridViewReplies.AutoGenerateColumns = false;
            dataGridViewReplies.Columns.Clear();
            dataGridViewReplies.RowTemplate.Height = 35; // 提高每一列的高度
            dataGridViewReplies.DefaultCellStyle.WrapMode = DataGridViewTriState.True;// 啟用自動換行

            // 新增回覆編號用於程式碼存取，但不顯示給用戶
            var replyIdColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReplyID", // 綁定到資料源中的 "ReplyID" 欄位
                HeaderText = "回覆ID",       // 標頭文字 (會隱藏)
                Name = "ReplyID",             // 欄位名稱，供程式碼存取
                Visible = false               // 將它設為不可見，程式碼可以存取
            };
            dataGridViewReplies.Columns.Add(replyIdColumn); // 先加入 ReplyID 欄位

            // 會員欄位
            var memberColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MemberID",
                HeaderText = "會員",
                Name = "MemberID",
                Width = 90
            };

            // 留言內容欄位
            var contentColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReplyContent",
                HeaderText = "留言內容",
                Name = "ReplyContent",
                Width = 500
            };

            dataGridViewReplies.Columns.Add(memberColumn);
            dataGridViewReplies.Columns.Add(contentColumn);

            // 加入檢舉按鈕欄，但只有登入（MemberID != null）才加
            if (!string.IsNullOrEmpty(loggedInMemberID))
            {
                DataGridViewButtonColumn reportButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Report",
                    HeaderText = "",
                    Text = "檢舉",
                    UseColumnTextForButtonValue = true,
                    Width = 80 // 窄一點即可
                };
                dataGridViewReplies.Columns.Add(reportButtonColumn);
            }

            // 綁定按鈕事件
            dataGridViewReplies.CellClick += DataGridViewReplies_CellClick;
        }

        // DataGridView 的 CellClick 事件處理器
        private void DataGridViewReplies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否點擊了有效的資料列 (排除標題列)
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewReplies.Rows.Count)
            {
                return;
            }

            // 檢查是否點擊了有效的欄 (確保 ColumnIndex 是在範圍內的)
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dataGridViewReplies.Columns.Count)
            {
                return;
            }

            // 確保點擊的是 "Report" 按鈕欄
            if (dataGridViewReplies.Columns[e.ColumnIndex].Name == "Report")
            {
                // 獲取被點擊的資料列
                DataGridViewRow row = dataGridViewReplies.Rows[e.RowIndex];

                // 獲取被檢舉回覆的實際 ReplyID
                string actualReplyIdToReport = row.Cells["ReplyID"].Value?.ToString();

                // 獲取被檢舉回覆的作者 MemberID (用於判斷是否匿名，以及作為 TargetMemberID)
                string replyAuthorMemberId = row.Cells["MemberID"].Value?.ToString();

                // 被檢舉的回覆是否有作者 ID
                if (!string.IsNullOrEmpty(replyAuthorMemberId))
                {
                    // 檢查是否成功獲取到被檢舉回覆的實際 ReplyID
                    if (string.IsNullOrEmpty(actualReplyIdToReport))
                    {
                        MessageBox.Show("無法獲取回覆的唯一識別ID，無法檢舉。請確認資料來源包含 ReplyID 欄位。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 確保檢舉人已登入
                    if (string.IsNullOrEmpty(loggedInMemberID))
                    {
                        MessageBox.Show("檢舉需要登入會員帳號。請先登入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    FrmReport reportForm = new FrmReport("Reply", actualReplyIdToReport, loggedInMemberID);
                    reportForm.ShowDialog(); // 使用 ShowDialog() 讓使用者完成檢舉後返回
                }
                else
                {
                    // 如果 replyAuthorMemberId 為空，表示此回覆沒有綁定會員 ID (可能是匿名發布或資料錯誤)
                    MessageBox.Show("此留言沒有有效的作者資訊，無法檢舉。", "無法檢舉", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // 載入回覆資料
        public void LoadReplies(string postID)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT ReplyID, MemberID, ReplyContent FROM CommunityReplys WHERE PostID = @postID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@postID", postID);
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridViewReplies.Rows.Clear(); // 清空舊資料

                while (reader.Read())
                {
                    int rowIndex = dataGridViewReplies.Rows.Add();
                    dataGridViewReplies.Rows[rowIndex].Cells["MemberID"].Value = reader["MemberID"].ToString();
                    dataGridViewReplies.Rows[rowIndex].Cells["ReplyContent"].Value = reader["ReplyContent"].ToString();

                    dataGridViewReplies.Rows[rowIndex].Cells["ReplyID"].Value = reader["ReplyID"].ToString();

                    // 之後要加入修改功能，可用 Tag 儲存 ReplyID
                    dataGridViewReplies.Rows[rowIndex].Tag = reader["ReplyID"].ToString();

                }
            }
        }

        // 載入貼文圖片
        private void LoadPostImage(string postID)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string query = "SELECT IsImage FROM CommunityAttachments WHERE PostID = @postID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                // **確保 `postID` 為數字**
                cmd.Parameters.Add("@postID", SqlDbType.Int).Value = Convert.ToInt32(postID);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms); // 顯示圖片
                    }
                }
            }
        }

        // 按下「發表回覆」按鈕的事件處理器
        private void btnPublishReply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReplyInput.Text))
            {
                MessageBox.Show("請輸入回覆內容！");
                return;
            }

            DateTime repliedAt = DateTime.Now; // 取得當前時間

            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string query = "INSERT INTO CommunityReplys (PostID, MemberID, ReplyContent, RepliedAt, ReplyStatuses) VALUES (@postID, @memberID, @replyContent, @repliedAt, @replyStatuses)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // 插入新回覆
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@postID", currentPostID); // 確保已經取得 PostId
                cmd.Parameters.AddWithValue("@memberID", loggedInMemberID); // 使用登入者的 `MemberID`
                cmd.Parameters.AddWithValue("@replyContent", txtReplyInput.Text);
                cmd.Parameters.AddWithValue("@repliedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@replyStatuses", "已發布");

                // **更新該文章的 UpdatedAt**
                string updatePostQuery = "UPDATE CommunityPosts SET UpdatedAt = @updatedAt WHERE PostID = @postID";
                SqlCommand cmdUpdatePost = new SqlCommand(updatePostQuery, conn);
                cmdUpdatePost.Parameters.AddWithValue("@updatedAt", repliedAt);
                cmdUpdatePost.Parameters.AddWithValue("@postId", currentPostID);
                cmdUpdatePost.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("回覆已成功發表！");

            txtReplyInput.Clear(); // **清空輸入框**
            LoadReplies(currentPostID);   // **重新載入回覆列表**
        }

        // 按下「編輯文章」按鈕的事件處理器
        private void btnEditPost_Click(object sender, EventArgs e)
        {
            this.Hide(); // **暫時隱藏 FrmPostDetails

            FrmEditPost frmeditForm = new FrmEditPost(currentPostID, postAuthorID, labTitla.Text, txtContent.Text, pictureBox1.Image);

            if (frmeditForm.ShowDialog() == DialogResult.OK)
            {
                FrmPostDetails newForm = new FrmPostDetails(currentPostID, postAuthorID, loggedInMemberID, labTitla.Text, txtContent.Text, labCreatedAt.Text);
                newForm.Show();
                this.Close(); // 關閉舊的 FrmPostDetails
            }
        }

        // 按下圖片的事件處理器，開啟圖片放大視窗
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                FormPreviewImage previewForm = new FormPreviewImage(pictureBox1.Image);
                previewForm.ShowDialog(); // **開啟圖片放大**
            }
        }

        // 按下「刪除文章」按鈕的事件處理器
        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            this.Hide(); // 暫時隱藏 FrmPostDetails

            DialogResult result = MessageBox.Show("確定要刪除這篇文章嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
                string query = "UPDATE CommunityPosts SET PostStatuses = '已刪除' WHERE PostID = @postID";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@postID", currentPostID);
                    cmd.ExecuteNonQuery();
                }

                // 更新FrmShowAllPosts
                FrmShowAllPosts mainForm = Application.OpenForms["FrmShowAllPosts"] as FrmShowAllPosts;
                if (mainForm != null)
                {
                    mainForm.RefreshPosts(); // 刷新文章列表
                }
                MessageBox.Show("文章已刪除!!!");
                this.Close(); // 關閉 FrmPostDetails
            }
            else
            {
                this.Show(); // 如果取消刪除，則顯示回 FrmPostDetails
            }
        }

        // 按下「檢舉」按鈕的事件處理器
        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport reportForm = new FrmReport("Post" ,currentPostID, loggedInMemberID); //第一個回傳Post代表檢舉類型是回覆
            reportForm.ShowDialog(); // **使用 ShowDialog() 讓使用者完成檢舉後返回**
        }
    }
}
