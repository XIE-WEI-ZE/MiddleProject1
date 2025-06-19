namespace MiddleProject1.功能區塊.員工
{
    partial class UC_EmployeeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiButtonAddNewData = new Sunny.UI.UIButton();
            this.uiButtonDeleteData = new Sunny.UI.UIButton();
            this.uiButtonFirstLine = new Sunny.UI.UIButton();
            this.uiButtonPrevious = new Sunny.UI.UIButton();
            this.uiButtonNext = new Sunny.UI.UIButton();
            this.uiButtonLast = new Sunny.UI.UIButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButtonFullData = new Sunny.UI.UIButton();
            this.nhEmployeeDataSet1 = new MiddleProject1.功能區塊.員工.NHEmployeeDataSet();
            this.employeeTableAdapter1 = new MiddleProject1.功能區塊.員工.NHEmployeeDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeDepartmentTableAdapter1 = new MiddleProject1.功能區塊.員工.NHEmployeeDataSetTableAdapters.EmployeeDepartmentTableAdapter();
            this.employeeJobTitleTableAdapter1 = new MiddleProject1.功能區塊.員工.NHEmployeeDataSetTableAdapters.EmployeeJobTitleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhEmployeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButtonAddNewData
            // 
            this.uiButtonAddNewData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonAddNewData.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonAddNewData.Location = new System.Drawing.Point(533, 71);
            this.uiButtonAddNewData.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonAddNewData.Name = "uiButtonAddNewData";
            this.uiButtonAddNewData.Size = new System.Drawing.Size(100, 35);
            this.uiButtonAddNewData.TabIndex = 1;
            this.uiButtonAddNewData.Text = "新增";
            this.uiButtonAddNewData.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonAddNewData.Click += new System.EventHandler(this.uiButtonAddNewData_Click);
            // 
            // uiButtonDeleteData
            // 
            this.uiButtonDeleteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonDeleteData.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonDeleteData.Location = new System.Drawing.Point(656, 70);
            this.uiButtonDeleteData.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonDeleteData.Name = "uiButtonDeleteData";
            this.uiButtonDeleteData.Size = new System.Drawing.Size(100, 35);
            this.uiButtonDeleteData.TabIndex = 2;
            this.uiButtonDeleteData.Text = "刪除";
            this.uiButtonDeleteData.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonDeleteData.Click += new System.EventHandler(this.uiButtonDeleteData_Click);
            // 
            // uiButtonFirstLine
            // 
            this.uiButtonFirstLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonFirstLine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonFirstLine.Location = new System.Drawing.Point(78, 521);
            this.uiButtonFirstLine.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonFirstLine.Name = "uiButtonFirstLine";
            this.uiButtonFirstLine.Size = new System.Drawing.Size(100, 35);
            this.uiButtonFirstLine.TabIndex = 3;
            this.uiButtonFirstLine.Text = "<<";
            this.uiButtonFirstLine.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonFirstLine.Click += new System.EventHandler(this.uiButtonFirstLine_Click);
            // 
            // uiButtonPrevious
            // 
            this.uiButtonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonPrevious.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonPrevious.Location = new System.Drawing.Point(201, 521);
            this.uiButtonPrevious.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonPrevious.Name = "uiButtonPrevious";
            this.uiButtonPrevious.Size = new System.Drawing.Size(100, 35);
            this.uiButtonPrevious.TabIndex = 4;
            this.uiButtonPrevious.Text = "<";
            this.uiButtonPrevious.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonPrevious.Click += new System.EventHandler(this.uiButtonPrevious_Click);
            // 
            // uiButtonNext
            // 
            this.uiButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonNext.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonNext.Location = new System.Drawing.Point(533, 521);
            this.uiButtonNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonNext.Name = "uiButtonNext";
            this.uiButtonNext.Size = new System.Drawing.Size(100, 35);
            this.uiButtonNext.TabIndex = 5;
            this.uiButtonNext.Text = ">";
            this.uiButtonNext.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonNext.Click += new System.EventHandler(this.uiButtonNext_Click);
            // 
            // uiButtonLast
            // 
            this.uiButtonLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonLast.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonLast.Location = new System.Drawing.Point(656, 521);
            this.uiButtonLast.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonLast.Name = "uiButtonLast";
            this.uiButtonLast.Size = new System.Drawing.Size(100, 35);
            this.uiButtonLast.TabIndex = 6;
            this.uiButtonLast.Text = ">>";
            this.uiButtonLast.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonLast.Click += new System.EventHandler(this.uiButtonLast_Click);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle33;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(78, 130);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(679, 365);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 7;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(307, 512);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(220, 44);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "uiLabel1";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButtonFullData
            // 
            this.uiButtonFullData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonFullData.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonFullData.Location = new System.Drawing.Point(78, 71);
            this.uiButtonFullData.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonFullData.Name = "uiButtonFullData";
            this.uiButtonFullData.Size = new System.Drawing.Size(100, 35);
            this.uiButtonFullData.TabIndex = 9;
            this.uiButtonFullData.Text = "詳細資料";
            this.uiButtonFullData.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonFullData.Click += new System.EventHandler(this.uiButtonFullData_Click);
            // 
            // nhEmployeeDataSet1
            // 
            this.nhEmployeeDataSet1.DataSetName = "NHEmployeeDataSet";
            this.nhEmployeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeDepartmentTableAdapter1
            // 
            this.employeeDepartmentTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeJobTitleTableAdapter1
            // 
            this.employeeJobTitleTableAdapter1.ClearBeforeFill = true;
            // 
            // UC_EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiButtonFullData);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.uiButtonLast);
            this.Controls.Add(this.uiButtonNext);
            this.Controls.Add(this.uiButtonPrevious);
            this.Controls.Add(this.uiButtonFirstLine);
            this.Controls.Add(this.uiButtonDeleteData);
            this.Controls.Add(this.uiButtonAddNewData);
            this.Name = "UC_EmployeeList";
            this.Size = new System.Drawing.Size(982, 597);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhEmployeeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton uiButtonAddNewData;
        private Sunny.UI.UIButton uiButtonDeleteData;
        private Sunny.UI.UIButton uiButtonFirstLine;
        private Sunny.UI.UIButton uiButtonPrevious;
        private Sunny.UI.UIButton uiButtonNext;
        private Sunny.UI.UIButton uiButtonLast;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UILabel uiLabel1;
        private NHEmployeeDataSet nhEmployeeDataSet1;
        private NHEmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private Sunny.UI.UIButton uiButtonFullData;
        private NHEmployeeDataSetTableAdapters.EmployeeDepartmentTableAdapter employeeDepartmentTableAdapter1;
        private NHEmployeeDataSetTableAdapters.EmployeeJobTitleTableAdapter employeeJobTitleTableAdapter1;
    }
}
