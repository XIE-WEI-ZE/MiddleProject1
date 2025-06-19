namespace MiddleProject1.功能區塊.物料
{
    partial class FrmAddStoreProducts
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStoreProductName = new System.Windows.Forms.TextBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            supplierNameLabel = new System.Windows.Forms.Label();
            supplierGUILabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            supplierNameLabel.Location = new System.Drawing.Point(61, 56);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(147, 27);
            supplierNameLabel.TabIndex = 15;
            supplierNameLabel.Text = "物品名稱：";
            // 
            // supplierGUILabel
            // 
            supplierGUILabel.AutoSize = true;
            supplierGUILabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            supplierGUILabel.Location = new System.Drawing.Point(116, 110);
            supplierGUILabel.Name = "supplierGUILabel";
            supplierGUILabel.Size = new System.Drawing.Size(93, 27);
            supplierGUILabel.TabIndex = 17;
            supplierGUILabel.Text = "單位：";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            contactLabel.Location = new System.Drawing.Point(34, 161);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(174, 27);
            contactLabel.TabIndex = 19;
            contactLabel.Text = "供應商編號：";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(474, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(393, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStoreProductName
            // 
            this.txtStoreProductName.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStoreProductName.Location = new System.Drawing.Point(214, 53);
            this.txtStoreProductName.Name = "txtStoreProductName";
            this.txtStoreProductName.Size = new System.Drawing.Size(281, 40);
            this.txtStoreProductName.TabIndex = 16;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(214, 107);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(141, 40);
            this.txtQuantityPerUnit.TabIndex = 18;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupplierID.Location = new System.Drawing.Point(214, 158);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(142, 40);
            this.txtSupplierID.TabIndex = 20;
            // 
            // FrmAddStoreProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 296);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(supplierNameLabel);
            this.Controls.Add(this.txtStoreProductName);
            this.Controls.Add(supplierGUILabel);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.txtSupplierID);
            this.Name = "FrmAddStoreProducts";
            this.Text = "FrmAddStoreProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStoreProductName;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.TextBox txtSupplierID;
    }
}