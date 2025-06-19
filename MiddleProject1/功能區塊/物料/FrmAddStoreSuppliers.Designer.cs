namespace MiddleProject1.功能區塊.物料
{
    partial class FrmAddStoreSuppliers
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
            System.Windows.Forms.Label supplierNameLabel;
            System.Windows.Forms.Label supplierGUILabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label contactNumberLabel;
            System.Windows.Forms.Label addressLabel;
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierGUI = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            supplierNameLabel = new System.Windows.Forms.Label();
            supplierGUILabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            contactNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            supplierNameLabel.Location = new System.Drawing.Point(35, 56);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(174, 27);
            supplierNameLabel.TabIndex = 3;
            supplierNameLabel.Text = "供應商名稱：";
            // 
            // supplierGUILabel
            // 
            supplierGUILabel.AutoSize = true;
            supplierGUILabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            supplierGUILabel.Location = new System.Drawing.Point(116, 110);
            supplierGUILabel.Name = "supplierGUILabel";
            supplierGUILabel.Size = new System.Drawing.Size(93, 27);
            supplierGUILabel.TabIndex = 5;
            supplierGUILabel.Text = "統編：";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            contactLabel.Location = new System.Drawing.Point(88, 161);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(120, 27);
            contactLabel.TabIndex = 7;
            contactLabel.Text = "聯絡人：";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            contactNumberLabel.Location = new System.Drawing.Point(62, 213);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new System.Drawing.Size(147, 27);
            contactNumberLabel.TabIndex = 9;
            contactNumberLabel.Text = "連絡電話：";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            addressLabel.Location = new System.Drawing.Point(60, 270);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(93, 27);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "地址：";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupplierName.Location = new System.Drawing.Point(214, 53);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(351, 40);
            this.txtSupplierName.TabIndex = 4;
            // 
            // txtSupplierGUI
            // 
            this.txtSupplierGUI.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupplierGUI.Location = new System.Drawing.Point(214, 107);
            this.txtSupplierGUI.Name = "txtSupplierGUI";
            this.txtSupplierGUI.Size = new System.Drawing.Size(141, 40);
            this.txtSupplierGUI.TabIndex = 6;
            // 
            // txtContactName
            // 
            this.txtContactName.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtContactName.Location = new System.Drawing.Point(214, 158);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(142, 40);
            this.txtContactName.TabIndex = 8;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtContactNumber.Location = new System.Drawing.Point(214, 210);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(210, 40);
            this.txtContactNumber.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(159, 267);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(475, 40);
            this.txtAddress.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(478, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(559, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAddStoreSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(supplierNameLabel);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(supplierGUILabel);
            this.Controls.Add(this.txtSupplierGUI);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(contactNumberLabel);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Name = "FrmAddStoreSuppliers";
            this.Text = "FrmAddSuppliers";
            this.Load += new System.EventHandler(this.FrmStoreAddSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierGUI;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}