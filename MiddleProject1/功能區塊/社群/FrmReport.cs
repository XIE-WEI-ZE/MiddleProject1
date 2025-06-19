using Sunny.UI;
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

namespace MiddleProject1.功能區塊.社群
{
    public partial class FrmReport : Form
    {
        private string _contentType; // "Post" 或 "Reply"
        private string _contentId;      // 被檢舉的 PostID 或 ReplyID
        private string _reporterMemberId; // 提交檢舉的會員ID (數字ID)

        // 建構子接收 int 類型的 ID
        public FrmReport(string contentType, string contentId, string reporterMemberId)
        {
            InitializeComponent();
            this._contentType = contentType;
            this._contentId = contentId;
            this._reporterMemberId = reporterMemberId;

            // Optional: Set some initial text in a label for user confirmation
            // lblReportTarget.Text = $"您將檢舉一個 {contentType} (ID: {contentId})。請選擇原因:";
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // 綁定所有以 "btnReport" 開頭的按鈕點擊事件
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("btnReport"))
                {
                    btn.Click += ReportButtonClick;
                }
            }

        }
        private void ReportButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string reportReason = btn.Text; // 獲取按鈕的文字作為檢舉原因

            // 調用提交的方法
            SubmitReportToDatabase(reportReason);

        }

        private void SubmitReportToDatabase(string reportReason)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int reportedContentId;
                    int targetMemberID = 0; // 存放被檢舉內容的會員 ID

                    string checkSql = "";
                    string insertContentSql = "";
                    string getMemberSql = ""; // 用來獲取被檢舉內容作者的 MemberID

                    // DEBUG: 輸出傳入參數 
                    System.Diagnostics.Debug.WriteLine($"DEBUG: 檢舉內容類型 (_contentType): {_contentType}");
                    System.Diagnostics.Debug.WriteLine($"DEBUG: 被檢舉內容 ID (_contentId): {_contentId}");
                    System.Diagnostics.Debug.WriteLine($"DEBUG: 檢舉人會員 ID (_reporterMemberId): {_reporterMemberId}");


                    // 根據 contentType 設定 SQL 查詢
                    if (_contentType == "Post")
                    {
                        checkSql = "SELECT ReportedContentID FROM CommunityReportedContent WHERE Category = 'Post' AND PostID = @ContentId";
                        insertContentSql = "INSERT INTO CommunityReportedContent (Category, PostId, CreatedAt) OUTPUT INSERTED.ReportedContentId VALUES ('Post', @ContentId, GETDATE())";
                        getMemberSql = "SELECT MemberID FROM CommunityPosts WHERE PostID = @ContentId"; // 查找貼文的作者 ID
                    }
                    else if (_contentType == "Reply")
                    {
                        checkSql = "SELECT ReportedContentID FROM CommunityReportedContent WHERE Category = 'Reply' AND ReplyID = @ContentId";
                        insertContentSql = "INSERT INTO CommunityReportedContent (Category, ReplyID, CreatedAt) OUTPUT INSERTED.ReportedContentId VALUES ('Reply', @ContentId, GETDATE())";
                        getMemberSql = "SELECT MemberID FROM CommunityReplys WHERE ReplyID = @ContentId"; // 查找回覆的作者 ID
                    }
                    else
                    {
                        throw new ArgumentException("無效的檢舉內容類型。", nameof(_contentType));
                    }

                    // DEBUG: 輸出 SQL 語句和參數值 (用於獲取作者ID)
                    System.Diagnostics.Debug.WriteLine($"DEBUG: getMemberSql: {getMemberSql}");
                    // 嘗試轉換 _contentId 以確保有效性
                    if (!int.TryParse(_contentId, out int parsedContentIdForMemberQuery))
                    {
                        throw new FormatException($"無法將 _contentId '{_contentId}' 轉換為有效的數字。");
                    }
                    System.Diagnostics.Debug.WriteLine($"DEBUG: @ContentId for getMemberSql: {parsedContentIdForMemberQuery}");


                    // 查找或插入 CommunityReportedContent
                    using (SqlCommand cmdCheck = new SqlCommand(checkSql, conn, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@ContentId", int.Parse(_contentId));
                        object result = cmdCheck.ExecuteScalar();

                        if (result != null)
                        {
                            reportedContentId = Convert.ToInt32(result);
                        }
                        else
                        {
                            using (SqlCommand cmdInsertContent = new SqlCommand(insertContentSql, conn, transaction))
                            {
                                cmdInsertContent.Parameters.AddWithValue("@ContentId", int.Parse(_contentId));
                                reportedContentId = (int)cmdInsertContent.ExecuteScalar();
                            }
                        }
                    }

                    // 獲取被檢舉內容的作者 ID
                    using (SqlCommand cmdGetMemberId = new SqlCommand(getMemberSql, conn, transaction))
                    {
                        cmdGetMemberId.Parameters.AddWithValue("@ContentId", int.Parse(_contentId));
                        object memberResult = cmdGetMemberId.ExecuteScalar();

                        // *** DEBUG: 輸出查詢到的會員ID結果 ***
                        System.Diagnostics.Debug.WriteLine($"DEBUG: getMemberSql ExecuteScalar result (memberResult): {(memberResult == null ? "NULL" : memberResult.ToString())}");

                        if (memberResult != null)
                        {
                            targetMemberID = Convert.ToInt32(memberResult);
                        }
                        else
                        {
                            // 如果找不到作者 ID，表示內容可能有其他異常。
                            MessageBox.Show("未能找到被檢舉內容的作者 ID。檢舉將繼續提交。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            System.Diagnostics.Debug.WriteLine("DEBUG: 警告：未能找到被檢舉內容的作者 ID。TargetMemberID 將為 0 或預設值。");
                        }
                    }

                    // *** DEBUG: 最終要插入的 TargetMemberID ***
                    System.Diagnostics.Debug.WriteLine($"DEBUG: 最終 TargetMemberID 準備插入資料庫: {targetMemberID}");

                    // 插入 CommunityReports 表
                    string insertReportSql = "INSERT INTO CommunityReports (ReportMemberID, ReportedContentId, TargetType, TargetMemberID, ReportedAt, ReportStatus, ReportReasonType) " +
                                             "VALUES (@ReportMemberID, @ReportedContentId, @TargetType, @TargetMemberID, GETDATE(), @ReportStatus, @ReportReasonType)";
                    using (SqlCommand cmdInsertReport = new SqlCommand(insertReportSql, conn, transaction))
                    {
                        cmdInsertReport.Parameters.AddWithValue("@ReportMemberID", int.Parse(_reporterMemberId)); // 檢舉人 ID
                        cmdInsertReport.Parameters.AddWithValue("@ReportedContentId", reportedContentId);
                        cmdInsertReport.Parameters.AddWithValue("@TargetType", "Content"); // 被檢舉目標類型 (固定為 'Content')
                        cmdInsertReport.Parameters.AddWithValue("@TargetMemberID", targetMemberID); // 被檢舉內容的作者 ID
                        cmdInsertReport.Parameters.AddWithValue("@ReportStatus", "待處理");
                        cmdInsertReport.Parameters.AddWithValue("@ReportReasonType", reportReason); // 檢舉原因類型 (新欄位)

                        cmdInsertReport.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("您的檢舉已提交！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (FormatException fex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"數據格式錯誤，ID 無法轉換為數字: {fex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"提交檢舉失敗，資料庫錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
