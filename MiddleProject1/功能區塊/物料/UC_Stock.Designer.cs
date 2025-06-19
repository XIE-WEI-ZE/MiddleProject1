namespace MiddleProject1.功能區塊.物料
{
    partial class UC_Stock
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
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProductsDate = new System.Windows.Forms.Button();
            this.btnPurchasingOrders = new System.Windows.Forms.Button();
            this.btnSalesOrders = new System.Windows.Forms.Button();
            this.btnTransferOrders = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAddStoreProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(87, 47);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(76, 29);
            this.btnSuppliers.TabIndex = 0;
            this.btnSuppliers.Text = "供應商列表";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(3, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 449);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StoreProductID";
            this.Column1.HeaderText = "物品編號";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StoreProductName";
            this.Column2.HeaderText = "物品名稱";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QuantityPerUnit";
            this.Column3.HeaderText = "單位";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UnitsInStock";
            this.Column4.HeaderText = "總庫存量";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SupplierID";
            this.Column5.HeaderText = "供應商編號";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnProductsDate
            // 
            this.btnProductsDate.Location = new System.Drawing.Point(251, 47);
            this.btnProductsDate.Name = "btnProductsDate";
            this.btnProductsDate.Size = new System.Drawing.Size(76, 29);
            this.btnProductsDate.TabIndex = 2;
            this.btnProductsDate.Text = "庫存時間表";
            this.btnProductsDate.UseVisualStyleBackColor = true;
            this.btnProductsDate.Click += new System.EventHandler(this.btnProductsDate_Click);
            // 
            // btnPurchasingOrders
            // 
            this.btnPurchasingOrders.Location = new System.Drawing.Point(415, 47);
            this.btnPurchasingOrders.Name = "btnPurchasingOrders";
            this.btnPurchasingOrders.Size = new System.Drawing.Size(76, 29);
            this.btnPurchasingOrders.TabIndex = 3;
            this.btnPurchasingOrders.Text = "進貨單列表";
            this.btnPurchasingOrders.UseVisualStyleBackColor = true;
            this.btnPurchasingOrders.Click += new System.EventHandler(this.btnPurchasingOrders_Click);
            // 
            // btnSalesOrders
            // 
            this.btnSalesOrders.Location = new System.Drawing.Point(578, 47);
            this.btnSalesOrders.Name = "btnSalesOrders";
            this.btnSalesOrders.Size = new System.Drawing.Size(76, 29);
            this.btnSalesOrders.TabIndex = 4;
            this.btnSalesOrders.Text = "銷貨單列表";
            this.btnSalesOrders.UseVisualStyleBackColor = true;
            this.btnSalesOrders.Click += new System.EventHandler(this.btnSalesOrders_Click);
            // 
            // btnTransferOrders
            // 
            this.btnTransferOrders.Location = new System.Drawing.Point(742, 47);
            this.btnTransferOrders.Name = "btnTransferOrders";
            this.btnTransferOrders.Size = new System.Drawing.Size(76, 29);
            this.btnTransferOrders.TabIndex = 5;
            this.btnTransferOrders.Text = "轉倉單列表";
            this.btnTransferOrders.UseVisualStyleBackColor = true;
            this.btnTransferOrders.Click += new System.EventHandler(this.btnTransferOrders_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(3, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(76, 29);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "重新整理";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAddStoreProducts
            // 
            this.btnAddStoreProducts.Location = new System.Drawing.Point(3, 110);
            this.btnAddStoreProducts.Name = "btnAddStoreProducts";
            this.btnAddStoreProducts.Size = new System.Drawing.Size(76, 29);
            this.btnAddStoreProducts.TabIndex = 8;
            this.btnAddStoreProducts.Text = "新增物品";
            this.btnAddStoreProducts.UseVisualStyleBackColor = true;
            this.btnAddStoreProducts.Click += new System.EventHandler(this.btnAddStoreProducts_Click);
            // 
            // UC_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddStoreProducts);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnTransferOrders);
            this.Controls.Add(this.btnSalesOrders);
            this.Controls.Add(this.btnPurchasingOrders);
            this.Controls.Add(this.btnProductsDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSuppliers);
            this.Name = "UC_Stock";
            this.Size = new System.Drawing.Size(982, 597);
            this.Load += new System.EventHandler(this.UC_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProductsDate;
        private System.Windows.Forms.Button btnPurchasingOrders;
        private System.Windows.Forms.Button btnSalesOrders;
        private System.Windows.Forms.Button btnTransferOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAddStoreProducts;
    }
}
