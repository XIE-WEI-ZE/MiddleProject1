namespace MiddleProject1.功能區塊.員工
{
    partial class FrmUserAttendanceCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiButtonQuery = new Sunny.UI.UIButton();
            this.uiButtonExceptionForm = new Sunny.UI.UIButton();
            this.uiDatePickerStart = new Sunny.UI.UIDatePicker();
            this.uiComboBoxType = new Sunny.UI.UIComboBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiDatePickerEnd = new Sunny.UI.UIDatePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButtonQuery
            // 
            this.uiButtonQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonQuery.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonQuery.Location = new System.Drawing.Point(411, 127);
            this.uiButtonQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonQuery.Name = "uiButtonQuery";
            this.uiButtonQuery.Size = new System.Drawing.Size(150, 37);
            this.uiButtonQuery.TabIndex = 0;
            this.uiButtonQuery.Text = "查詢";
            this.uiButtonQuery.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonQuery.Click += new System.EventHandler(this.uiButtonQuery_Click);
            // 
            // uiButtonExceptionForm
            // 
            this.uiButtonExceptionForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonExceptionForm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonExceptionForm.Location = new System.Drawing.Point(30, 93);
            this.uiButtonExceptionForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonExceptionForm.Name = "uiButtonExceptionForm";
            this.uiButtonExceptionForm.Size = new System.Drawing.Size(247, 71);
            this.uiButtonExceptionForm.TabIndex = 1;
            this.uiButtonExceptionForm.Text = "填寫異常申請單";
            this.uiButtonExceptionForm.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonExceptionForm.Click += new System.EventHandler(this.uiButtonExceptionForm_Click);
            // 
            // uiDatePickerStart
            // 
            this.uiDatePickerStart.FillColor = System.Drawing.Color.White;
            this.uiDatePickerStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDatePickerStart.Location = new System.Drawing.Point(411, 56);
            this.uiDatePickerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePickerStart.MaxLength = 10;
            this.uiDatePickerStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePickerStart.Name = "uiDatePickerStart";
            this.uiDatePickerStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePickerStart.Size = new System.Drawing.Size(150, 29);
            this.uiDatePickerStart.SymbolDropDown = 61555;
            this.uiDatePickerStart.SymbolNormal = 61555;
            this.uiDatePickerStart.SymbolSize = 24;
            this.uiDatePickerStart.TabIndex = 80;
            this.uiDatePickerStart.Text = "2025-06-03";
            this.uiDatePickerStart.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDatePickerStart.Value = new System.DateTime(2025, 6, 3, 20, 22, 3, 164);
            this.uiDatePickerStart.Watermark = "";
            // 
            // uiComboBoxType
            // 
            this.uiComboBoxType.DataSource = null;
            this.uiComboBoxType.FillColor = System.Drawing.Color.White;
            this.uiComboBoxType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiComboBoxType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBoxType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBoxType.Location = new System.Drawing.Point(411, 22);
            this.uiComboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBoxType.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBoxType.Name = "uiComboBoxType";
            this.uiComboBoxType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBoxType.Size = new System.Drawing.Size(150, 29);
            this.uiComboBoxType.SymbolSize = 24;
            this.uiComboBoxType.TabIndex = 79;
            this.uiComboBoxType.Text = "請選擇";
            this.uiComboBoxType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiComboBoxType.Watermark = "";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiTextBox1.Location = new System.Drawing.Point(127, 22);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 78;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox1.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(310, 56);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(106, 23);
            this.uiLabel7.TabIndex = 77;
            this.uiLabel7.Text = "起始日期：";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(310, 22);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(106, 23);
            this.uiLabel5.TabIndex = 76;
            this.uiLabel5.Text = "出勤狀況：";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(26, 22);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(106, 23);
            this.uiLabel1.TabIndex = 75;
            this.uiLabel1.Text = "員工編號：";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiTextBox2.Location = new System.Drawing.Point(127, 56);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox2.TabIndex = 82;
            this.uiTextBox2.Text = "請填寫";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox2.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(26, 56);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(106, 23);
            this.uiLabel4.TabIndex = 81;
            this.uiLabel4.Text = "員工姓名：";
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(30, 170);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(576, 374);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 83;
            // 
            // uiDatePickerEnd
            // 
            this.uiDatePickerEnd.FillColor = System.Drawing.Color.White;
            this.uiDatePickerEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDatePickerEnd.Location = new System.Drawing.Point(411, 90);
            this.uiDatePickerEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePickerEnd.MaxLength = 10;
            this.uiDatePickerEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePickerEnd.Name = "uiDatePickerEnd";
            this.uiDatePickerEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePickerEnd.Size = new System.Drawing.Size(150, 29);
            this.uiDatePickerEnd.SymbolDropDown = 61555;
            this.uiDatePickerEnd.SymbolNormal = 61555;
            this.uiDatePickerEnd.SymbolSize = 24;
            this.uiDatePickerEnd.TabIndex = 85;
            this.uiDatePickerEnd.Text = "2025-06-03";
            this.uiDatePickerEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDatePickerEnd.Value = new System.DateTime(2025, 6, 3, 20, 22, 3, 164);
            this.uiDatePickerEnd.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(310, 90);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(106, 23);
            this.uiLabel2.TabIndex = 84;
            this.uiLabel2.Text = "結束日期：";
            // 
            // FrmUserAttendanceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 558);
            this.Controls.Add(this.uiDatePickerEnd);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiDatePickerStart);
            this.Controls.Add(this.uiComboBoxType);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiButtonExceptionForm);
            this.Controls.Add(this.uiButtonQuery);
            this.Name = "FrmUserAttendanceCheck";
            this.Text = "FrmUserAttendanceCheck";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButtonQuery;
        private Sunny.UI.UIButton uiButtonExceptionForm;
        private Sunny.UI.UIDatePicker uiDatePickerStart;
        private Sunny.UI.UIComboBox uiComboBoxType;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIDatePicker uiDatePickerEnd;
        private Sunny.UI.UILabel uiLabel2;
    }
}