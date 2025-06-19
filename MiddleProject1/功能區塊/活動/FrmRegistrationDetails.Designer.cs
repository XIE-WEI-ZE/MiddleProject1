namespace MiddleProject1.功能區塊.活動
{
    partial class FrmRegistrationDetails
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
            System.Windows.Forms.Label registrationIDLabel;
            System.Windows.Forms.Label eventBatchIDLabel;
            System.Windows.Forms.Label memberIDLabel;
            System.Windows.Forms.Label numberOfPeopleLabel;
            System.Windows.Forms.Label paymentStatusLabel;
            System.Windows.Forms.Label amountDueLabel;
            System.Windows.Forms.Label registrationDateTimeLabel;
            System.Windows.Forms.Label currentStatusLabel;
            this.nhEventDataSet = new MiddleProject1.功能區塊.活動.nhEventDataSet();
            this.registrationDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDetailsTableAdapter1 = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.RegistrationDetailsTableAdapter();
            this.tableAdapterManager1 = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager();
            this.registrationIDTextBox = new System.Windows.Forms.TextBox();
            this.eventBatchIDTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPeopleTextBox = new System.Windows.Forms.TextBox();
            this.paymentStatusTextBox = new System.Windows.Forms.TextBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.registrationDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.currentStatusTextBox = new System.Windows.Forms.TextBox();
            this.internalRemarksTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastModifiedByTextBox = new System.Windows.Forms.TextBox();
            registrationIDLabel = new System.Windows.Forms.Label();
            eventBatchIDLabel = new System.Windows.Forms.Label();
            memberIDLabel = new System.Windows.Forms.Label();
            numberOfPeopleLabel = new System.Windows.Forms.Label();
            paymentStatusLabel = new System.Windows.Forms.Label();
            amountDueLabel = new System.Windows.Forms.Label();
            registrationDateTimeLabel = new System.Windows.Forms.Label();
            currentStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationIDLabel
            // 
            registrationIDLabel.AutoSize = true;
            registrationIDLabel.Location = new System.Drawing.Point(232, 24);
            registrationIDLabel.Name = "registrationIDLabel";
            registrationIDLabel.Size = new System.Drawing.Size(71, 15);
            registrationIDLabel.TabIndex = 0;
            registrationIDLabel.Text = "報名編號:";
            // 
            // eventBatchIDLabel
            // 
            eventBatchIDLabel.AutoSize = true;
            eventBatchIDLabel.Location = new System.Drawing.Point(232, 55);
            eventBatchIDLabel.Name = "eventBatchIDLabel";
            eventBatchIDLabel.Size = new System.Drawing.Size(101, 15);
            eventBatchIDLabel.TabIndex = 2;
            eventBatchIDLabel.Text = "活動梯次編號:";
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(232, 86);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(71, 15);
            memberIDLabel.TabIndex = 4;
            memberIDLabel.Text = "會員編號:";
            // 
            // numberOfPeopleLabel
            // 
            numberOfPeopleLabel.AutoSize = true;
            numberOfPeopleLabel.Location = new System.Drawing.Point(232, 117);
            numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            numberOfPeopleLabel.Size = new System.Drawing.Size(71, 15);
            numberOfPeopleLabel.TabIndex = 6;
            numberOfPeopleLabel.Text = "報名人數:";
            // 
            // paymentStatusLabel
            // 
            paymentStatusLabel.AutoSize = true;
            paymentStatusLabel.Location = new System.Drawing.Point(232, 148);
            paymentStatusLabel.Name = "paymentStatusLabel";
            paymentStatusLabel.Size = new System.Drawing.Size(71, 15);
            paymentStatusLabel.TabIndex = 8;
            paymentStatusLabel.Text = "繳費狀態:";
            // 
            // amountDueLabel
            // 
            amountDueLabel.AutoSize = true;
            amountDueLabel.Location = new System.Drawing.Point(232, 179);
            amountDueLabel.Name = "amountDueLabel";
            amountDueLabel.Size = new System.Drawing.Size(71, 15);
            amountDueLabel.TabIndex = 10;
            amountDueLabel.Text = "需繳金額:";
            // 
            // registrationDateTimeLabel
            // 
            registrationDateTimeLabel.AutoSize = true;
            registrationDateTimeLabel.Location = new System.Drawing.Point(232, 211);
            registrationDateTimeLabel.Name = "registrationDateTimeLabel";
            registrationDateTimeLabel.Size = new System.Drawing.Size(71, 15);
            registrationDateTimeLabel.TabIndex = 12;
            registrationDateTimeLabel.Text = "報名時間:";
            // 
            // currentStatusLabel
            // 
            currentStatusLabel.AutoSize = true;
            currentStatusLabel.Location = new System.Drawing.Point(232, 241);
            currentStatusLabel.Name = "currentStatusLabel";
            currentStatusLabel.Size = new System.Drawing.Size(71, 15);
            currentStatusLabel.TabIndex = 14;
            currentStatusLabel.Text = "目前狀態:";
            // 
            // nhEventDataSet
            // 
            this.nhEventDataSet.DataSetName = "nhEventDataSet";
            this.nhEventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationDetailsBindingSource1
            // 
            this.registrationDetailsBindingSource1.DataMember = "RegistrationDetails";
            this.registrationDetailsBindingSource1.DataSource = this.nhEventDataSet;
            // 
            // registrationDetailsTableAdapter1
            // 
            this.registrationDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.EventBatchTableAdapter = null;
            this.tableAdapterManager1.EventCategoryTableAdapter = null;
            this.tableAdapterManager1.EventDetailsTableAdapter = null;
            this.tableAdapterManager1.EventPhotosTableAdapter = null;
            this.tableAdapterManager1.EventRecordPhotosTableAdapter = null;
            this.tableAdapterManager1.EventRecordsTableAdapter = null;
            this.tableAdapterManager1.EventStatusTableAdapter = null;
            this.tableAdapterManager1.RegistrationDetailsTableAdapter = this.registrationDetailsTableAdapter1;
            this.tableAdapterManager1.RegistrationParticipantsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registrationIDTextBox
            // 
            this.registrationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "RegistrationID", true));
            this.registrationIDTextBox.Location = new System.Drawing.Point(381, 21);
            this.registrationIDTextBox.Name = "registrationIDTextBox";
            this.registrationIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.registrationIDTextBox.TabIndex = 1;
            // 
            // eventBatchIDTextBox
            // 
            this.eventBatchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "EventBatchID", true));
            this.eventBatchIDTextBox.Location = new System.Drawing.Point(381, 52);
            this.eventBatchIDTextBox.Name = "eventBatchIDTextBox";
            this.eventBatchIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.eventBatchIDTextBox.TabIndex = 3;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "MemberID", true));
            this.memberIDTextBox.Location = new System.Drawing.Point(381, 83);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.memberIDTextBox.TabIndex = 5;
            // 
            // numberOfPeopleTextBox
            // 
            this.numberOfPeopleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "NumberOfPeople", true));
            this.numberOfPeopleTextBox.Location = new System.Drawing.Point(381, 114);
            this.numberOfPeopleTextBox.Name = "numberOfPeopleTextBox";
            this.numberOfPeopleTextBox.Size = new System.Drawing.Size(200, 25);
            this.numberOfPeopleTextBox.TabIndex = 7;
            // 
            // paymentStatusTextBox
            // 
            this.paymentStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "PaymentStatus", true));
            this.paymentStatusTextBox.Location = new System.Drawing.Point(381, 145);
            this.paymentStatusTextBox.Name = "paymentStatusTextBox";
            this.paymentStatusTextBox.Size = new System.Drawing.Size(200, 25);
            this.paymentStatusTextBox.TabIndex = 9;
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "AmountDue", true));
            this.amountDueTextBox.Location = new System.Drawing.Point(381, 176);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.Size = new System.Drawing.Size(200, 25);
            this.amountDueTextBox.TabIndex = 11;
            // 
            // registrationDateTimeDateTimePicker
            // 
            this.registrationDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationDetailsBindingSource1, "RegistrationDateTime", true));
            this.registrationDateTimeDateTimePicker.Location = new System.Drawing.Point(381, 207);
            this.registrationDateTimeDateTimePicker.Name = "registrationDateTimeDateTimePicker";
            this.registrationDateTimeDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.registrationDateTimeDateTimePicker.TabIndex = 13;
            // 
            // currentStatusTextBox
            // 
            this.currentStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "CurrentStatus", true));
            this.currentStatusTextBox.Location = new System.Drawing.Point(381, 238);
            this.currentStatusTextBox.Name = "currentStatusTextBox";
            this.currentStatusTextBox.Size = new System.Drawing.Size(200, 25);
            this.currentStatusTextBox.TabIndex = 15;
            // 
            // internalRemarksTextBox
            // 
            this.internalRemarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "InternalRemarks", true));
            this.internalRemarksTextBox.Location = new System.Drawing.Point(12, 169);
            this.internalRemarksTextBox.Name = "internalRemarksTextBox";
            this.internalRemarksTextBox.Size = new System.Drawing.Size(200, 25);
            this.internalRemarksTextBox.TabIndex = 17;
            // 
            // lastModifiedAtDateTimePicker
            // 
            this.lastModifiedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationDetailsBindingSource1, "LastModifiedAt", true));
            this.lastModifiedAtDateTimePicker.Location = new System.Drawing.Point(12, 200);
            this.lastModifiedAtDateTimePicker.Name = "lastModifiedAtDateTimePicker";
            this.lastModifiedAtDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.lastModifiedAtDateTimePicker.TabIndex = 19;
            // 
            // lastModifiedByTextBox
            // 
            this.lastModifiedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationDetailsBindingSource1, "LastModifiedBy", true));
            this.lastModifiedByTextBox.Location = new System.Drawing.Point(12, 231);
            this.lastModifiedByTextBox.Name = "lastModifiedByTextBox";
            this.lastModifiedByTextBox.Size = new System.Drawing.Size(200, 25);
            this.lastModifiedByTextBox.TabIndex = 21;
            // 
            // FrmRegistrationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(registrationIDLabel);
            this.Controls.Add(this.registrationIDTextBox);
            this.Controls.Add(eventBatchIDLabel);
            this.Controls.Add(this.eventBatchIDTextBox);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(numberOfPeopleLabel);
            this.Controls.Add(this.numberOfPeopleTextBox);
            this.Controls.Add(paymentStatusLabel);
            this.Controls.Add(this.paymentStatusTextBox);
            this.Controls.Add(amountDueLabel);
            this.Controls.Add(this.amountDueTextBox);
            this.Controls.Add(registrationDateTimeLabel);
            this.Controls.Add(this.registrationDateTimeDateTimePicker);
            this.Controls.Add(currentStatusLabel);
            this.Controls.Add(this.currentStatusTextBox);
            this.Controls.Add(this.internalRemarksTextBox);
            this.Controls.Add(this.lastModifiedAtDateTimePicker);
            this.Controls.Add(this.lastModifiedByTextBox);
            this.Name = "FrmRegistrationDetails";
            this.Text = "FrmRegistrationDetails";
            this.Load += new System.EventHandler(this.FrmRegistrationDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private nhEventDataSet nhEventDataSet;
        private System.Windows.Forms.BindingSource registrationDetailsBindingSource1;
        private nhEventDataSetTableAdapters.RegistrationDetailsTableAdapter registrationDetailsTableAdapter1;
        private nhEventDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox registrationIDTextBox;
        private System.Windows.Forms.TextBox eventBatchIDTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox numberOfPeopleTextBox;
        private System.Windows.Forms.TextBox paymentStatusTextBox;
        private System.Windows.Forms.TextBox amountDueTextBox;
        private System.Windows.Forms.DateTimePicker registrationDateTimeDateTimePicker;
        private System.Windows.Forms.TextBox currentStatusTextBox;
        private System.Windows.Forms.TextBox internalRemarksTextBox;
        private System.Windows.Forms.DateTimePicker lastModifiedAtDateTimePicker;
        private System.Windows.Forms.TextBox lastModifiedByTextBox;
    }
}