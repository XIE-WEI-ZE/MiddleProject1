namespace MiddleProject1.功能區塊.物料
{
    partial class FrmStoreProductsDate
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
            this.storeProductsDateDataGridView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.storeProductsDateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storeProductsDateDataGridView
            // 
            this.storeProductsDateDataGridView.AllowUserToAddRows = false;
            this.storeProductsDateDataGridView.AllowUserToDeleteRows = false;
            this.storeProductsDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeProductsDateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.storeProductsDateDataGridView.Location = new System.Drawing.Point(12, 12);
            this.storeProductsDateDataGridView.Name = "storeProductsDateDataGridView";
            this.storeProductsDateDataGridView.ReadOnly = true;
            this.storeProductsDateDataGridView.RowTemplate.Height = 24;
            this.storeProductsDateDataGridView.Size = new System.Drawing.Size(679, 349);
            this.storeProductsDateDataGridView.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(616, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.Column2.DataPropertyName = "ExpiryDate/ArrivalDate";
            this.Column2.HeaderText = "有效期限/進貨日期";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RemainingStocks";
            this.Column3.HeaderText = "剩餘數量";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StocksStatus";
            this.Column4.HeaderText = "供貨狀態";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmStoreProductsDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.storeProductsDateDataGridView);
            this.Name = "FrmStoreProductsDate";
            this.Text = "FrmStoreProductsDate";
            this.Load += new System.EventHandler(this.FrmStoreProductsDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeProductsDateDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView storeProductsDateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}