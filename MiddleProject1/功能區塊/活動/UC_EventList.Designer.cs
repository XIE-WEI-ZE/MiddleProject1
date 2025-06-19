namespace MiddleProject1.功能區塊.活動
{
    partial class UC_EventList
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhEventDataSet1 = new MiddleProject1.功能區塊.活動.nhEventDataSet();
            this.eventCategoryTableAdapter2 = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.EventCategoryTableAdapter();
            this.eventDetailsTableAdapter2 = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.EventDetailsTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID遞增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID遞減ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.類別遞增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.類別遞減ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.狀態遞增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.狀態遞減ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "活動明細";
            // 
            // uiButton5
            // 
            this.uiButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton5.Location = new System.Drawing.Point(1108, 41);
            this.uiButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiButton5.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Size = new System.Drawing.Size(133, 43);
            this.uiButton5.TabIndex = 10;
            this.uiButton5.Text = "新增";
            this.uiButton5.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 482);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(525, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 25);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(303, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // uiButton6
            // 
            this.uiButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton6.Location = new System.Drawing.Point(847, 41);
            this.uiButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiButton6.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton6.Name = "uiButton6";
            this.uiButton6.Size = new System.Drawing.Size(133, 43);
            this.uiButton6.TabIndex = 14;
            this.uiButton6.Text = "搜尋";
            this.uiButton6.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton6.Click += new System.EventHandler(this.uiButton6_Click);
            // 
            // nhEventDataSet1
            // 
            this.nhEventDataSet1.DataSetName = "nhEventDataSet";
            this.nhEventDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventCategoryTableAdapter2
            // 
            this.eventCategoryTableAdapter2.ClearBeforeFill = true;
            // 
            // eventDetailsTableAdapter2
            // 
            this.eventDetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.排序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 排序ToolStripMenuItem
            // 
            this.排序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID遞增ToolStripMenuItem,
            this.ID遞減ToolStripMenuItem,
            this.類別遞增ToolStripMenuItem,
            this.類別遞減ToolStripMenuItem,
            this.狀態遞增ToolStripMenuItem,
            this.狀態遞減ToolStripMenuItem});
            this.排序ToolStripMenuItem.Name = "排序ToolStripMenuItem";
            this.排序ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.排序ToolStripMenuItem.Text = "排序";
            // 
            // ID遞增ToolStripMenuItem
            // 
            this.ID遞增ToolStripMenuItem.Name = "ID遞增ToolStripMenuItem";
            this.ID遞增ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ID遞增ToolStripMenuItem.Text = "ID遞增";
            this.ID遞增ToolStripMenuItem.Click += new System.EventHandler(this.ID遞增ToolStripMenuItem_Click);
            // 
            // ID遞減ToolStripMenuItem
            // 
            this.ID遞減ToolStripMenuItem.Name = "ID遞減ToolStripMenuItem";
            this.ID遞減ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ID遞減ToolStripMenuItem.Text = "ID遞減";
            this.ID遞減ToolStripMenuItem.Click += new System.EventHandler(this.ID遞減ToolStripMenuItem_Click);
            // 
            // 類別遞增ToolStripMenuItem
            // 
            this.類別遞增ToolStripMenuItem.Name = "類別遞增ToolStripMenuItem";
            this.類別遞增ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.類別遞增ToolStripMenuItem.Text = "類別遞增";
            this.類別遞增ToolStripMenuItem.Click += new System.EventHandler(this.類別遞增ToolStripMenuItem_Click_1);
            // 
            // 類別遞減ToolStripMenuItem
            // 
            this.類別遞減ToolStripMenuItem.Name = "類別遞減ToolStripMenuItem";
            this.類別遞減ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.類別遞減ToolStripMenuItem.Text = "類別遞減";
            this.類別遞減ToolStripMenuItem.Click += new System.EventHandler(this.類別遞減ToolStripMenuItem_Click);
            // 
            // 狀態遞增ToolStripMenuItem
            // 
            this.狀態遞增ToolStripMenuItem.Name = "狀態遞增ToolStripMenuItem";
            this.狀態遞增ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.狀態遞增ToolStripMenuItem.Text = "狀態遞增";
            this.狀態遞增ToolStripMenuItem.Click += new System.EventHandler(this.狀態遞增ToolStripMenuItem_Click);
            // 
            // 狀態遞減ToolStripMenuItem
            // 
            this.狀態遞減ToolStripMenuItem.Name = "狀態遞減ToolStripMenuItem";
            this.狀態遞減ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.狀態遞減ToolStripMenuItem.Text = "狀態遞減";
            this.狀態遞減ToolStripMenuItem.Click += new System.EventHandler(this.狀態遞減ToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // uiButton4
            // 
            this.uiButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton4.Location = new System.Drawing.Point(1108, 28);
            this.uiButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiButton4.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(133, 43);
            this.uiButton4.TabIndex = 9;
            this.uiButton4.Text = ">>";
            this.uiButton4.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton4.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton3.Location = new System.Drawing.Point(847, 28);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiButton3.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(133, 43);
            this.uiButton3.TabIndex = 8;
            this.uiButton3.Text = ">";
            this.uiButton3.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton3.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(585, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "第1頁 / 共2頁";
            // 
            // uiButton2
            // 
            this.uiButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Location = new System.Drawing.Point(325, 28);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiButton2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(133, 43);
            this.uiButton2.TabIndex = 6;
            this.uiButton2.Text = "<";
            this.uiButton2.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Location = new System.Drawing.Point(64, 28);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiButton1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(133, 43);
            this.uiButton1.TabIndex = 7;
            this.uiButton1.Text = "<<";
            this.uiButton1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.uiButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiButton3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiButton4, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 663);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1305, 100);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiButton6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiButton5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1305, 125);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // UC_EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_EventList";
            this.Size = new System.Drawing.Size(1305, 763);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Sunny.UI.UIButton uiButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Sunny.UI.UIButton uiButton6;
        private nhEventDataSet nhEventDataSet1;
        private nhEventDataSetTableAdapters.EventCategoryTableAdapter eventCategoryTableAdapter2;
        private nhEventDataSetTableAdapters.EventDetailsTableAdapter eventDetailsTableAdapter2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ID遞增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ID遞減ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 類別遞增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 類別遞減ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 狀態遞增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 狀態遞減ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
