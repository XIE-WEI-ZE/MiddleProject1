namespace MiddleProject1.功能區塊.活動
{
    partial class FrmEventBatchList
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
            System.Windows.Forms.Label eventIDLabel;
            System.Windows.Forms.Label batchIDLabel;
            System.Windows.Forms.Label eventDateTimeStarLabel;
            System.Windows.Forms.Label eventDateTimeEndLabel;
            System.Windows.Forms.Label registrationDateStarLabel;
            System.Windows.Forms.Label registrationDateEndLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label recurrenceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventBatchList));
            this.nhEventDataSet = new MiddleProject1.功能區塊.活動.nhEventDataSet();
            this.eventBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventBatchTableAdapter = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.EventBatchTableAdapter();
            this.tableAdapterManager = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager();
            this.eventBatchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eventBatchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventIDTextBox = new System.Windows.Forms.TextBox();
            this.batchIDTextBox = new System.Windows.Forms.TextBox();
            this.eventDateTimeStarDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventDateTimeEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registrationDateStarDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registrationDateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.recurrenceTextBox = new System.Windows.Forms.TextBox();
            this.createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastModifiedByTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            eventIDLabel = new System.Windows.Forms.Label();
            batchIDLabel = new System.Windows.Forms.Label();
            eventDateTimeStarLabel = new System.Windows.Forms.Label();
            eventDateTimeEndLabel = new System.Windows.Forms.Label();
            registrationDateStarLabel = new System.Windows.Forms.Label();
            registrationDateEndLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            recurrenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBatchBindingNavigator)).BeginInit();
            this.eventBatchBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventIDLabel
            // 
            eventIDLabel.AutoSize = true;
            eventIDLabel.Location = new System.Drawing.Point(236, 99);
            eventIDLabel.Name = "eventIDLabel";
            eventIDLabel.Size = new System.Drawing.Size(102, 19);
            eventIDLabel.TabIndex = 1;
            eventIDLabel.Text = "活動明細編號:";
            // 
            // batchIDLabel
            // 
            batchIDLabel.AutoSize = true;
            batchIDLabel.Location = new System.Drawing.Point(236, 68);
            batchIDLabel.Name = "batchIDLabel";
            batchIDLabel.Size = new System.Drawing.Size(69, 19);
            batchIDLabel.TabIndex = 3;
            batchIDLabel.Text = "活動編號";
            // 
            // eventDateTimeStarLabel
            // 
            eventDateTimeStarLabel.AutoSize = true;
            eventDateTimeStarLabel.Location = new System.Drawing.Point(236, 132);
            eventDateTimeStarLabel.Name = "eventDateTimeStarLabel";
            eventDateTimeStarLabel.Size = new System.Drawing.Size(97, 19);
            eventDateTimeStarLabel.TabIndex = 5;
            eventDateTimeStarLabel.Text = "活動日期(起):";
            // 
            // eventDateTimeEndLabel
            // 
            eventDateTimeEndLabel.AutoSize = true;
            eventDateTimeEndLabel.Location = new System.Drawing.Point(236, 165);
            eventDateTimeEndLabel.Name = "eventDateTimeEndLabel";
            eventDateTimeEndLabel.Size = new System.Drawing.Size(97, 19);
            eventDateTimeEndLabel.TabIndex = 7;
            eventDateTimeEndLabel.Text = "活動日期(迄):";
            // 
            // registrationDateStarLabel
            // 
            registrationDateStarLabel.AutoSize = true;
            registrationDateStarLabel.Location = new System.Drawing.Point(236, 198);
            registrationDateStarLabel.Name = "registrationDateStarLabel";
            registrationDateStarLabel.Size = new System.Drawing.Size(94, 19);
            registrationDateStarLabel.TabIndex = 9;
            registrationDateStarLabel.Text = "報名日期(起)";
            // 
            // registrationDateEndLabel
            // 
            registrationDateEndLabel.AutoSize = true;
            registrationDateEndLabel.Location = new System.Drawing.Point(236, 231);
            registrationDateEndLabel.Name = "registrationDateEndLabel";
            registrationDateEndLabel.Size = new System.Drawing.Size(97, 19);
            registrationDateEndLabel.TabIndex = 11;
            registrationDateEndLabel.Text = "報名日期(迄):";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(236, 263);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 19);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "狀態:";
            // 
            // recurrenceLabel
            // 
            recurrenceLabel.AutoSize = true;
            recurrenceLabel.Location = new System.Drawing.Point(236, 296);
            recurrenceLabel.Name = "recurrenceLabel";
            recurrenceLabel.Size = new System.Drawing.Size(57, 19);
            recurrenceLabel.TabIndex = 15;
            recurrenceLabel.Text = "週期性:";
            // 
            // nhEventDataSet
            // 
            this.nhEventDataSet.DataSetName = "nhEventDataSet";
            this.nhEventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBatchBindingSource
            // 
            this.eventBatchBindingSource.DataMember = "EventBatch";
            this.eventBatchBindingSource.DataSource = this.nhEventDataSet;
            // 
            // eventBatchTableAdapter
            // 
            this.eventBatchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EventBatchTableAdapter = this.eventBatchTableAdapter;
            this.tableAdapterManager.EventCategoryTableAdapter = null;
            this.tableAdapterManager.EventDetailsTableAdapter = null;
            this.tableAdapterManager.EventPhotosTableAdapter = null;
            this.tableAdapterManager.EventRecordPhotosTableAdapter = null;
            this.tableAdapterManager.EventRecordsTableAdapter = null;
            this.tableAdapterManager.EventStatusTableAdapter = null;
            this.tableAdapterManager.RegistrationDetailsTableAdapter = null;
            this.tableAdapterManager.RegistrationParticipantsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventBatchBindingNavigator
            // 
            this.eventBatchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventBatchBindingNavigator.BindingSource = this.eventBatchBindingSource;
            this.eventBatchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventBatchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventBatchBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventBatchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eventBatchBindingNavigatorSaveItem});
            this.eventBatchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventBatchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventBatchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventBatchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventBatchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventBatchBindingNavigator.Name = "eventBatchBindingNavigator";
            this.eventBatchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventBatchBindingNavigator.Size = new System.Drawing.Size(900, 27);
            this.eventBatchBindingNavigator.TabIndex = 0;
            this.eventBatchBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // eventBatchBindingNavigatorSaveItem
            // 
            this.eventBatchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventBatchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventBatchBindingNavigatorSaveItem.Image")));
            this.eventBatchBindingNavigatorSaveItem.Name = "eventBatchBindingNavigatorSaveItem";
            this.eventBatchBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.eventBatchBindingNavigatorSaveItem.Text = "儲存資料";
            this.eventBatchBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventBatchBindingNavigatorSaveItem_Click_1);
            // 
            // eventIDTextBox
            // 
            this.eventIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBatchBindingSource, "EventID", true));
            this.eventIDTextBox.Location = new System.Drawing.Point(359, 96);
            this.eventIDTextBox.Name = "eventIDTextBox";
            this.eventIDTextBox.Size = new System.Drawing.Size(200, 27);
            this.eventIDTextBox.TabIndex = 2;
            // 
            // batchIDTextBox
            // 
            this.batchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBatchBindingSource, "BatchID", true));
            this.batchIDTextBox.Location = new System.Drawing.Point(359, 60);
            this.batchIDTextBox.Name = "batchIDTextBox";
            this.batchIDTextBox.Size = new System.Drawing.Size(200, 27);
            this.batchIDTextBox.TabIndex = 4;
            // 
            // eventDateTimeStarDateTimePicker
            // 
            this.eventDateTimeStarDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBatchBindingSource, "EventDateTimeStar", true));
            this.eventDateTimeStarDateTimePicker.Location = new System.Drawing.Point(359, 126);
            this.eventDateTimeStarDateTimePicker.Name = "eventDateTimeStarDateTimePicker";
            this.eventDateTimeStarDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.eventDateTimeStarDateTimePicker.TabIndex = 6;
            // 
            // eventDateTimeEndDateTimePicker
            // 
            this.eventDateTimeEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBatchBindingSource, "EventDateTimeEnd", true));
            this.eventDateTimeEndDateTimePicker.Location = new System.Drawing.Point(359, 159);
            this.eventDateTimeEndDateTimePicker.Name = "eventDateTimeEndDateTimePicker";
            this.eventDateTimeEndDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.eventDateTimeEndDateTimePicker.TabIndex = 8;
            // 
            // registrationDateStarDateTimePicker
            // 
            this.registrationDateStarDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBatchBindingSource, "RegistrationDateStar", true));
            this.registrationDateStarDateTimePicker.Location = new System.Drawing.Point(359, 192);
            this.registrationDateStarDateTimePicker.Name = "registrationDateStarDateTimePicker";
            this.registrationDateStarDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.registrationDateStarDateTimePicker.TabIndex = 10;
            // 
            // registrationDateEndDateTimePicker
            // 
            this.registrationDateEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBatchBindingSource, "RegistrationDateEnd", true));
            this.registrationDateEndDateTimePicker.Location = new System.Drawing.Point(359, 225);
            this.registrationDateEndDateTimePicker.Name = "registrationDateEndDateTimePicker";
            this.registrationDateEndDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.registrationDateEndDateTimePicker.TabIndex = 12;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBatchBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(571, 261);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(30, 27);
            this.statusTextBox.TabIndex = 14;
            // 
            // recurrenceTextBox
            // 
            this.recurrenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBatchBindingSource, "Recurrence", true));
            this.recurrenceTextBox.Location = new System.Drawing.Point(359, 291);
            this.recurrenceTextBox.Name = "recurrenceTextBox";
            this.recurrenceTextBox.Size = new System.Drawing.Size(200, 27);
            this.recurrenceTextBox.TabIndex = 16;
            // 
            // createdAtDateTimePicker
            // 
            this.createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBatchBindingSource, "CreatedAt", true));
            this.createdAtDateTimePicker.Location = new System.Drawing.Point(-42, 166);
            this.createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            this.createdAtDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.createdAtDateTimePicker.TabIndex = 18;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBatchBindingSource, "CreatedBy", true));
            this.createdByTextBox.Location = new System.Drawing.Point(-42, 199);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.Size = new System.Drawing.Size(200, 27);
            this.createdByTextBox.TabIndex = 20;
            // 
            // lastModifiedAtDateTimePicker
            // 
            this.lastModifiedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBatchBindingSource, "LastModifiedAt", true));
            this.lastModifiedAtDateTimePicker.Location = new System.Drawing.Point(-42, 232);
            this.lastModifiedAtDateTimePicker.Name = "lastModifiedAtDateTimePicker";
            this.lastModifiedAtDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.lastModifiedAtDateTimePicker.TabIndex = 22;
            // 
            // lastModifiedByTextBox
            // 
            this.lastModifiedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBatchBindingSource, "LastModifiedBy", true));
            this.lastModifiedByTextBox.Location = new System.Drawing.Point(-42, 265);
            this.lastModifiedByTextBox.Name = "lastModifiedByTextBox";
            this.lastModifiedByTextBox.Size = new System.Drawing.Size(200, 27);
            this.lastModifiedByTextBox.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(359, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 27);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEventBatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(eventIDLabel);
            this.Controls.Add(this.eventIDTextBox);
            this.Controls.Add(batchIDLabel);
            this.Controls.Add(this.batchIDTextBox);
            this.Controls.Add(eventDateTimeStarLabel);
            this.Controls.Add(this.eventDateTimeStarDateTimePicker);
            this.Controls.Add(eventDateTimeEndLabel);
            this.Controls.Add(this.eventDateTimeEndDateTimePicker);
            this.Controls.Add(registrationDateStarLabel);
            this.Controls.Add(this.registrationDateStarDateTimePicker);
            this.Controls.Add(registrationDateEndLabel);
            this.Controls.Add(this.registrationDateEndDateTimePicker);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(recurrenceLabel);
            this.Controls.Add(this.recurrenceTextBox);
            this.Controls.Add(this.createdAtDateTimePicker);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(this.lastModifiedAtDateTimePicker);
            this.Controls.Add(this.lastModifiedByTextBox);
            this.Controls.Add(this.eventBatchBindingNavigator);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEventBatchList";
            this.Text = "FrmEventBatchList";
            this.Load += new System.EventHandler(this.FrmEventBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBatchBindingNavigator)).EndInit();
            this.eventBatchBindingNavigator.ResumeLayout(false);
            this.eventBatchBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nhEventDataSet nhEventDataSet;
        private System.Windows.Forms.BindingSource eventBatchBindingSource;
        private nhEventDataSetTableAdapters.EventBatchTableAdapter eventBatchTableAdapter;
        private nhEventDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventBatchBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eventBatchBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eventIDTextBox;
        private System.Windows.Forms.TextBox batchIDTextBox;
        private System.Windows.Forms.DateTimePicker eventDateTimeStarDateTimePicker;
        private System.Windows.Forms.DateTimePicker eventDateTimeEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker registrationDateStarDateTimePicker;
        private System.Windows.Forms.DateTimePicker registrationDateEndDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox recurrenceTextBox;
        private System.Windows.Forms.DateTimePicker createdAtDateTimePicker;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.DateTimePicker lastModifiedAtDateTimePicker;
        private System.Windows.Forms.TextBox lastModifiedByTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}