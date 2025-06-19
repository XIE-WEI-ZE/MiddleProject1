namespace MiddleProject1.功能區塊.健康
{
    partial class FrmDailyCare
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
            this.dailyHealthRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HealthRecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體溫 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.血壓 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.脈搏 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckPeriod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IORecord = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.紀錄日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBoxName = new Sunny.UI.UITextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiDatePickerDate = new Sunny.UI.UIDatePicker();
            this.uiButtonSearch = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dailyHealthRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiButton4 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dailyHealthRecordBindingSource)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyHealthRecordBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyHealthRecordBindingSource
            // 
            this.dailyHealthRecordBindingSource.DataMember = "DailyHealthRecord";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.dataGridView1);
            this.uiPanel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 228);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1119, 541);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HealthRecordID,
            this.名字,
            this.體溫,
            this.血壓,
            this.脈搏,
            this.備註,
            this.CheckPeriod,
            this.IORecord,
            this.紀錄日期});
            this.dataGridView1.DataSource = this.dailyHealthRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 541);
            this.dataGridView1.TabIndex = 0;
            // 
            // HealthRecordID
            // 
            this.HealthRecordID.DataPropertyName = "HealthRecordID";
            this.HealthRecordID.HeaderText = "HealthRecordID";
            this.HealthRecordID.Name = "HealthRecordID";
            this.HealthRecordID.ReadOnly = true;
            this.HealthRecordID.Visible = false;
            // 
            // 名字
            // 
            this.名字.DataPropertyName = "Name";
            this.名字.HeaderText = "名字";
            this.名字.Name = "名字";
            // 
            // 體溫
            // 
            this.體溫.DataPropertyName = "BodyTemperature";
            this.體溫.HeaderText = "體溫";
            this.體溫.Name = "體溫";
            // 
            // 血壓
            // 
            this.血壓.DataPropertyName = "BloodPressure";
            this.血壓.HeaderText = "血壓";
            this.血壓.Name = "血壓";
            // 
            // 脈搏
            // 
            this.脈搏.DataPropertyName = "Pulse";
            this.脈搏.HeaderText = "Pulse";
            this.脈搏.Name = "脈搏";
            // 
            // 備註
            // 
            this.備註.DataPropertyName = "Remark";
            this.備註.HeaderText = "備註";
            this.備註.Name = "備註";
            // 
            // CheckPeriod
            // 
            this.CheckPeriod.DataPropertyName = "CheckPeriod";
            this.CheckPeriod.HeaderText = "時段";
            this.CheckPeriod.Items.AddRange(new object[] {
            "早上",
            "傍晚"});
            this.CheckPeriod.Name = "CheckPeriod";
            this.CheckPeriod.ReadOnly = true;
            this.CheckPeriod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IORecord
            // 
            this.IORecord.DataPropertyName = "IORecord";
            this.IORecord.HeaderText = "I/O 狀態\n";
            this.IORecord.Items.AddRange(new object[] {
            "正常",
            "異常"});
            this.IORecord.Name = "IORecord";
            this.IORecord.ReadOnly = true;
            // 
            // 紀錄日期
            // 
            this.紀錄日期.DataPropertyName = "RecordDate";
            this.紀錄日期.HeaderText = "紀錄日期";
            this.紀錄日期.Name = "紀錄日期";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(43, 41);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "住戶查詢:";
            // 
            // uiTextBoxName
            // 
            this.uiTextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiTextBoxName.Location = new System.Drawing.Point(129, 35);
            this.uiTextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxName.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxName.Name = "uiTextBoxName";
            this.uiTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxName.ShowText = false;
            this.uiTextBoxName.Size = new System.Drawing.Size(202, 29);
            this.uiTextBoxName.TabIndex = 3;
            this.uiTextBoxName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxName.Watermark = "";
            this.uiTextBoxName.TextChanged += new System.EventHandler(this.uiTextBoxName_TextChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(43, 86);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 21);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "日期查詢:";
            // 
            // uiDatePickerDate
            // 
            this.uiDatePickerDate.FillColor = System.Drawing.Color.White;
            this.uiDatePickerDate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDatePickerDate.Location = new System.Drawing.Point(129, 79);
            this.uiDatePickerDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePickerDate.MaxLength = 10;
            this.uiDatePickerDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePickerDate.Name = "uiDatePickerDate";
            this.uiDatePickerDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePickerDate.Size = new System.Drawing.Size(202, 29);
            this.uiDatePickerDate.SymbolDropDown = 61555;
            this.uiDatePickerDate.SymbolNormal = 61555;
            this.uiDatePickerDate.SymbolSize = 24;
            this.uiDatePickerDate.TabIndex = 5;
            this.uiDatePickerDate.Text = "2025-05-31";
            this.uiDatePickerDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePickerDate.Value = new System.DateTime(2025, 5, 31, 12, 57, 6, 977);
            this.uiDatePickerDate.Watermark = "";
            // 
            // uiButtonSearch
            // 
            this.uiButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonSearch.Location = new System.Drawing.Point(347, 28);
            this.uiButtonSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSearch.Name = "uiButtonSearch";
            this.uiButtonSearch.Radius = 35;
            this.uiButtonSearch.Size = new System.Drawing.Size(36, 35);
            this.uiButtonSearch.TabIndex = 6;
            this.uiButtonSearch.Text = "搜!";
            this.uiButtonSearch.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonSearch.Click += new System.EventHandler(this.uiButtonSearch_Click_1);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Location = new System.Drawing.Point(129, 185);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(85, 35);
            this.uiButton2.TabIndex = 8;
            this.uiButton2.Text = "刪除";
            this.uiButton2.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Location = new System.Drawing.Point(12, 185);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(85, 35);
            this.uiButton1.TabIndex = 10;
            this.uiButton1.Text = "儲存";
            this.uiButton1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click_1);
            // 
            // dailyHealthRecordBindingSource1
            // 
            this.dailyHealthRecordBindingSource1.DataMember = "DailyHealthRecord";
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton3.Location = new System.Drawing.Point(246, 185);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(85, 35);
            this.uiButton3.TabIndex = 11;
            this.uiButton3.Text = "顯示全部";
            this.uiButton3.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDatePicker1.Location = new System.Drawing.Point(422, 79);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(202, 29);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.SymbolSize = 24;
            this.uiDatePicker1.TabIndex = 12;
            this.uiDatePicker1.Text = "2025-05-31";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2025, 5, 31, 12, 57, 6, 977);
            this.uiDatePicker1.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(370, 79);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(29, 23);
            this.uiLabel3.TabIndex = 13;
            this.uiLabel3.Text = "~";
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton4.Location = new System.Drawing.Point(375, 185);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(85, 35);
            this.uiButton4.TabIndex = 14;
            this.uiButton4.Text = "當天資料";
            this.uiButton4.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // FrmDailyCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 769);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiDatePicker1);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButtonSearch);
            this.Controls.Add(this.uiDatePickerDate);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiTextBoxName);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiPanel1);
            //this.Name = "FrmDailyCare";
            this.Text = "FormDailyCare";
            this.Load += new System.EventHandler(this.FrmDailyCare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyHealthRecordBindingSource)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyHealthRecordBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private NursingHomeDataSet1 nursingHomeDataSet1;
        private System.Windows.Forms.BindingSource dailyHealthRecordBindingSource;
        //private NursingHomeDataSet1TableAdapters.DailyHealthRecordTableAdapter dailyHealthRecordTableAdapter;
        //private NursingHomeDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBoxName;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatePicker uiDatePickerDate;
        private Sunny.UI.UIButton uiButtonSearch;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private NursingHomeDataSet2 nursingHomeDataSet2;
        private System.Windows.Forms.BindingSource dailyHealthRecordBindingSource1;
        //private NursingHomeDataSet2TableAdapters.DailyHealthRecordTableAdapter dailyHealthRecordTableAdapter1;
        //private NursingHomeDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private Sunny.UI.UIButton uiButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodyTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名字;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體溫;
        private System.Windows.Forms.DataGridViewTextBoxColumn 血壓;
        private System.Windows.Forms.DataGridViewTextBoxColumn 脈搏;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註;
        private System.Windows.Forms.DataGridViewComboBoxColumn CheckPeriod;
        private System.Windows.Forms.DataGridViewComboBoxColumn IORecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn 紀錄日期;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton uiButton4;
    }
}