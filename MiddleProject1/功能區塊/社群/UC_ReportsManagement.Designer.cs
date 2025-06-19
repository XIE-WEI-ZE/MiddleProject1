namespace MiddleProject1.功能區塊.社群
{
    partial class UC_ReportsManagement
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
            this.labPageInfo = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.SearchPostsGroupBox = new System.Windows.Forms.GroupBox();
            this.cmbReportStatuses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearchPosts = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReportedAt = new System.Windows.Forms.TextBox();
            this.txtReportReasonType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbActionTaken = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReporterName = new System.Windows.Forms.TextBox();
            this.txtTargetType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchPostsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labPageInfo
            // 
            this.labPageInfo.AutoSize = true;
            this.labPageInfo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPageInfo.Location = new System.Drawing.Point(415, 548);
            this.labPageInfo.Name = "labPageInfo";
            this.labPageInfo.Size = new System.Drawing.Size(150, 24);
            this.labPageInfo.TabIndex = 20;
            this.labPageInfo.Text = "第 X 頁 / 共 X 頁";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevious.Location = new System.Drawing.Point(295, 541);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(104, 39);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "< 上一頁";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 285);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(930, 245);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(581, 541);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 39);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "下一頁 >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLastPage.Location = new System.Drawing.Point(691, 541);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(104, 39);
            this.btnLastPage.TabIndex = 17;
            this.btnLastPage.Text = "頁尾>>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // SearchPostsGroupBox
            // 
            this.SearchPostsGroupBox.Controls.Add(this.cmbReportStatuses);
            this.SearchPostsGroupBox.Controls.Add(this.label2);
            this.SearchPostsGroupBox.Controls.Add(this.btnReset);
            this.SearchPostsGroupBox.Controls.Add(this.btnSearchPosts);
            this.SearchPostsGroupBox.Location = new System.Drawing.Point(26, 17);
            this.SearchPostsGroupBox.Name = "SearchPostsGroupBox";
            this.SearchPostsGroupBox.Size = new System.Drawing.Size(930, 71);
            this.SearchPostsGroupBox.TabIndex = 14;
            this.SearchPostsGroupBox.TabStop = false;
            this.SearchPostsGroupBox.Text = "檢舉清單查詢";
            // 
            // cmbReportStatuses
            // 
            this.cmbReportStatuses.FormattingEnabled = true;
            this.cmbReportStatuses.Items.AddRange(new object[] {
            "待處理",
            "處理中",
            "已處理",
            "已駁回"});
            this.cmbReportStatuses.Location = new System.Drawing.Point(67, 28);
            this.cmbReportStatuses.Name = "cmbReportStatuses";
            this.cmbReportStatuses.Size = new System.Drawing.Size(121, 20);
            this.cmbReportStatuses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "狀態 :";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(269, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(37, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearchPosts
            // 
            this.btnSearchPosts.Location = new System.Drawing.Point(225, 19);
            this.btnSearchPosts.Name = "btnSearchPosts";
            this.btnSearchPosts.Size = new System.Drawing.Size(38, 36);
            this.btnSearchPosts.TabIndex = 1;
            this.btnSearchPosts.Text = "搜尋";
            this.btnSearchPosts.UseVisualStyleBackColor = true;
            this.btnSearchPosts.Click += new System.EventHandler(this.btnSearchPosts_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirstPage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFirstPage.Location = new System.Drawing.Point(198, 541);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(91, 39);
            this.btnFirstPage.TabIndex = 16;
            this.btnFirstPage.Text = "<< 頁首";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReportedAt);
            this.groupBox1.Controls.Add(this.txtReportReasonType);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.cmbActionTaken);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtReporterName);
            this.groupBox1.Controls.Add(this.txtTargetType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtReportID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(26, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 163);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檢舉詳細資料";
            // 
            // txtReportedAt
            // 
            this.txtReportedAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtReportedAt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReportedAt.Location = new System.Drawing.Point(599, 25);
            this.txtReportedAt.Name = "txtReportedAt";
            this.txtReportedAt.ReadOnly = true;
            this.txtReportedAt.Size = new System.Drawing.Size(176, 29);
            this.txtReportedAt.TabIndex = 21;
            // 
            // txtReportReasonType
            // 
            this.txtReportReasonType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtReportReasonType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReportReasonType.Location = new System.Drawing.Point(336, 70);
            this.txtReportReasonType.Name = "txtReportReasonType";
            this.txtReportReasonType.ReadOnly = true;
            this.txtReportReasonType.Size = new System.Drawing.Size(439, 29);
            this.txtReportReasonType.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(233, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "被檢舉原因 :";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(817, 67);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(76, 36);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "查看詳細";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStatus.Location = new System.Drawing.Point(67, 117);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(124, 29);
            this.txtStatus.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(817, 117);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 36);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbActionTaken
            // 
            this.cmbActionTaken.AutoCompleteCustomSource.AddRange(new string[] {
            "處理中",
            "已處理",
            "已駁回"});
            this.cmbActionTaken.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbActionTaken.FormattingEnabled = true;
            this.cmbActionTaken.Items.AddRange(new object[] {
            "處理中",
            "已處理",
            "已駁回"});
            this.cmbActionTaken.Location = new System.Drawing.Point(617, 117);
            this.cmbActionTaken.Name = "cmbActionTaken";
            this.cmbActionTaken.Size = new System.Drawing.Size(158, 28);
            this.cmbActionTaken.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(530, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "採取行動 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "狀態 :";
            // 
            // txtReporterName
            // 
            this.txtReporterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtReporterName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReporterName.Location = new System.Drawing.Point(365, 25);
            this.txtReporterName.Name = "txtReporterName";
            this.txtReporterName.ReadOnly = true;
            this.txtReporterName.Size = new System.Drawing.Size(141, 29);
            this.txtReporterName.TabIndex = 9;
            // 
            // txtTargetType
            // 
            this.txtTargetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTargetType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTargetType.Location = new System.Drawing.Point(115, 70);
            this.txtTargetType.Name = "txtTargetType";
            this.txtTargetType.ReadOnly = true;
            this.txtTargetType.Size = new System.Drawing.Size(112, 29);
            this.txtTargetType.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "被檢舉類型 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(512, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "檢舉日期 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(262, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "被檢舉會員 :";
            // 
            // txtReportID
            // 
            this.txtReportID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtReportID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReportID.Location = new System.Drawing.Point(115, 25);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(141, 29);
            this.txtReportID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(12, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "檢舉編號 :";
            // 
            // UC_ReportsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labPageInfo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.SearchPostsGroupBox);
            this.Controls.Add(this.btnFirstPage);
            this.Name = "UC_ReportsManagement";
            this.Size = new System.Drawing.Size(982, 597);
            this.Load += new System.EventHandler(this.UC_ReportsManagement_Load);
            this.SearchPostsGroupBox.ResumeLayout(false);
            this.SearchPostsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labPageInfo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.GroupBox SearchPostsGroupBox;
        private System.Windows.Forms.ComboBox cmbReportStatuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearchPosts;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbActionTaken;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReporterName;
        private System.Windows.Forms.TextBox txtTargetType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtReportReasonType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReportedAt;
    }
}
