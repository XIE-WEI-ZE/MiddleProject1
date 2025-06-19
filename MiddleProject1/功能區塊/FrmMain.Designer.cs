using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("首頁");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("會員明細管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("會員管理", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("員工基本資料");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("員工個人管理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("員工管理", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("房間總表");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("床位管理", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("活動明細");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("活動批次");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("報名");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("活動紀錄");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("活動管理", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("文章清單");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("檢舉清單");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("社群管理", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("商品管理");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("類別管理");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("訂單管理");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("商城管理", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("物料");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("物料管理", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("客服管理", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("帳號設定");
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(89)))), ((int)(((byte)(64)))));
            this.treeView1.Indent = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "首頁";
            treeNode2.Name = "會員明細管理";
            treeNode2.Text = "會員明細管理";
            treeNode3.Name = "Node1";
            treeNode3.Text = "會員管理";
            treeNode4.Name = "Node13";
            treeNode4.Text = "員工基本資料";
            treeNode5.Name = "Node14";
            treeNode5.Text = "員工個人管理";
            treeNode6.Name = "Node3";
            treeNode6.Text = "員工管理";
            treeNode7.Name = "bed";
            treeNode7.Text = "房間總表";
            treeNode8.Name = "Node4";
            treeNode8.Text = "床位管理";
            treeNode9.Name = "Node10";
            treeNode9.Text = "活動明細";
            treeNode10.Name = "Node11";
            treeNode10.Text = "活動批次";
            treeNode11.Name = "Node12";
            treeNode11.Text = "報名";
            treeNode12.Name = "Node13";
            treeNode12.Text = "活動紀錄";
            treeNode13.Name = "所有活動";
            treeNode13.Text = "活動管理";
            treeNode14.Name = "Node15";
            treeNode14.Text = "文章清單";
            treeNode15.Name = "Node16";
            treeNode15.Text = "檢舉清單";
            treeNode16.Name = "社群管理";
            treeNode16.Text = "社群管理";
            treeNode17.Name = "shopping";
            treeNode17.Text = "商品管理";
            treeNode18.Name = "Node8";
            treeNode18.Text = "類別管理";
            treeNode19.Name = "Node9";
            treeNode19.Text = "訂單管理";
            treeNode20.Name = "Node6";
            treeNode20.Text = "商城管理";
            treeNode21.Name = "測試123";
            treeNode21.Text = "物料";
            treeNode22.Name = "Node3";
            treeNode22.Text = "物料管理";
            treeNode23.Name = "Node0";
            treeNode23.Text = "Node0";
            treeNode24.Name = "Node1";
            treeNode24.Text = "Node1";
            treeNode25.Name = "Node2";
            treeNode25.Text = "Node2";
            treeNode26.Name = "客服管理";
            treeNode26.Text = "客服管理";
            treeNode27.Name = "Node5";
            treeNode27.Text = "帳號設定";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode6,
            treeNode8,
            treeNode13,
            treeNode16,
            treeNode20,
            treeNode22,
            treeNode26,
            treeNode27});
            this.treeView1.Size = new System.Drawing.Size(249, 564);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 720);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiButton2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 150);
            this.panel2.TabIndex = 0;
            // 
            // uiButton2
            // 
            this.uiButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Location = new System.Drawing.Point(1130, 50);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(150, 52);
            this.uiButton2.TabIndex = 5;
            this.uiButton2.Text = "登出";
            this.uiButton2.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(1280, 564);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 564);
            this.panel1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton uiButton2;
        private System.Windows.Forms.Panel panel2;
    }
}