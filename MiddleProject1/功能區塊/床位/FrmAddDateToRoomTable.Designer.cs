namespace MiddleProject1.功能區塊.床位
{
    partial class FrmAddDateToRoomTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label memberIDLabel;
            System.Windows.Forms.Label roomNumberLabel;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label roomTypeLabel;
            System.Windows.Forms.Label bedCountLabel;
            System.Windows.Forms.Label roomPriceLabel;
            this.nhdsRoom = new MiddleProject1.NhdsRoom();
            this.roomTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.bedCountTextBox = new System.Windows.Forms.TextBox();
            this.roomPriceTextBox = new System.Windows.Forms.TextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            memberIDLabel = new System.Windows.Forms.Label();
            roomNumberLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            roomTypeLabel = new System.Windows.Forms.Label();
            bedCountLabel = new System.Windows.Forms.Label();
            roomPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhdsRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(35, 33);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(71, 15);
            memberIDLabel.TabIndex = 1;
            memberIDLabel.Text = "會員編號:";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Location = new System.Drawing.Point(35, 64);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new System.Drawing.Size(71, 15);
            roomNumberLabel.TabIndex = 3;
            roomNumberLabel.Text = "房間編號:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(35, 95);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(71, 15);
            roomNameLabel.TabIndex = 5;
            roomNameLabel.Text = "房間名稱:";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Location = new System.Drawing.Point(35, 128);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new System.Drawing.Size(71, 15);
            roomTypeLabel.TabIndex = 7;
            roomTypeLabel.Text = "房間類型:";
            // 
            // bedCountLabel
            // 
            bedCountLabel.AutoSize = true;
            bedCountLabel.Location = new System.Drawing.Point(35, 156);
            bedCountLabel.Name = "bedCountLabel";
            bedCountLabel.Size = new System.Drawing.Size(71, 15);
            bedCountLabel.TabIndex = 9;
            bedCountLabel.Text = "房間床數:";
            // 
            // roomPriceLabel
            // 
            roomPriceLabel.AutoSize = true;
            roomPriceLabel.Location = new System.Drawing.Point(35, 187);
            roomPriceLabel.Name = "roomPriceLabel";
            roomPriceLabel.Size = new System.Drawing.Size(71, 15);
            roomPriceLabel.TabIndex = 13;
            roomPriceLabel.Text = "房間價格:";
            // 
            // nhdsRoom
            // 
            this.nhdsRoom.DataSetName = "NursingHomeDataSet2";
            this.nhdsRoom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableBindingSource
            // 
            this.roomTableBindingSource.DataMember = "RoomTable";
            this.roomTableBindingSource.DataSource = this.nhdsRoom;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "MemberID", true));
            this.memberIDTextBox.Location = new System.Drawing.Point(136, 30);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(104, 25);
            this.memberIDTextBox.TabIndex = 2;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "RoomNumber", true));
            this.roomNumberTextBox.Location = new System.Drawing.Point(136, 61);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(104, 25);
            this.roomNumberTextBox.TabIndex = 4;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "RoomName", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(136, 92);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(104, 25);
            this.roomNameTextBox.TabIndex = 6;
            // 
            // roomTypeCheckBox
            // 
            this.roomTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomTableBindingSource, "RoomType", true));
            this.roomTypeCheckBox.Location = new System.Drawing.Point(136, 123);
            this.roomTypeCheckBox.Name = "roomTypeCheckBox";
            this.roomTypeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.roomTypeCheckBox.TabIndex = 8;
            this.roomTypeCheckBox.Text = "多人套房";
            this.roomTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // bedCountTextBox
            // 
            this.bedCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "BedCount", true));
            this.bedCountTextBox.Location = new System.Drawing.Point(136, 153);
            this.bedCountTextBox.Name = "bedCountTextBox";
            this.bedCountTextBox.Size = new System.Drawing.Size(104, 25);
            this.bedCountTextBox.TabIndex = 10;
            // 
            // roomPriceTextBox
            // 
            this.roomPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "RoomPrice", true));
            this.roomPriceTextBox.Location = new System.Drawing.Point(136, 184);
            this.roomPriceTextBox.Name = "roomPriceTextBox";
            this.roomPriceTextBox.Size = new System.Drawing.Size(104, 25);
            this.roomPriceTextBox.TabIndex = 14;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Location = new System.Drawing.Point(58, 230);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 15;
            this.uiButton1.Text = "存檔";
            this.uiButton1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Location = new System.Drawing.Point(218, 230);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 16;
            this.uiButton2.Text = "取消";
            this.uiButton2.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddDateToRoomTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 295);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(roomNumberLabel);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(roomNameLabel);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(roomTypeLabel);
            this.Controls.Add(this.roomTypeCheckBox);
            this.Controls.Add(bedCountLabel);
            this.Controls.Add(this.bedCountTextBox);
            this.Controls.Add(roomPriceLabel);
            this.Controls.Add(this.roomPriceTextBox);
            this.Name = "FrmAddDateToRoomTable";
            this.Text = "FrmAddDateToRoomTable";
            this.Load += new System.EventHandler(this.FrmAddDateToRoomTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhdsRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NhdsRoom nhdsRoom;
        private System.Windows.Forms.BindingSource roomTableBindingSource;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.CheckBox roomTypeCheckBox;
        private System.Windows.Forms.TextBox bedCountTextBox;
        private System.Windows.Forms.TextBox roomPriceTextBox;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
    }
}