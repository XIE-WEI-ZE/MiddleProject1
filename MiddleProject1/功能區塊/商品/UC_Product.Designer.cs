namespace MiddleProject1.功能區塊.商品
{
    partial class UC_Product
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

        private void InitializeComponent()
        {
            this.btnNextPage = new Sunny.UI.UIButton();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnPrevPage = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.plPagination = new Sunny.UI.UIPanel();
            this.plTop = new Sunny.UI.UIPanel();
            this.flowPanelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.plTop.SuspendLayout();
            this.flowPanelTop.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextPage.Location = new System.Drawing.Point(830, 7);
            this.btnNextPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(126, 45);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = "下一頁";
            this.btnNextPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Consolas", 12F);
            this.lblPageInfo.Location = new System.Drawing.Point(369, 15);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(233, 28);
            this.lblPageInfo.TabIndex = 1;
            this.lblPageInfo.Text = "第 X 頁 / 共 Y 頁";
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevPage.Location = new System.Drawing.Point(24, 7);
            this.btnPrevPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(126, 45);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "上一頁";
            this.btnPrevPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevPage);
            this.panel1.Controls.Add(this.btnNextPage);
            this.panel1.Controls.Add(this.lblPageInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 722);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 65);
            this.panel1.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(3, 78);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 31;
            this.dgvProducts.Size = new System.Drawing.Size(973, 634);
            this.dgvProducts.TabIndex = 2;
            // 
            // plPagination
            // 
            this.plPagination.AutoSize = true;
            this.plPagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plPagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPagination.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plPagination.Location = new System.Drawing.Point(4, 720);
            this.plPagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plPagination.MinimumSize = new System.Drawing.Size(1, 1);
            this.plPagination.Name = "plPagination";
            this.plPagination.Radius = 1;
            this.plPagination.Size = new System.Drawing.Size(971, 1);
            this.plPagination.TabIndex = 3;
            this.plPagination.Text = "plPagination";
            this.plPagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plTop
            // 
            this.plTop.AutoSize = true;
            this.plTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plTop.Controls.Add(this.flowPanelTop);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plTop.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plTop.Location = new System.Drawing.Point(4, 5);
            this.plTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.plTop.Name = "plTop";
            this.plTop.Radius = 1;
            this.plTop.Size = new System.Drawing.Size(971, 65);
            this.plTop.TabIndex = 0;
            this.plTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPanelTop
            // 
            this.flowPanelTop.AutoSize = true;
            this.flowPanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanelTop.Controls.Add(this.btnAdd);
            this.flowPanelTop.Controls.Add(this.btnEdit);
            this.flowPanelTop.Controls.Add(this.btnDelete);
            this.flowPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelTop.Location = new System.Drawing.Point(0, 0);
            this.flowPanelTop.Name = "flowPanelTop";
            this.flowPanelTop.Size = new System.Drawing.Size(971, 65);
            this.flowPanelTop.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.plTop, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dgvProducts, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.plPagination, 0, 2);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(979, 726);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit.Location = new System.Drawing.Point(156, 10);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(10);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 45);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "編輯";
            this.btnEdit.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(302, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "刪除";
            this.btnDelete.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(979, 787);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.flowPanelTop.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private Sunny.UI.UIButton btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private Sunny.UI.UIButton btnPrevPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private Sunny.UI.UIPanel plPagination;
        private Sunny.UI.UIPanel plTop;
        private System.Windows.Forms.FlowLayoutPanel flowPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnDelete;
    }
}
