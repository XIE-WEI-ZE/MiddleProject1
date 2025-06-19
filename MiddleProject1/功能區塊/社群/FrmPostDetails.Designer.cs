namespace MiddleProject1.功能區塊.社群
{
    partial class FrmPostDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labMemberID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.labTitla = new System.Windows.Forms.Label();
            this.btnEditPost = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labCreatedAt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewReplies = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labReplysMemberID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtReplyInput = new System.Windows.Forms.TextBox();
            this.btnPublishReply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplies)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMemberID
            // 
            this.labMemberID.AutoSize = true;
            this.labMemberID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMemberID.Location = new System.Drawing.Point(330, 59);
            this.labMemberID.Name = "labMemberID";
            this.labMemberID.Size = new System.Drawing.Size(60, 17);
            this.labMemberID.TabIndex = 13;
            this.labMemberID.Text = "會員編號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(257, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "發布會員 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "文章內容 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnDeletePost);
            this.groupBox1.Controls.Add(this.labTitla);
            this.groupBox1.Controls.Add(this.btnEditPost);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labCreatedAt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labMemberID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 247);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Silver;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(719, -1);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(51, 28);
            this.btnReport.TabIndex = 22;
            this.btnReport.Text = "檢舉";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletePost.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeletePost.Location = new System.Drawing.Point(675, 205);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(101, 42);
            this.btnDeletePost.TabIndex = 21;
            this.btnDeletePost.Text = "刪除文章";
            this.btnDeletePost.UseVisualStyleBackColor = false;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // labTitla
            // 
            this.labTitla.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitla.Location = new System.Drawing.Point(3, -3);
            this.labTitla.Name = "labTitla";
            this.labTitla.Size = new System.Drawing.Size(716, 30);
            this.labTitla.TabIndex = 14;
            this.labTitla.Text = "文章標題";
            // 
            // btnEditPost
            // 
            this.btnEditPost.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditPost.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditPost.Location = new System.Drawing.Point(568, 205);
            this.btnEditPost.Name = "btnEditPost";
            this.btnEditPost.Size = new System.Drawing.Size(101, 42);
            this.btnEditPost.TabIndex = 20;
            this.btnEditPost.Text = "編輯文章";
            this.btnEditPost.UseVisualStyleBackColor = false;
            this.btnEditPost.Click += new System.EventHandler(this.btnEditPost_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(518, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labCreatedAt
            // 
            this.labCreatedAt.AutoSize = true;
            this.labCreatedAt.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCreatedAt.Location = new System.Drawing.Point(330, 80);
            this.labCreatedAt.Name = "labCreatedAt";
            this.labCreatedAt.Size = new System.Drawing.Size(60, 17);
            this.labCreatedAt.TabIndex = 17;
            this.labCreatedAt.Text = "發布日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(258, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "發布日期 :";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtContent.Location = new System.Drawing.Point(24, 100);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(471, 137);
            this.txtContent.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 157);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "回覆";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridViewReplies);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 122);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewReplies
            // 
            this.dataGridViewReplies.AllowUserToAddRows = false;
            this.dataGridViewReplies.AllowUserToDeleteRows = false;
            this.dataGridViewReplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReplies.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReplies.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReplies.Name = "dataGridViewReplies";
            this.dataGridViewReplies.ReadOnly = true;
            this.dataGridViewReplies.RowTemplate.Height = 24;
            this.dataGridViewReplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReplies.Size = new System.Drawing.Size(758, 122);
            this.dataGridViewReplies.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "會員 :";
            // 
            // labReplysMemberID
            // 
            this.labReplysMemberID.AutoSize = true;
            this.labReplysMemberID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReplysMemberID.Location = new System.Drawing.Point(86, 35);
            this.labReplysMemberID.Name = "labReplysMemberID";
            this.labReplysMemberID.Size = new System.Drawing.Size(110, 31);
            this.labReplysMemberID.TabIndex = 16;
            this.labReplysMemberID.Text = "會員編號";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReplyInput);
            this.groupBox3.Controls.Add(this.btnPublishReply);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labReplysMemberID);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(12, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 156);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "說點什麼";
            // 
            // txtReplyInput
            // 
            this.txtReplyInput.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReplyInput.Location = new System.Drawing.Point(6, 69);
            this.txtReplyInput.Multiline = true;
            this.txtReplyInput.Name = "txtReplyInput";
            this.txtReplyInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplyInput.Size = new System.Drawing.Size(764, 81);
            this.txtReplyInput.TabIndex = 16;
            // 
            // btnPublishReply
            // 
            this.btnPublishReply.BackColor = System.Drawing.Color.Turquoise;
            this.btnPublishReply.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPublishReply.Location = new System.Drawing.Point(669, 24);
            this.btnPublishReply.Name = "btnPublishReply";
            this.btnPublishReply.Size = new System.Drawing.Size(101, 42);
            this.btnPublishReply.TabIndex = 19;
            this.btnPublishReply.Text = "發表回覆";
            this.btnPublishReply.UseVisualStyleBackColor = false;
            this.btnPublishReply.Click += new System.EventHandler(this.btnPublishReply_Click);
            // 
            // FrmPostDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPostDetails";
            this.Text = "FrmPostDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplies)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labMemberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labReplysMemberID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPublishReply;
        private System.Windows.Forms.TextBox txtReplyInput;
        private System.Windows.Forms.Label labCreatedAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditPost;
        private System.Windows.Forms.Label labTitla;
        private System.Windows.Forms.Button btnDeletePost;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dataGridViewReplies;
        private System.Windows.Forms.Panel panel1;
    }
}