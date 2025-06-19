using Sunny.UI;
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

namespace MiddleProject1.功能區塊.社群
{
    public partial class UC_ReportsManagement : UserControl
    {
        public UC_ReportsManagement()
        {
            InitializeComponent();

            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;

            InitializeReportStatusesComboBox();
        }

        private void InitializeReportStatusesComboBox()
        {
            cmbReportStatuses.Items.Clear();
            cmbReportStatuses.Items.Add("所有狀態");
            cmbReportStatuses.Items.Add("待處理");
            cmbReportStatuses.Items.Add("已結案");
            cmbReportStatuses.Items.Add("已駁回");
            cmbReportStatuses.Items.Add("處理中");
            cmbReportStatuses.SelectedIndex = 0;

            cmbActionTaken.Items.Clear();
            cmbActionTaken.Items.Add("已結案");
            cmbActionTaken.Items.Add("已駁回");
            cmbActionTaken.SelectedIndex = -1;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedAction = cmbActionTaken.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedAction))
            {
                MessageBox.Show("請選擇處理狀態！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先選擇一個報告！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string reportID = listView1.SelectedItems[0].Text;

            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string updateQuery = "UPDATE CommunityReports SET ReportStatus = @status, ResolvedAt = CURRENT_TIMESTAMP WHERE ReportID = @reportID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", selectedAction);
                        cmd.Parameters.AddWithValue("@reportID", reportID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("報告狀態更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReports();
                        }
                        else
                        {
                            MessageBox.Show("更新失敗，請檢查報告 ID 是否正確！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新報告狀態時發生錯誤: {ex.Message}", "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReports()
        {
            btnSearchPosts_Click(null, null);
        }

        private void UC_ReportsManagement_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadData(1);
        }

        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;

        private void SetupListView()
        {
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("檢舉編號", 100);
            listView1.Columns.Add("檢舉會員編號", 100);
            listView1.Columns.Add("被檢舉會員編號", 100);

            // --- 修改：將「所屬文章標題」改為「所屬文章編號」---
            listView1.Columns.Add("所屬文章編號", 100); // 寬度可以調整
            // --------------------------------------------------

            listView1.Columns.Add("ReportedContentId_Hidden", 0); // 索引 4 (隱藏)
            listView1.Columns[4].Width = 0;

            listView1.Columns.Add("檢舉類型", 80);        // 索引 5
            listView1.Columns.Add("檢舉時間", 140);        // 索引 6
            listView1.Columns.Add("檢舉原因", 200);        // 索引 7
            listView1.Columns.Add("狀態", 80);            // 索引 8
            listView1.Columns.Add("處理時間", 130);        // 索引 9
        }

        private void LoadData(int page)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Count query needs to reflect the same joins for accurate total records
                    string countQuery = @"
                        SELECT COUNT(r.ReportID)
                        FROM CommunityReports r
                        JOIN CommunityReportedContent cr ON r.ReportedContentId = cr.ReportedContentId
                        LEFT JOIN CommunityPosts p_for_post ON cr.PostID = p_for_post.PostID
                        LEFT JOIN CommunityReplys crp ON cr.ReplyID = crp.ReplyID
                        LEFT JOIN CommunityPosts p_for_reply ON crp.PostID = p_for_reply.PostID";

                    SqlCommand countCmd = new SqlCommand(countQuery, conn);
                    totalRecords = (int)countCmd.ExecuteScalar();

                    int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                    string query = @"
                        SELECT
                            r.ReportID,
                            r.ReportMemberID,
                            r.TargetMemberID,
                            cr.ReportedContentId,
                            -- 修改：將 AssociatedPostTitle 改為 AssociatedPostID
                            COALESCE(
                                CAST(p_for_post.PostID AS NVARCHAR(50)), -- 轉換為 NVARCHAR 以便 COALESCE 處理字串
                                CAST(p_for_reply.PostID AS NVARCHAR(50)),
                                '(查無文章編號)' -- 當兩者都為 NULL 時顯示
                            ) AS AssociatedPostID,
                            cr.Category AS TargetType,
                            r.ReportedAt,
                            r.ReportReasonType,
                            r.ReportStatus,
                            r.AssignedEmployeeID,
                            r.ResolvedAt,
                            r.Notes
                        FROM CommunityReports r
                        JOIN CommunityReportedContent cr ON r.ReportedContentId = cr.ReportedContentId
                        LEFT JOIN CommunityPosts p_for_post ON cr.PostID = p_for_post.PostID
                        LEFT JOIN CommunityReplys crp ON cr.ReplyID = crp.ReplyID
                        LEFT JOIN CommunityPosts p_for_reply ON crp.PostID = p_for_reply.PostID
                        ORDER BY r.ReportID
                        OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@offset", (page - 1) * pageSize);
                    command.Parameters.AddWithValue("@pageSize", pageSize);

                    SqlDataReader reader = command.ExecuteReader();

                    listView1.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ReportID"].ToString());

                        item.SubItems.Add(reader["ReportMemberID"].ToString());
                        item.SubItems.Add(reader["TargetMemberID"].ToString());
                        // 修改：從 AssociatedPostID 欄位讀取
                        item.SubItems.Add(reader["AssociatedPostID"].ToString()); // 索引 3
                        item.SubItems.Add(reader["ReportedContentId"].ToString());   // 索引 4 (隱藏)
                        item.SubItems.Add(reader["TargetType"].ToString());          // 索引 5
                        item.SubItems.Add(reader["ReportedAt"].ToString());          // 索引 6
                        item.SubItems.Add(reader["ReportReasonType"].ToString());    // 索引 7
                        item.SubItems.Add(reader["ReportStatus"].ToString());        // 索引 8
                        item.SubItems.Add(reader["ResolvedAt"].ToString());          // 索引 9

                        listView1.Items.Add(item);
                    }
                    reader.Close();

                    labPageInfo.Text = $"第 {page} 頁 / 共 {totalPages} 頁";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入資料時發生錯誤: {ex.Message}", "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem selectedItem = e.Item;

                if (txtReportID != null)
                {
                    txtReportID.Text = selectedItem.Text;
                }

                if (selectedItem.SubItems.Count > 1 && txtReporterName != null)
                {
                    txtReporterName.Text = selectedItem.SubItems[1].Text;
                }
                else if (txtReporterName != null)
                {
                    txtReporterName.Text = "N/A";
                }

                // 如果您有一個 txtPostID 欄位來顯示文章編號，可以在這裡填入
                // 否則這部分可以保持不變或移除
                // if (selectedItem.SubItems.Count > 3 && txtPostID != null)
                // {
                //     txtPostID.Text = selectedItem.SubItems[3].Text; // 索引 3 現在是「所屬文章編號」
                // }
                // else if (txtPostID != null)
                // {
                //     txtPostID.Text = string.Empty;
                // }


                if (selectedItem.SubItems.Count > 5 && txtTargetType != null)
                {
                    txtTargetType.Text = selectedItem.SubItems[5].Text;
                }
                else if (txtTargetType != null)
                {
                    txtTargetType.Text = string.Empty;
                }

                if (selectedItem.SubItems.Count > 6 && txtReportedAt != null)
                {
                    txtReportedAt.Text = selectedItem.SubItems[6].Text;
                }
                else if (txtReportedAt != null)
                {
                    txtReportedAt.Text = string.Empty;
                }

                if (selectedItem.SubItems.Count > 7 && txtReportReasonType != null)
                {
                    txtReportReasonType.Text = selectedItem.SubItems[7].Text;
                }
                else if (txtReportReasonType != null)
                {
                    txtReportReasonType.Text = string.Empty;
                }

                if (selectedItem.SubItems.Count > 8 && txtStatus != null)
                {
                    txtStatus.Text = selectedItem.SubItems[8].Text;
                }
                else if (txtStatus != null)
                {
                    txtStatus.Text = string.Empty;
                }
            }
            else
            {
                if (txtReportID != null) txtReportID.Text = string.Empty;
                if (txtReporterName != null) txtReporterName.Text = string.Empty;
                // if (txtPostID != null) txtPostID.Text = string.Empty; // 如果有 txtPostID
                if (txtTargetType != null) txtTargetType.Text = string.Empty;
                if (txtReportedAt != null) txtReportedAt.Text = string.Empty;
                if (txtReportReasonType != null) txtReportReasonType.Text = string.Empty;
                if (txtStatus != null) txtStatus.Text = string.Empty;
                cmbActionTaken.SelectedIndex = -1;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            btnSearchPosts_Click(null, null);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                btnSearchPosts_Click(null, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                btnSearchPosts_Click(null, null);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPage = (int)Math.Ceiling((double)totalRecords / pageSize);
            btnSearchPosts_Click(null, null);
        }

        private void btnSearchPosts_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            StringBuilder queryBuilder = new StringBuilder();
            List<SqlParameter> parameters = new List<SqlParameter>();

            queryBuilder.Append(@"
                SELECT
                    r.ReportID,
                    r.ReportMemberID,
                    r.TargetMemberID,
                    cr.ReportedContentId,
                    -- 修改：將 AssociatedPostTitle 改為 AssociatedPostID
                    COALESCE(
                        CAST(p_for_post.PostID AS NVARCHAR(50)),
                        CAST(p_for_reply.PostID AS NVARCHAR(50)),
                        '(查無文章編號)'
                    ) AS AssociatedPostID,
                    cr.Category AS TargetType,
                    r.ReportedAt,
                    r.ReportReasonType,
                    r.ReportStatus,
                    r.AssignedEmployeeID,
                    r.ResolvedAt,
                    r.Notes
                FROM CommunityReports r
                JOIN CommunityReportedContent cr ON r.ReportedContentId = cr.ReportedContentId
                LEFT JOIN CommunityPosts p_for_post ON cr.PostID = p_for_post.PostID
                LEFT JOIN CommunityReplys crp ON cr.ReplyID = crp.ReplyID
                LEFT JOIN CommunityPosts p_for_reply ON crp.PostID = p_for_reply.PostID
                WHERE 1=1");

            StringBuilder whereClauseBuilder = new StringBuilder();

            if (cmbReportStatuses.SelectedItem != null && cmbReportStatuses.SelectedItem.ToString() != "所有狀態")
            {
                string selectedStatus = cmbReportStatuses.SelectedItem.ToString();
                whereClauseBuilder.Append(" AND r.ReportStatus = @status");
                parameters.Add(new SqlParameter("@status", selectedStatus));
            }

            queryBuilder.Append(whereClauseBuilder.ToString());

            string countQuery = @"
                SELECT COUNT(r.ReportID)
                FROM CommunityReports r
                JOIN CommunityReportedContent cr ON r.ReportedContentId = cr.ReportedContentId
                LEFT JOIN CommunityPosts p_for_post ON cr.PostID = p_for_post.PostID
                LEFT JOIN CommunityReplys crp ON cr.ReplyID = crp.ReplyID
                LEFT JOIN CommunityPosts p_for_reply ON crp.PostID = p_for_reply.PostID
                WHERE 1=1" + whereClauseBuilder.ToString();


            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    SqlCommand countCmd = new SqlCommand(countQuery, conn);
                    foreach (var param in parameters)
                    {
                        countCmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
                    }
                    totalRecords = (int)countCmd.ExecuteScalar();
                    int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                    labPageInfo.Text = $"第 {currentPage} 頁 / 共 {totalPages} 頁";
                    if (totalRecords == 0)
                    {
                        currentPage = 0;
                        labPageInfo.Text = "第 0 頁 / 共 0 頁";
                    }
                    else if (currentPage > totalPages && totalPages > 0)
                    {
                        currentPage = totalPages;
                        labPageInfo.Text = $"第 {currentPage} 頁 / 共 {totalPages} 頁";
                    }
                    else if (totalPages == 0)
                    {
                        currentPage = 0;
                        labPageInfo.Text = "第 0 頁 / 共 0 頁";
                    }


                    queryBuilder.Append(" ORDER BY r.ReportID OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY");
                    parameters.Add(new SqlParameter("@offset", (currentPage - 1) * pageSize));
                    parameters.Add(new SqlParameter("@pageSize", pageSize));

                    SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn);

                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    listView1.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ReportID"].ToString());

                        item.SubItems.Add(reader["ReportMemberID"].ToString());
                        item.SubItems.Add(reader["TargetMemberID"].ToString());
                        // 修改：從 AssociatedPostID 欄位讀取
                        item.SubItems.Add(reader["AssociatedPostID"].ToString());   // 索引 3
                        item.SubItems.Add(reader["ReportedContentId"].ToString());     // 索引 4 (隱藏)
                        item.SubItems.Add(reader["TargetType"].ToString());            // 索引 5
                        item.SubItems.Add(reader["ReportedAt"].ToString());            // 索引 6
                        item.SubItems.Add(reader["ReportReasonType"].ToString());      // 索引 7
                        item.SubItems.Add(reader["ReportStatus"].ToString());          // 索引 8
                        item.SubItems.Add(reader["ResolvedAt"].ToString());            // 索引 9

                        listView1.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"執行搜尋時發生錯誤: {ex.Message}", "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbReportStatuses.SelectedIndex = 0;
            currentPage = 1;
            btnSearchPosts_Click(null, null);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先選擇一個報告！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string reportedContentId = listView1.SelectedItems[0].SubItems[4].Text;

            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            string contentQuery = "SELECT Category, PostID, ReplyID FROM CommunityReportedContent WHERE ReportedContentId = @reportedContentId";

            string category = "";
            string postId = "";
            string replyId = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(contentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@reportedContentId", reportedContentId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            category = reader["Category"].ToString();
                            postId = reader["PostID"] == DBNull.Value ? string.Empty : reader["PostID"].ToString();
                            replyId = reader["ReplyID"] == DBNull.Value ? string.Empty : reader["ReplyID"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("查無對應的報告內容！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (category == "Reply" && !string.IsNullOrEmpty(replyId))
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT PostID FROM CommunityReplys WHERE ReplyID = @replyId", conn))
                        {
                            cmd.Parameters.AddWithValue("@replyId", replyId);
                            object result = cmd.ExecuteScalar();
                            postId = result != null ? result.ToString() : string.Empty;
                        }
                    }
                }

                string postAuthorID = "";
                string title = ""; // 這裡仍然是文章標題，因為 FrmPostDetails 期望的是標題
                string content = "";
                string createdAt = "";

                if (!string.IsNullOrEmpty(postId))
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT MemberID, PostTitle, PostContent, CreatedAt FROM CommunityPosts WHERE PostID = @postId", conn))
                        {
                            cmd.Parameters.AddWithValue("@postId", postId);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                postAuthorID = reader["MemberID"].ToString();
                                title = reader["PostTitle"].ToString(); // 從資料庫讀取文章標題
                                content = reader["PostContent"].ToString();
                                createdAt = reader["CreatedAt"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("無法找到該貼文的詳細內容！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // 開啟文章詳細視窗時，仍然傳遞文章標題給 FrmPostDetails
                    FrmPostDetails detailsForm = new FrmPostDetails(postId, postAuthorID, null, title, content, createdAt);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("無法獲取相關貼文ID，無法查看詳細內容。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查看內容時發生錯誤: {ex.Message}", "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}