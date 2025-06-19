namespace MiddleProject1.功能區塊.活動
{
    partial class FrmEventRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventRecord));
            System.Windows.Forms.Label eventRecordIDLabel;
            System.Windows.Forms.Label batchIDLabel;
            System.Windows.Forms.Label contentLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label internalRemarksLabel;
            System.Windows.Forms.Label createdAtLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label lastModifiedAtLabel;
            System.Windows.Forms.Label lastModifiedByLabel;
            this.nhEventDataSet = new MiddleProject1.功能區塊.活動.nhEventDataSet();
            this.eventRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventRecordsTableAdapter = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.EventRecordsTableAdapter();
            this.tableAdapterManager = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager();
            this.eventRecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eventRecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventRecordIDTextBox = new System.Windows.Forms.TextBox();
            this.batchIDTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.internalRemarksTextBox = new System.Windows.Forms.TextBox();
            this.createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastModifiedByTextBox = new System.Windows.Forms.TextBox();
            eventRecordIDLabel = new System.Windows.Forms.Label();
            batchIDLabel = new System.Windows.Forms.Label();
            contentLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            internalRemarksLabel = new System.Windows.Forms.Label();
            createdAtLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            lastModifiedAtLabel = new System.Windows.Forms.Label();
            lastModifiedByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordsBindingNavigator)).BeginInit();
            this.eventRecordsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhEventDataSet
            // 
            this.nhEventDataSet.DataSetName = "nhEventDataSet";
            this.nhEventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventRecordsBindingSource
            // 
            this.eventRecordsBindingSource.DataMember = "EventRecords";
            this.eventRecordsBindingSource.DataSource = this.nhEventDataSet;
            // 
            // eventRecordsTableAdapter
            // 
            this.eventRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EventBatchTableAdapter = null;
            this.tableAdapterManager.EventCategoryTableAdapter = null;
            this.tableAdapterManager.EventDetailsTableAdapter = null;
            this.tableAdapterManager.EventPhotosTableAdapter = null;
            this.tableAdapterManager.EventRecordPhotosTableAdapter = null;
            this.tableAdapterManager.EventRecordsTableAdapter = this.eventRecordsTableAdapter;
            this.tableAdapterManager.EventStatusTableAdapter = null;
            this.tableAdapterManager.RegistrationDetailsTableAdapter = null;
            this.tableAdapterManager.RegistrationParticipantsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventRecordsBindingNavigator
            // 
            this.eventRecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventRecordsBindingNavigator.BindingSource = this.eventRecordsBindingSource;
            this.eventRecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventRecordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventRecordsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventRecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventRecordsBindingNavigatorSaveItem});
            this.eventRecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventRecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventRecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventRecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventRecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventRecordsBindingNavigator.Name = "eventRecordsBindingNavigator";
            this.eventRecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventRecordsBindingNavigator.Size = new System.Drawing.Size(945, 31);
            this.eventRecordsBindingNavigator.TabIndex = 0;
            this.eventRecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 19);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
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
            // eventRecordsBindingNavigatorSaveItem
            // 
            this.eventRecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventRecordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventRecordsBindingNavigatorSaveItem.Image")));
            this.eventRecordsBindingNavigatorSaveItem.Name = "eventRecordsBindingNavigatorSaveItem";
            this.eventRecordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.eventRecordsBindingNavigatorSaveItem.Text = "儲存資料";
            this.eventRecordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventRecordsBindingNavigatorSaveItem_Click_1);
            // 
            // eventRecordIDLabel
            // 
            eventRecordIDLabel.AutoSize = true;
            eventRecordIDLabel.Location = new System.Drawing.Point(37, 46);
            eventRecordIDLabel.Name = "eventRecordIDLabel";
            eventRecordIDLabel.Size = new System.Drawing.Size(102, 19);
            eventRecordIDLabel.TabIndex = 1;
            eventRecordIDLabel.Text = "活動明細編號:";
            // 
            // eventRecordIDTextBox
            // 
            this.eventRecordIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventRecordsBindingSource, "EventRecordID", true));
            this.eventRecordIDTextBox.Location = new System.Drawing.Point(169, 42);
            this.eventRecordIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventRecordIDTextBox.Name = "eventRecordIDTextBox";
            this.eventRecordIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.eventRecordIDTextBox.TabIndex = 2;
            // 
            // batchIDLabel
            // 
            batchIDLabel.AutoSize = true;
            batchIDLabel.Location = new System.Drawing.Point(67, 82);
            batchIDLabel.Name = "batchIDLabel";
            batchIDLabel.Size = new System.Drawing.Size(72, 19);
            batchIDLabel.TabIndex = 3;
            batchIDLabel.Text = "活動編號:";
            // 
            // batchIDTextBox
            // 
            this.batchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventRecordsBindingSource, "BatchID", true));
            this.batchIDTextBox.Location = new System.Drawing.Point(169, 82);
            this.batchIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.batchIDTextBox.Name = "batchIDTextBox";
            this.batchIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.batchIDTextBox.TabIndex = 4;
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new System.Drawing.Point(97, 124);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(42, 19);
            contentLabel.TabIndex = 5;
            contentLabel.Text = "內容:";
            // 
            // contentTextBox
            // 
            this.contentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventRecordsBindingSource, "Content", true));
            this.contentTextBox.Location = new System.Drawing.Point(169, 124);
            this.contentTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(675, 292);
            this.contentTextBox.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(97, 424);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 19);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "狀態:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventRecordsBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(169, 424);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(224, 27);
            this.statusTextBox.TabIndex = 8;
            // 
            // internalRemarksLabel
            // 
            internalRemarksLabel.AutoSize = true;
            internalRemarksLabel.Location = new System.Drawing.Point(37, 206);
            internalRemarksLabel.Name = "internalRemarksLabel";
            internalRemarksLabel.Size = new System.Drawing.Size(0, 19);
            internalRemarksLabel.TabIndex = 9;
            // 
            // internalRemarksTextBox
            // 
            this.internalRemarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventRecordsBindingSource, "InternalRemarks", true));
            this.internalRemarksTextBox.Location = new System.Drawing.Point(709, 46);
            this.internalRemarksTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.internalRemarksTextBox.Name = "internalRemarksTextBox";
            this.internalRemarksTextBox.Size = new System.Drawing.Size(224, 27);
            this.internalRemarksTextBox.TabIndex = 10;
            // 
            // createdAtLabel
            // 
            createdAtLabel.AutoSize = true;
            createdAtLabel.Location = new System.Drawing.Point(232, 284);
            createdAtLabel.Name = "createdAtLabel";
            createdAtLabel.Size = new System.Drawing.Size(0, 19);
            createdAtLabel.TabIndex = 11;
            // 
            // createdAtDateTimePicker
            // 
            this.createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventRecordsBindingSource, "CreatedAt", true));
            this.createdAtDateTimePicker.Location = new System.Drawing.Point(709, 86);
            this.createdAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            this.createdAtDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.createdAtDateTimePicker.TabIndex = 12;
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(232, 322);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(0, 19);
            createdByLabel.TabIndex = 13;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventRecordsBindingSource, "CreatedBy", true));
            this.createdByTextBox.Location = new System.Drawing.Point(709, 125);
            this.createdByTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.Size = new System.Drawing.Size(224, 27);
            this.createdByTextBox.TabIndex = 14;
            // 
            // lastModifiedAtLabel
            // 
            lastModifiedAtLabel.AutoSize = true;
            lastModifiedAtLabel.Location = new System.Drawing.Point(232, 362);
            lastModifiedAtLabel.Name = "lastModifiedAtLabel";
            lastModifiedAtLabel.Size = new System.Drawing.Size(0, 19);
            lastModifiedAtLabel.TabIndex = 15;
            // 
            // lastModifiedAtDateTimePicker
            // 
            this.lastModifiedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventRecordsBindingSource, "LastModifiedAt", true));
            this.lastModifiedAtDateTimePicker.Location = new System.Drawing.Point(709, 164);
            this.lastModifiedAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastModifiedAtDateTimePicker.Name = "lastModifiedAtDateTimePicker";
            this.lastModifiedAtDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.lastModifiedAtDateTimePicker.TabIndex = 16;
            // 
            // lastModifiedByLabel
            // 
            lastModifiedByLabel.AutoSize = true;
            lastModifiedByLabel.Location = new System.Drawing.Point(232, 400);
            lastModifiedByLabel.Name = "lastModifiedByLabel";
            lastModifiedByLabel.Size = new System.Drawing.Size(0, 19);
            lastModifiedByLabel.TabIndex = 17;
            // 
            // lastModifiedByTextBox
            // 
            this.lastModifiedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventRecordsBindingSource, "LastModifiedBy", true));
            this.lastModifiedByTextBox.Location = new System.Drawing.Point(709, 203);
            this.lastModifiedByTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastModifiedByTextBox.Name = "lastModifiedByTextBox";
            this.lastModifiedByTextBox.Size = new System.Drawing.Size(224, 27);
            this.lastModifiedByTextBox.TabIndex = 18;
            // 
            // FrmEventRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 692);
            this.Controls.Add(eventRecordIDLabel);
            this.Controls.Add(this.eventRecordIDTextBox);
            this.Controls.Add(batchIDLabel);
            this.Controls.Add(this.batchIDTextBox);
            this.Controls.Add(contentLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(internalRemarksLabel);
            this.Controls.Add(this.internalRemarksTextBox);
            this.Controls.Add(createdAtLabel);
            this.Controls.Add(this.createdAtDateTimePicker);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(lastModifiedAtLabel);
            this.Controls.Add(this.lastModifiedAtDateTimePicker);
            this.Controls.Add(lastModifiedByLabel);
            this.Controls.Add(this.lastModifiedByTextBox);
            this.Controls.Add(this.eventRecordsBindingNavigator);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEventRecord";
            this.Text = "FrmEventRecord";
            this.Load += new System.EventHandler(this.FrmEventRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventRecordsBindingNavigator)).EndInit();
            this.eventRecordsBindingNavigator.ResumeLayout(false);
            this.eventRecordsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nhEventDataSet nhEventDataSet;
        private System.Windows.Forms.BindingSource eventRecordsBindingSource;
        private nhEventDataSetTableAdapters.EventRecordsTableAdapter eventRecordsTableAdapter;
        private nhEventDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventRecordsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventRecordsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eventRecordIDTextBox;
        private System.Windows.Forms.TextBox batchIDTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox internalRemarksTextBox;
        private System.Windows.Forms.DateTimePicker createdAtDateTimePicker;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.DateTimePicker lastModifiedAtDateTimePicker;
        private System.Windows.Forms.TextBox lastModifiedByTextBox;
    }
}