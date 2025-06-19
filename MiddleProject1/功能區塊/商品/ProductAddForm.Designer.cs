namespace MiddleProject1.功能區塊.商品
{
    partial class ProductAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new Sunny.UI.UIComboBox();
            this.txtQuantity = new Sunny.UI.UITextBox();
            this.txtName = new Sunny.UI.UITextBox();
            this.txtOriginalPrice = new Sunny.UI.UITextBox();
            this.txtStock = new Sunny.UI.UITextBox();
            this.txtSalePrice = new Sunny.UI.UITextBox();
            this.chkDiscontinued = new Sunny.UI.UICheckBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpload = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.txtDiscountRate = new Sunny.UI.UITextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtSummary = new Sunny.UI.UITextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.txtContent = new Sunny.UI.UITextBox();
            this.lblContent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "原價";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(867, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "售價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "庫存";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "類別選單";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = null;
            this.cmbCategory.FillColor = System.Drawing.Color.White;
            this.cmbCategory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbCategory.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbCategory.Location = new System.Drawing.Point(991, 135);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbCategory.Size = new System.Drawing.Size(272, 37);
            this.cmbCategory.SymbolSize = 24;
            this.cmbCategory.TabIndex = 11;
            this.cmbCategory.Text = "uiComboBox1";
            this.cmbCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbCategory.Watermark = "";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(155, 135);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(5);
            this.txtQuantity.ShowText = false;
            this.txtQuantity.Size = new System.Drawing.Size(272, 37);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtQuantity.Watermark = "";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(155, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(272, 37);
            this.txtName.TabIndex = 13;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOriginalPrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalPrice.Location = new System.Drawing.Point(572, 62);
            this.txtOriginalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOriginalPrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Padding = new System.Windows.Forms.Padding(5);
            this.txtOriginalPrice.ShowText = false;
            this.txtOriginalPrice.Size = new System.Drawing.Size(272, 37);
            this.txtOriginalPrice.TabIndex = 14;
            this.txtOriginalPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOriginalPrice.Watermark = "";
            // 
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(572, 135);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(5);
            this.txtStock.ShowText = false;
            this.txtStock.Size = new System.Drawing.Size(272, 37);
            this.txtStock.TabIndex = 15;
            this.txtStock.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtStock.Watermark = "";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalePrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(991, 62);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalePrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Padding = new System.Windows.Forms.Padding(5);
            this.txtSalePrice.ShowText = false;
            this.txtSalePrice.Size = new System.Drawing.Size(272, 37);
            this.txtSalePrice.TabIndex = 16;
            this.txtSalePrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSalePrice.Watermark = "";
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDiscontinued.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiscontinued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkDiscontinued.Location = new System.Drawing.Point(36, 217);
            this.chkDiscontinued.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(150, 29);
            this.chkDiscontinued.TabIndex = 18;
            this.chkDiscontinued.Text = "是否下架";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(1016, 217);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(247, 119);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 19;
            this.picPreview.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(873, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "預覽圖片";
            // 
            // btnUpload
            // 
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpload.Location = new System.Drawing.Point(805, 663);
            this.btnUpload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(126, 45);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "上傳圖片";
            this.btnUpload.TipsFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(969, 663);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 45);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "儲存";
            this.btnSave.TipsFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(1137, 663);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 45);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountRate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountRate.Location = new System.Drawing.Point(572, 217);
            this.txtDiscountRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscountRate.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Padding = new System.Windows.Forms.Padding(5);
            this.txtDiscountRate.ShowText = false;
            this.txtDiscountRate.Size = new System.Drawing.Size(272, 37);
            this.txtDiscountRate.TabIndex = 25;
            this.txtDiscountRate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDiscountRate.Watermark = "";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(448, 217);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(64, 28);
            this.lblDiscount.TabIndex = 24;
            this.lblDiscount.Text = "折扣";
            // 
            // txtSummary
            // 
            this.txtSummary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSummary.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary.Location = new System.Drawing.Point(155, 299);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSummary.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Padding = new System.Windows.Forms.Padding(5);
            this.txtSummary.ShowScrollBar = true;
            this.txtSummary.ShowText = false;
            this.txtSummary.Size = new System.Drawing.Size(272, 100);
            this.txtSummary.TabIndex = 27;
            this.txtSummary.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSummary.Watermark = "";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(31, 299);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(116, 28);
            this.lblSummary.TabIndex = 26;
            this.lblSummary.Text = "商品摘要";
            // 
            // txtContent
            // 
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(572, 299);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContent.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new System.Windows.Forms.Padding(5);
            this.txtContent.ShowScrollBar = true;
            this.txtContent.ShowText = false;
            this.txtContent.Size = new System.Drawing.Size(272, 100);
            this.txtContent.TabIndex = 29;
            this.txtContent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtContent.Watermark = "";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(448, 299);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(116, 28);
            this.lblContent.TabIndex = 28;
            this.lblContent.Text = "商品描述";
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 734);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.txtDiscountRate);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtOriginalPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductAddForm";
            this.Text = "ProductAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UIComboBox cmbCategory;
        private Sunny.UI.UITextBox txtQuantity;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UITextBox txtOriginalPrice;
        private Sunny.UI.UITextBox txtStock;
        private Sunny.UI.UITextBox txtSalePrice;
        private Sunny.UI.UICheckBox chkDiscontinued;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UIButton btnUpload;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UITextBox txtDiscountRate;
        private System.Windows.Forms.Label lblDiscount;
        private Sunny.UI.UITextBox txtSummary;
        private System.Windows.Forms.Label lblSummary;
        private Sunny.UI.UITextBox txtContent;
        private System.Windows.Forms.Label lblContent;
    }
}