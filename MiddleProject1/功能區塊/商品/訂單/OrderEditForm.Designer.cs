namespace MiddleProject1.功能區塊.商品.訂單
{
    partial class OrderEditFrom
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
            this.btnCancel = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.dtpOrderTime = new Sunny.UI.UIDatetimePicker();
            this.txtBuyerName = new Sunny.UI.UITextBox();
            this.txtReceiverName = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceiverPhone = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new Sunny.UI.UIComboBox();
            this.cmbDeliveryMethod = new Sunny.UI.UIComboBox();
            this.txtDeliveryAddress = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevPage = new Sunny.UI.UIButton();
            this.btnNextPage = new Sunny.UI.UIButton();
            this.lblDetailPageInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(1178, 826);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 45);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(1028, 826);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 45);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "儲存";
            this.btnSave.TipsFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.FillColor = System.Drawing.Color.White;
            this.dtpOrderTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpOrderTime.Location = new System.Drawing.Point(171, 33);
            this.dtpOrderTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpOrderTime.MaxLength = 19;
            this.dtpOrderTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpOrderTime.Size = new System.Drawing.Size(272, 37);
            this.dtpOrderTime.SymbolDropDown = 61555;
            this.dtpOrderTime.SymbolNormal = 61555;
            this.dtpOrderTime.SymbolSize = 24;
            this.dtpOrderTime.TabIndex = 28;
            this.dtpOrderTime.Text = "2025-05-31 23:54:55";
            this.dtpOrderTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpOrderTime.Value = new System.DateTime(2025, 5, 31, 23, 54, 55, 712);
            this.dtpOrderTime.Watermark = "";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuyerName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyerName.Location = new System.Drawing.Point(617, 33);
            this.txtBuyerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuyerName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Padding = new System.Windows.Forms.Padding(5);
            this.txtBuyerName.ShowText = false;
            this.txtBuyerName.Size = new System.Drawing.Size(272, 37);
            this.txtBuyerName.TabIndex = 30;
            this.txtBuyerName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBuyerName.Watermark = "";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceiverName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverName.Location = new System.Drawing.Point(171, 102);
            this.txtReceiverName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiverName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Padding = new System.Windows.Forms.Padding(5);
            this.txtReceiverName.ReadOnly = true;
            this.txtReceiverName.ShowText = false;
            this.txtReceiverName.Size = new System.Drawing.Size(272, 37);
            this.txtReceiverName.TabIndex = 32;
            this.txtReceiverName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtReceiverName.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "收件人姓名";
            // 
            // txtReceiverPhone
            // 
            this.txtReceiverPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceiverPhone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverPhone.Location = new System.Drawing.Point(617, 102);
            this.txtReceiverPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiverPhone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtReceiverPhone.Name = "txtReceiverPhone";
            this.txtReceiverPhone.Padding = new System.Windows.Forms.Padding(5);
            this.txtReceiverPhone.ReadOnly = true;
            this.txtReceiverPhone.ShowText = false;
            this.txtReceiverPhone.Size = new System.Drawing.Size(272, 37);
            this.txtReceiverPhone.TabIndex = 34;
            this.txtReceiverPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtReceiverPhone.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "收件人電話";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DataSource = null;
            this.cmbPaymentMethod.FillColor = System.Drawing.Color.White;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.Location = new System.Drawing.Point(171, 178);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPaymentMethod.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbPaymentMethod.Size = new System.Drawing.Size(272, 37);
            this.cmbPaymentMethod.SymbolSize = 24;
            this.cmbPaymentMethod.TabIndex = 28;
            this.cmbPaymentMethod.Text = "付款方式";
            this.cmbPaymentMethod.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbPaymentMethod.Watermark = "";
            // 
            // cmbDeliveryMethod
            // 
            this.cmbDeliveryMethod.DataSource = null;
            this.cmbDeliveryMethod.FillColor = System.Drawing.Color.White;
            this.cmbDeliveryMethod.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeliveryMethod.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbDeliveryMethod.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbDeliveryMethod.Location = new System.Drawing.Point(617, 178);
            this.cmbDeliveryMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDeliveryMethod.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbDeliveryMethod.Name = "cmbDeliveryMethod";
            this.cmbDeliveryMethod.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbDeliveryMethod.Size = new System.Drawing.Size(272, 37);
            this.cmbDeliveryMethod.SymbolSize = 24;
            this.cmbDeliveryMethod.TabIndex = 29;
            this.cmbDeliveryMethod.Text = "配送方式";
            this.cmbDeliveryMethod.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbDeliveryMethod.Watermark = "";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(171, 339);
            this.txtDeliveryAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeliveryAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtDeliveryAddress.ReadOnly = true;
            this.txtDeliveryAddress.ShowText = false;
            this.txtDeliveryAddress.Size = new System.Drawing.Size(718, 37);
            this.txtDeliveryAddress.TabIndex = 36;
            this.txtDeliveryAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDeliveryAddress.Watermark = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "配送地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "訂單明細";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(25, 466);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersWidth = 62;
            this.dgvOrderDetails.RowTemplate.Height = 31;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(1278, 272);
            this.dgvOrderDetails.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevPage);
            this.panel1.Controls.Add(this.btnNextPage);
            this.panel1.Controls.Add(this.lblDetailPageInfo);
            this.panel1.Location = new System.Drawing.Point(25, 745);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 56);
            this.panel1.TabIndex = 40;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevPage.Location = new System.Drawing.Point(164, 6);
            this.btnPrevPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(126, 45);
            this.btnPrevPage.TabIndex = 3;
            this.btnPrevPage.Text = "上一頁";
            this.btnPrevPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevDetailPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextPage.Location = new System.Drawing.Point(989, 6);
            this.btnNextPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(126, 45);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "下一頁";
            this.btnNextPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextPage.Click += new System.EventHandler(this.btnNextDetailPage_Click);
            // 
            // lblDetailPageInfo
            // 
            this.lblDetailPageInfo.AutoSize = true;
            this.lblDetailPageInfo.Font = new System.Drawing.Font("Consolas", 12F);
            this.lblDetailPageInfo.Location = new System.Drawing.Point(510, 16);
            this.lblDetailPageInfo.Name = "lblDetailPageInfo";
            this.lblDetailPageInfo.Size = new System.Drawing.Size(233, 28);
            this.lblDetailPageInfo.TabIndex = 4;
            this.lblDetailPageInfo.Text = "第 X 頁 / 共 Y 頁";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "下訂時間";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "ID名稱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 43;
            this.label7.Text = "付款方式";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(467, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "配送方式";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(21, 253);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 28);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "總金額";
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(171, 253);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(5);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ShowText = false;
            this.txtTotal.Size = new System.Drawing.Size(272, 37);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTotal.Watermark = "";
            // 
            // OrderEditFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 883);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeliveryAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDeliveryMethod);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.txtReceiverPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuyerName);
            this.Controls.Add(this.dtpOrderTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "OrderEditFrom";
            this.Text = "OrderEditForm";
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIDatetimePicker dtpOrderTime;
        private Sunny.UI.UITextBox txtBuyerName;
        private Sunny.UI.UITextBox txtReceiverName;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txtReceiverPhone;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIComboBox cmbPaymentMethod;
        private Sunny.UI.UIComboBox cmbDeliveryMethod;
        private Sunny.UI.UITextBox txtDeliveryAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton btnPrevPage;
        private Sunny.UI.UIButton btnNextPage;
        private System.Windows.Forms.Label lblDetailPageInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private Sunny.UI.UITextBox txtTotal;
    }
}