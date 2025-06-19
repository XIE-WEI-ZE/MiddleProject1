namespace MiddleProject1.功能區塊.活動
{
    partial class FrmEventList
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
            System.Windows.Forms.Label eventNameLabel;
            System.Windows.Forms.Label organizerLabel;
            System.Windows.Forms.Label targetAudienceLabel;
            System.Windows.Forms.Label requiresFamilyInsuranceLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label contactPersonIDLabel;
            System.Windows.Forms.Label contactPhoneLabel;
            System.Windows.Forms.Label eventLocationLabel;
            System.Windows.Forms.Label quotaLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label medicalAidLabel;
            System.Windows.Forms.Label isPaidLabel;
            System.Windows.Forms.Label totalAmountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventList));
            this.nhEventDataSet1 = new MiddleProject1.功能區塊.活動.nhEventDataSet();
            this.eventDetailsTableAdapter1 = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.EventDetailsTableAdapter();
            this.tableAdapterManager1 = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager();
            this.eventDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventIDTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.organizerTextBox = new System.Windows.Forms.TextBox();
            this.targetAudienceTextBox = new System.Windows.Forms.TextBox();
            this.requiresFamilyInsuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonIDTextBox = new System.Windows.Forms.TextBox();
            this.contactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.eventLocationTextBox = new System.Windows.Forms.TextBox();
            this.quotaTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.medicalAidTextBox = new System.Windows.Forms.TextBox();
            this.isPaidCheckBox = new System.Windows.Forms.CheckBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastModifiedByTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            eventIDLabel = new System.Windows.Forms.Label();
            eventNameLabel = new System.Windows.Forms.Label();
            organizerLabel = new System.Windows.Forms.Label();
            targetAudienceLabel = new System.Windows.Forms.Label();
            requiresFamilyInsuranceLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            contactPersonIDLabel = new System.Windows.Forms.Label();
            contactPhoneLabel = new System.Windows.Forms.Label();
            eventLocationLabel = new System.Windows.Forms.Label();
            quotaLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            medicalAidLabel = new System.Windows.Forms.Label();
            isPaidLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingNavigator)).BeginInit();
            this.eventDetailsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventIDLabel
            // 
            eventIDLabel.AutoSize = true;
            eventIDLabel.Location = new System.Drawing.Point(305, 49);
            eventIDLabel.Name = "eventIDLabel";
            eventIDLabel.Size = new System.Drawing.Size(102, 19);
            eventIDLabel.TabIndex = 1;
            eventIDLabel.Text = "活動明細編號:";
            // 
            // eventNameLabel
            // 
            eventNameLabel.AutoSize = true;
            eventNameLabel.Location = new System.Drawing.Point(305, 89);
            eventNameLabel.Name = "eventNameLabel";
            eventNameLabel.Size = new System.Drawing.Size(72, 19);
            eventNameLabel.TabIndex = 3;
            eventNameLabel.Text = "活動名稱:";
            // 
            // organizerLabel
            // 
            organizerLabel.AutoSize = true;
            organizerLabel.Location = new System.Drawing.Point(305, 128);
            organizerLabel.Name = "organizerLabel";
            organizerLabel.Size = new System.Drawing.Size(72, 19);
            organizerLabel.TabIndex = 5;
            organizerLabel.Text = "主辦單位:";
            // 
            // targetAudienceLabel
            // 
            targetAudienceLabel.AutoSize = true;
            targetAudienceLabel.Location = new System.Drawing.Point(305, 167);
            targetAudienceLabel.Name = "targetAudienceLabel";
            targetAudienceLabel.Size = new System.Drawing.Size(72, 19);
            targetAudienceLabel.TabIndex = 7;
            targetAudienceLabel.Text = "活動對象:";
            // 
            // requiresFamilyInsuranceLabel
            // 
            requiresFamilyInsuranceLabel.AutoSize = true;
            requiresFamilyInsuranceLabel.Location = new System.Drawing.Point(305, 209);
            requiresFamilyInsuranceLabel.Name = "requiresFamilyInsuranceLabel";
            requiresFamilyInsuranceLabel.Size = new System.Drawing.Size(117, 19);
            requiresFamilyInsuranceLabel.TabIndex = 9;
            requiresFamilyInsuranceLabel.Text = "是否需家屬資料:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(305, 244);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(42, 19);
            categoryIDLabel.TabIndex = 11;
            categoryIDLabel.Text = "類別:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(305, 284);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 19);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "狀態:";
            // 
            // contactPersonIDLabel
            // 
            contactPersonIDLabel.AutoSize = true;
            contactPersonIDLabel.Location = new System.Drawing.Point(305, 323);
            contactPersonIDLabel.Name = "contactPersonIDLabel";
            contactPersonIDLabel.Size = new System.Drawing.Size(72, 19);
            contactPersonIDLabel.TabIndex = 15;
            contactPersonIDLabel.Text = "聯絡人員:";
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new System.Drawing.Point(305, 362);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new System.Drawing.Size(72, 19);
            contactPhoneLabel.TabIndex = 17;
            contactPhoneLabel.Text = "聯絡電話:";
            // 
            // eventLocationLabel
            // 
            eventLocationLabel.AutoSize = true;
            eventLocationLabel.Location = new System.Drawing.Point(305, 402);
            eventLocationLabel.Name = "eventLocationLabel";
            eventLocationLabel.Size = new System.Drawing.Size(72, 19);
            eventLocationLabel.TabIndex = 19;
            eventLocationLabel.Text = "活動地點:";
            // 
            // quotaLabel
            // 
            quotaLabel.AutoSize = true;
            quotaLabel.Location = new System.Drawing.Point(305, 441);
            quotaLabel.Name = "quotaLabel";
            quotaLabel.Size = new System.Drawing.Size(42, 19);
            quotaLabel.TabIndex = 21;
            quotaLabel.Text = "名額:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(305, 480);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(72, 19);
            descriptionLabel.TabIndex = 23;
            descriptionLabel.Text = "活動內容:";
            // 
            // medicalAidLabel
            // 
            medicalAidLabel.AutoSize = true;
            medicalAidLabel.Location = new System.Drawing.Point(305, 519);
            medicalAidLabel.Name = "medicalAidLabel";
            medicalAidLabel.Size = new System.Drawing.Size(147, 19);
            medicalAidLabel.TabIndex = 25;
            medicalAidLabel.Text = "醫療救助與安全措施:";
            // 
            // isPaidLabel
            // 
            isPaidLabel.AutoSize = true;
            isPaidLabel.Location = new System.Drawing.Point(305, 561);
            isPaidLabel.Name = "isPaidLabel";
            isPaidLabel.Size = new System.Drawing.Size(87, 19);
            isPaidLabel.TabIndex = 27;
            isPaidLabel.Text = "是否需付費:";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(305, 597);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(42, 19);
            totalAmountLabel.TabIndex = 29;
            totalAmountLabel.Text = "金額:";
            // 
            // nhEventDataSet1
            // 
            this.nhEventDataSet1.DataSetName = "nhEventDataSet";
            this.nhEventDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventDetailsTableAdapter1
            // 
            this.eventDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.EventBatchTableAdapter = null;
            this.tableAdapterManager1.EventCategoryTableAdapter = null;
            this.tableAdapterManager1.EventDetailsTableAdapter = this.eventDetailsTableAdapter1;
            this.tableAdapterManager1.EventPhotosTableAdapter = null;
            this.tableAdapterManager1.EventRecordPhotosTableAdapter = null;
            this.tableAdapterManager1.EventRecordsTableAdapter = null;
            this.tableAdapterManager1.EventStatusTableAdapter = null;
            this.tableAdapterManager1.RegistrationDetailsTableAdapter = null;
            this.tableAdapterManager1.RegistrationParticipantsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventDetailsBindingSource
            // 
            this.eventDetailsBindingSource.DataMember = "EventDetails";
            this.eventDetailsBindingSource.DataSource = this.nhEventDataSet1;
            // 
            // eventDetailsBindingNavigator
            // 
            this.eventDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventDetailsBindingNavigator.BindingSource = this.eventDetailsBindingSource;
            this.eventDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventDetailsBindingNavigatorSaveItem});
            this.eventDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventDetailsBindingNavigator.Name = "eventDetailsBindingNavigator";
            this.eventDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventDetailsBindingNavigator.Size = new System.Drawing.Size(927, 27);
            this.eventDetailsBindingNavigator.TabIndex = 0;
            this.eventDetailsBindingNavigator.Text = "bindingNavigator1";
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
            // eventDetailsBindingNavigatorSaveItem
            // 
            this.eventDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventDetailsBindingNavigatorSaveItem.Image")));
            this.eventDetailsBindingNavigatorSaveItem.Name = "eventDetailsBindingNavigatorSaveItem";
            this.eventDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.eventDetailsBindingNavigatorSaveItem.Text = "儲存資料";
            this.eventDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventDetailsBindingNavigatorSaveItem_Click);
            // 
            // eventIDTextBox
            // 
            this.eventIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "EventID", true));
            this.eventIDTextBox.Location = new System.Drawing.Point(494, 46);
            this.eventIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventIDTextBox.Name = "eventIDTextBox";
            this.eventIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.eventIDTextBox.TabIndex = 2;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "EventName", true));
            this.eventNameTextBox.Location = new System.Drawing.Point(494, 85);
            this.eventNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(224, 27);
            this.eventNameTextBox.TabIndex = 4;
            // 
            // organizerTextBox
            // 
            this.organizerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "Organizer", true));
            this.organizerTextBox.Location = new System.Drawing.Point(494, 124);
            this.organizerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.organizerTextBox.Name = "organizerTextBox";
            this.organizerTextBox.Size = new System.Drawing.Size(224, 27);
            this.organizerTextBox.TabIndex = 6;
            // 
            // targetAudienceTextBox
            // 
            this.targetAudienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "TargetAudience", true));
            this.targetAudienceTextBox.Location = new System.Drawing.Point(494, 163);
            this.targetAudienceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.targetAudienceTextBox.Name = "targetAudienceTextBox";
            this.targetAudienceTextBox.Size = new System.Drawing.Size(224, 27);
            this.targetAudienceTextBox.TabIndex = 8;
            // 
            // requiresFamilyInsuranceCheckBox
            // 
            this.requiresFamilyInsuranceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eventDetailsBindingSource, "RequiresFamilyInsurance", true));
            this.requiresFamilyInsuranceCheckBox.Location = new System.Drawing.Point(494, 203);
            this.requiresFamilyInsuranceCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.requiresFamilyInsuranceCheckBox.Name = "requiresFamilyInsuranceCheckBox";
            this.requiresFamilyInsuranceCheckBox.Size = new System.Drawing.Size(225, 30);
            this.requiresFamilyInsuranceCheckBox.TabIndex = 10;
            this.requiresFamilyInsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(494, 241);
            this.categoryIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.categoryIDTextBox.TabIndex = 12;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(731, 284);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(45, 27);
            this.statusTextBox.TabIndex = 14;
            // 
            // contactPersonIDTextBox
            // 
            this.contactPersonIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "ContactPersonID", true));
            this.contactPersonIDTextBox.Location = new System.Drawing.Point(494, 319);
            this.contactPersonIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactPersonIDTextBox.Name = "contactPersonIDTextBox";
            this.contactPersonIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.contactPersonIDTextBox.TabIndex = 16;
            // 
            // contactPhoneTextBox
            // 
            this.contactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "ContactPhone", true));
            this.contactPhoneTextBox.Location = new System.Drawing.Point(494, 358);
            this.contactPhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactPhoneTextBox.Name = "contactPhoneTextBox";
            this.contactPhoneTextBox.Size = new System.Drawing.Size(224, 27);
            this.contactPhoneTextBox.TabIndex = 18;
            // 
            // eventLocationTextBox
            // 
            this.eventLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "EventLocation", true));
            this.eventLocationTextBox.Location = new System.Drawing.Point(494, 398);
            this.eventLocationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventLocationTextBox.Name = "eventLocationTextBox";
            this.eventLocationTextBox.Size = new System.Drawing.Size(224, 27);
            this.eventLocationTextBox.TabIndex = 20;
            // 
            // quotaTextBox
            // 
            this.quotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "Quota", true));
            this.quotaTextBox.Location = new System.Drawing.Point(494, 437);
            this.quotaTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quotaTextBox.Name = "quotaTextBox";
            this.quotaTextBox.Size = new System.Drawing.Size(224, 27);
            this.quotaTextBox.TabIndex = 22;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(494, 476);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(224, 27);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // medicalAidTextBox
            // 
            this.medicalAidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "MedicalAid", true));
            this.medicalAidTextBox.Location = new System.Drawing.Point(494, 516);
            this.medicalAidTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medicalAidTextBox.Name = "medicalAidTextBox";
            this.medicalAidTextBox.Size = new System.Drawing.Size(224, 27);
            this.medicalAidTextBox.TabIndex = 26;
            // 
            // isPaidCheckBox
            // 
            this.isPaidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eventDetailsBindingSource, "IsPaid", true));
            this.isPaidCheckBox.Location = new System.Drawing.Point(494, 555);
            this.isPaidCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isPaidCheckBox.Name = "isPaidCheckBox";
            this.isPaidCheckBox.Size = new System.Drawing.Size(225, 30);
            this.isPaidCheckBox.TabIndex = 28;
            this.isPaidCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "TotalAmount", true));
            this.totalAmountTextBox.Location = new System.Drawing.Point(494, 593);
            this.totalAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(224, 27);
            this.totalAmountTextBox.TabIndex = 30;
            // 
            // createdAtDateTimePicker
            // 
            this.createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventDetailsBindingSource, "CreatedAt", true));
            this.createdAtDateTimePicker.Location = new System.Drawing.Point(26, 472);
            this.createdAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            this.createdAtDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.createdAtDateTimePicker.TabIndex = 32;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "CreatedBy", true));
            this.createdByTextBox.Location = new System.Drawing.Point(26, 511);
            this.createdByTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.Size = new System.Drawing.Size(224, 27);
            this.createdByTextBox.TabIndex = 34;
            // 
            // lastModifiedAtDateTimePicker
            // 
            this.lastModifiedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventDetailsBindingSource, "LastModifiedAt", true));
            this.lastModifiedAtDateTimePicker.Location = new System.Drawing.Point(26, 551);
            this.lastModifiedAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastModifiedAtDateTimePicker.Name = "lastModifiedAtDateTimePicker";
            this.lastModifiedAtDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.lastModifiedAtDateTimePicker.TabIndex = 36;
            // 
            // lastModifiedByTextBox
            // 
            this.lastModifiedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventDetailsBindingSource, "LastModifiedBy", true));
            this.lastModifiedByTextBox.Location = new System.Drawing.Point(26, 590);
            this.lastModifiedByTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastModifiedByTextBox.Name = "lastModifiedByTextBox";
            this.lastModifiedByTextBox.Size = new System.Drawing.Size(224, 27);
            this.lastModifiedByTextBox.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(494, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 27);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmEventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(eventIDLabel);
            this.Controls.Add(this.eventIDTextBox);
            this.Controls.Add(eventNameLabel);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(organizerLabel);
            this.Controls.Add(this.organizerTextBox);
            this.Controls.Add(targetAudienceLabel);
            this.Controls.Add(this.targetAudienceTextBox);
            this.Controls.Add(requiresFamilyInsuranceLabel);
            this.Controls.Add(this.requiresFamilyInsuranceCheckBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(contactPersonIDLabel);
            this.Controls.Add(this.contactPersonIDTextBox);
            this.Controls.Add(contactPhoneLabel);
            this.Controls.Add(this.contactPhoneTextBox);
            this.Controls.Add(eventLocationLabel);
            this.Controls.Add(this.eventLocationTextBox);
            this.Controls.Add(quotaLabel);
            this.Controls.Add(this.quotaTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(medicalAidLabel);
            this.Controls.Add(this.medicalAidTextBox);
            this.Controls.Add(isPaidLabel);
            this.Controls.Add(this.isPaidCheckBox);
            this.Controls.Add(totalAmountLabel);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.createdAtDateTimePicker);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(this.lastModifiedAtDateTimePicker);
            this.Controls.Add(this.lastModifiedByTextBox);
            this.Controls.Add(this.eventDetailsBindingNavigator);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEventList";
            this.Text = "FrmEventList";
            this.Load += new System.EventHandler(this.FrmEventList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingNavigator)).EndInit();
            this.eventDetailsBindingNavigator.ResumeLayout(false);
            this.eventDetailsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private nhEventDataSet nhEventDataSet1;
        private nhEventDataSetTableAdapters.EventDetailsTableAdapter eventDetailsTableAdapter1;
        private nhEventDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource eventDetailsBindingSource;
        private System.Windows.Forms.BindingNavigator eventDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eventIDTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.TextBox organizerTextBox;
        private System.Windows.Forms.TextBox targetAudienceTextBox;
        private System.Windows.Forms.CheckBox requiresFamilyInsuranceCheckBox;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox contactPersonIDTextBox;
        private System.Windows.Forms.TextBox contactPhoneTextBox;
        private System.Windows.Forms.TextBox eventLocationTextBox;
        private System.Windows.Forms.TextBox quotaTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox medicalAidTextBox;
        private System.Windows.Forms.CheckBox isPaidCheckBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.DateTimePicker createdAtDateTimePicker;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.DateTimePicker lastModifiedAtDateTimePicker;
        private System.Windows.Forms.TextBox lastModifiedByTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}