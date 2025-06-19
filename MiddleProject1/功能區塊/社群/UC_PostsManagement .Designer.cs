namespace MiddleProject1.功能區塊.社群
{
    partial class UC_PostsManagement
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchPostsGroupBox = new System.Windows.Forms.GroupBox();
            this.cmbPostMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPostYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPostStatuses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearchPostTitle = new System.Windows.Forms.TextBox();
            this.btnSearchPosts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labPageInfo = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnRestorePost = new System.Windows.Forms.Button();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchPostsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPostsGroupBox
            // 
            this.SearchPostsGroupBox.Controls.Add(this.cmbPostMonth);
            this.SearchPostsGroupBox.Controls.Add(this.label5);
            this.SearchPostsGroupBox.Controls.Add(this.label4);
            this.SearchPostsGroupBox.Controls.Add(this.cmbPostYear);
            this.SearchPostsGroupBox.Controls.Add(this.label3);
            this.SearchPostsGroupBox.Controls.Add(this.cmbPostStatuses);
            this.SearchPostsGroupBox.Controls.Add(this.label2);
            this.SearchPostsGroupBox.Controls.Add(this.btnReset);
            this.SearchPostsGroupBox.Controls.Add(this.txtSearchPostTitle);
            this.SearchPostsGroupBox.Controls.Add(this.btnSearchPosts);
            this.SearchPostsGroupBox.Controls.Add(this.label1);
            this.SearchPostsGroupBox.Location = new System.Drawing.Point(20, 20);
            this.SearchPostsGroupBox.Name = "SearchPostsGroupBox";
            this.SearchPostsGroupBox.Size = new System.Drawing.Size(930, 71);
            this.SearchPostsGroupBox.TabIndex = 0;
            this.SearchPostsGroupBox.TabStop = false;
            this.SearchPostsGroupBox.Text = "文章清單查詢";
            // 
            // cmbPostMonth
            // 
            this.cmbPostMonth.FormattingEnabled = true;
            this.cmbPostMonth.Location = new System.Drawing.Point(684, 30);
            this.cmbPostMonth.Name = "cmbPostMonth";
            this.cmbPostMonth.Size = new System.Drawing.Size(57, 20);
            this.cmbPostMonth.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(647, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "月 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(547, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "年 :";
            // 
            // cmbPostYear
            // 
            this.cmbPostYear.FormattingEnabled = true;
            this.cmbPostYear.Location = new System.Drawing.Point(584, 30);
            this.cmbPostYear.Name = "cmbPostYear";
            this.cmbPostYear.Size = new System.Drawing.Size(57, 20);
            this.cmbPostYear.TabIndex = 6;
            this.cmbPostYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(487, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "日期 :";
            // 
            // cmbPostStatuses
            // 
            this.cmbPostStatuses.FormattingEnabled = true;
            this.cmbPostStatuses.Items.AddRange(new object[] {
            "已發布",
            "已刪除"});
            this.cmbPostStatuses.Location = new System.Drawing.Point(336, 30);
            this.cmbPostStatuses.Name = "cmbPostStatuses";
            this.cmbPostStatuses.Size = new System.Drawing.Size(121, 20);
            this.cmbPostStatuses.TabIndex = 4;
            this.cmbPostStatuses.SelectedIndexChanged += new System.EventHandler(this.cmbPostStatuses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(271, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "狀態 :";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(882, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(37, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSearchPostTitle
            // 
            this.txtSearchPostTitle.Location = new System.Drawing.Point(105, 29);
            this.txtSearchPostTitle.Name = "txtSearchPostTitle";
            this.txtSearchPostTitle.Size = new System.Drawing.Size(141, 22);
            this.txtSearchPostTitle.TabIndex = 1;
            // 
            // btnSearchPosts
            // 
            this.btnSearchPosts.Location = new System.Drawing.Point(838, 22);
            this.btnSearchPosts.Name = "btnSearchPosts";
            this.btnSearchPosts.Size = new System.Drawing.Size(38, 36);
            this.btnSearchPosts.TabIndex = 1;
            this.btnSearchPosts.Text = "搜尋";
            this.btnSearchPosts.UseVisualStyleBackColor = true;
            this.btnSearchPosts.Click += new System.EventHandler(this.btnSearchPosts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "關鍵字 :";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(930, 397);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // labPageInfo
            // 
            this.labPageInfo.AutoSize = true;
            this.labPageInfo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPageInfo.Location = new System.Drawing.Point(409, 551);
            this.labPageInfo.Name = "labPageInfo";
            this.labPageInfo.Size = new System.Drawing.Size(150, 24);
            this.labPageInfo.TabIndex = 10;
            this.labPageInfo.Text = "第 X 頁 / 共 X 頁";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevious.Location = new System.Drawing.Point(289, 544);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(104, 39);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "< 上一頁";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(575, 544);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 39);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "下一頁 >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLastPage.Location = new System.Drawing.Point(685, 544);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(104, 39);
            this.btnLastPage.TabIndex = 7;
            this.btnLastPage.Text = "頁尾>>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirstPage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFirstPage.Location = new System.Drawing.Point(192, 544);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(91, 39);
            this.btnFirstPage.TabIndex = 6;
            this.btnFirstPage.Text = "<< 頁首";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnRestorePost
            // 
            this.btnRestorePost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRestorePost.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestorePost.Location = new System.Drawing.Point(736, 94);
            this.btnRestorePost.Name = "btnRestorePost";
            this.btnRestorePost.Size = new System.Drawing.Size(104, 39);
            this.btnRestorePost.TabIndex = 12;
            this.btnRestorePost.Text = "還原文章";
            this.btnRestorePost.UseVisualStyleBackColor = false;
            this.btnRestorePost.Click += new System.EventHandler(this.btnRestorePost_Click);
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletePost.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeletePost.Location = new System.Drawing.Point(846, 94);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(104, 39);
            this.btnDeletePost.TabIndex = 13;
            this.btnDeletePost.Text = "刪除文章";
            this.btnDeletePost.UseVisualStyleBackColor = false;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(20, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "測試前台";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_PostsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeletePost);
            this.Controls.Add(this.btnRestorePost);
            this.Controls.Add(this.labPageInfo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.SearchPostsGroupBox);
            this.Controls.Add(this.btnFirstPage);
            this.Name = "UC_PostsManagement";
            this.Size = new System.Drawing.Size(982, 597);
            this.Load += new System.EventHandler(this.UC_PostsManagement_Load);
            this.SearchPostsGroupBox.ResumeLayout(false);
            this.SearchPostsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchPostsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchPosts;
        private System.Windows.Forms.TextBox txtSearchPostTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labPageInfo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPostStatuses;
        private System.Windows.Forms.ComboBox cmbPostMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPostYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestorePost;
        private System.Windows.Forms.Button btnDeletePost;
        private System.Windows.Forms.Button button1;
    }
}
