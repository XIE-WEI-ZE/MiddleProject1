namespace MiddleProject1.功能區塊.員工
{
    partial class UC_EmployeeUser
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
            this.uiButtonUserEditData = new Sunny.UI.UIButton();
            this.uiButtonUserAttendanceCheck = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiButtonUserEditData
            // 
            this.uiButtonUserEditData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonUserEditData.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonUserEditData.Location = new System.Drawing.Point(85, 72);
            this.uiButtonUserEditData.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonUserEditData.Name = "uiButtonUserEditData";
            this.uiButtonUserEditData.Size = new System.Drawing.Size(184, 92);
            this.uiButtonUserEditData.TabIndex = 0;
            this.uiButtonUserEditData.Text = "修改基本資料";
            this.uiButtonUserEditData.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonUserEditData.Click += new System.EventHandler(this.uiButtonUserEditData_Click);
            // 
            // uiButtonUserAttendanceCheck
            // 
            this.uiButtonUserAttendanceCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonUserAttendanceCheck.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonUserAttendanceCheck.Location = new System.Drawing.Point(85, 193);
            this.uiButtonUserAttendanceCheck.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonUserAttendanceCheck.Name = "uiButtonUserAttendanceCheck";
            this.uiButtonUserAttendanceCheck.Size = new System.Drawing.Size(184, 91);
            this.uiButtonUserAttendanceCheck.TabIndex = 1;
            this.uiButtonUserAttendanceCheck.Text = "考勤查詢";
            this.uiButtonUserAttendanceCheck.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButtonUserAttendanceCheck.Click += new System.EventHandler(this.uiButtonUserAttendanceCheck_Click);
            // 
            // UC_EmployeeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiButtonUserAttendanceCheck);
            this.Controls.Add(this.uiButtonUserEditData);
            this.Name = "UC_EmployeeUser";
            this.Size = new System.Drawing.Size(982, 597);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButtonUserEditData;
        private Sunny.UI.UIButton uiButtonUserAttendanceCheck;
    }
}
