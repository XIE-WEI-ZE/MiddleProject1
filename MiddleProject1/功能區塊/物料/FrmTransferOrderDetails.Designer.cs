namespace MiddleProject1.功能區塊.物料
{
    partial class FrmTransferOrderDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.TransferOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOfTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransferOrderID,
            this.StoreProductID,
            this.QuantityOfTransfer,
            this.ExpiryDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(475, 337);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "關閉";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TransferOrderID
            // 
            this.TransferOrderID.DataPropertyName = "TransferOrderID";
            this.TransferOrderID.HeaderText = "轉倉單編號";
            this.TransferOrderID.Name = "TransferOrderID";
            this.TransferOrderID.ReadOnly = true;
            // 
            // StoreProductID
            // 
            this.StoreProductID.DataPropertyName = "StoreProductID";
            this.StoreProductID.HeaderText = "物品編號";
            this.StoreProductID.Name = "StoreProductID";
            this.StoreProductID.ReadOnly = true;
            // 
            // QuantityOfTransfer
            // 
            this.QuantityOfTransfer.DataPropertyName = "QuantityOfTransfer";
            this.QuantityOfTransfer.HeaderText = "轉倉數量";
            this.QuantityOfTransfer.Name = "QuantityOfTransfer";
            this.QuantityOfTransfer.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "有效期限";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // FrmTransferOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTransferOrderDetails";
            this.Text = "FrmTransferOrderDetails";
            this.Load += new System.EventHandler(this.FrmTransferOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOfTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
    }
}