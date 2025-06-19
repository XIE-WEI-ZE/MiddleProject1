namespace MiddleProject1.功能區塊.活動
{
    partial class FrmRegistrationParticipants
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
            System.Windows.Forms.Label companionIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nationalIDLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label contactPhoneLabel;
            System.Windows.Forms.Label otherRemarksLabel;
            System.Windows.Forms.Label emergencyContactNameLabel;
            System.Windows.Forms.Label emergencyContactPhoneLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label internalRemarksLabel;
            System.Windows.Forms.Label createdAtLabel;
            System.Windows.Forms.Label lastModifiedAtLabel;
            System.Windows.Forms.Label lastModifiedByLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrationParticipants));
            this.nhEventDataSet = new MiddleProject1.功能區塊.活動.nhEventDataSet();
            this.registrationParticipantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationParticipantsTableAdapter = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.RegistrationParticipantsTableAdapter();
            this.tableAdapterManager = new MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager();
            this.registrationParticipantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.registrationParticipantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registrationIDTextBox = new System.Windows.Forms.TextBox();
            this.companionIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nationalIDTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.otherRemarksTextBox = new System.Windows.Forms.TextBox();
            this.emergencyContactNameTextBox = new System.Windows.Forms.TextBox();
            this.emergencyContactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.internalRemarksTextBox = new System.Windows.Forms.TextBox();
            this.createdAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastModifiedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastModifiedByTextBox = new System.Windows.Forms.TextBox();
            registrationIDLabel = new System.Windows.Forms.Label();
            companionIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nationalIDLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            contactPhoneLabel = new System.Windows.Forms.Label();
            otherRemarksLabel = new System.Windows.Forms.Label();
            emergencyContactNameLabel = new System.Windows.Forms.Label();
            emergencyContactPhoneLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            internalRemarksLabel = new System.Windows.Forms.Label();
            createdAtLabel = new System.Windows.Forms.Label();
            lastModifiedAtLabel = new System.Windows.Forms.Label();
            lastModifiedByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationParticipantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationParticipantsBindingNavigator)).BeginInit();
            this.registrationParticipantsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationIDLabel
            // 
            registrationIDLabel.AutoSize = true;
            registrationIDLabel.Location = new System.Drawing.Point(253, 39);
            registrationIDLabel.Name = "registrationIDLabel";
            registrationIDLabel.Size = new System.Drawing.Size(72, 19);
            registrationIDLabel.TabIndex = 1;
            registrationIDLabel.Text = "報名編號:";
            // 
            // companionIDLabel
            // 
            companionIDLabel.AutoSize = true;
            companionIDLabel.Location = new System.Drawing.Point(253, 79);
            companionIDLabel.Name = "companionIDLabel";
            companionIDLabel.Size = new System.Drawing.Size(87, 19);
            companionIDLabel.TabIndex = 3;
            companionIDLabel.Text = "陪同者編號:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(253, 118);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(42, 19);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "姓名:";
            // 
            // nationalIDLabel
            // 
            nationalIDLabel.AutoSize = true;
            nationalIDLabel.Location = new System.Drawing.Point(253, 157);
            nationalIDLabel.Name = "nationalIDLabel";
            nationalIDLabel.Size = new System.Drawing.Size(87, 19);
            nationalIDLabel.TabIndex = 7;
            nationalIDLabel.Text = "身份證字號:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(253, 196);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(72, 19);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "電子郵件:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(253, 236);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(42, 19);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "地址:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(253, 275);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(42, 19);
            genderLabel.TabIndex = 13;
            genderLabel.Text = "性別:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(253, 315);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(42, 19);
            birthDateLabel.TabIndex = 15;
            birthDateLabel.Text = "生日:";
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new System.Drawing.Point(253, 353);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new System.Drawing.Size(72, 19);
            contactPhoneLabel.TabIndex = 17;
            contactPhoneLabel.Text = "連絡電話:";
            // 
            // otherRemarksLabel
            // 
            otherRemarksLabel.AutoSize = true;
            otherRemarksLabel.Location = new System.Drawing.Point(253, 393);
            otherRemarksLabel.Name = "otherRemarksLabel";
            otherRemarksLabel.Size = new System.Drawing.Size(72, 19);
            otherRemarksLabel.TabIndex = 19;
            otherRemarksLabel.Text = "其他備註:";
            // 
            // emergencyContactNameLabel
            // 
            emergencyContactNameLabel.AutoSize = true;
            emergencyContactNameLabel.Location = new System.Drawing.Point(253, 432);
            emergencyContactNameLabel.Name = "emergencyContactNameLabel";
            emergencyContactNameLabel.Size = new System.Drawing.Size(87, 19);
            emergencyContactNameLabel.TabIndex = 21;
            emergencyContactNameLabel.Text = "緊急連絡人:";
            // 
            // emergencyContactPhoneLabel
            // 
            emergencyContactPhoneLabel.AutoSize = true;
            emergencyContactPhoneLabel.Location = new System.Drawing.Point(253, 471);
            emergencyContactPhoneLabel.Name = "emergencyContactPhoneLabel";
            emergencyContactPhoneLabel.Size = new System.Drawing.Size(117, 19);
            emergencyContactPhoneLabel.TabIndex = 23;
            emergencyContactPhoneLabel.Text = "緊急連絡人電話:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(253, 510);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 19);
            statusLabel.TabIndex = 25;
            statusLabel.Text = "狀態:";
            // 
            // internalRemarksLabel
            // 
            internalRemarksLabel.AutoSize = true;
            internalRemarksLabel.Location = new System.Drawing.Point(253, 550);
            internalRemarksLabel.Name = "internalRemarksLabel";
            internalRemarksLabel.Size = new System.Drawing.Size(0, 19);
            internalRemarksLabel.TabIndex = 27;
            // 
            // createdAtLabel
            // 
            createdAtLabel.AutoSize = true;
            createdAtLabel.Location = new System.Drawing.Point(253, 590);
            createdAtLabel.Name = "createdAtLabel";
            createdAtLabel.Size = new System.Drawing.Size(0, 19);
            createdAtLabel.TabIndex = 29;
            // 
            // lastModifiedAtLabel
            // 
            lastModifiedAtLabel.AutoSize = true;
            lastModifiedAtLabel.Location = new System.Drawing.Point(253, 630);
            lastModifiedAtLabel.Name = "lastModifiedAtLabel";
            lastModifiedAtLabel.Size = new System.Drawing.Size(0, 19);
            lastModifiedAtLabel.TabIndex = 31;
            // 
            // lastModifiedByLabel
            // 
            lastModifiedByLabel.AutoSize = true;
            lastModifiedByLabel.Location = new System.Drawing.Point(253, 668);
            lastModifiedByLabel.Name = "lastModifiedByLabel";
            lastModifiedByLabel.Size = new System.Drawing.Size(0, 19);
            lastModifiedByLabel.TabIndex = 33;
            // 
            // nhEventDataSet
            // 
            this.nhEventDataSet.DataSetName = "nhEventDataSet";
            this.nhEventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationParticipantsBindingSource
            // 
            this.registrationParticipantsBindingSource.DataMember = "RegistrationParticipants";
            this.registrationParticipantsBindingSource.DataSource = this.nhEventDataSet;
            // 
            // registrationParticipantsTableAdapter
            // 
            this.registrationParticipantsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EventRecordsTableAdapter = null;
            this.tableAdapterManager.EventStatusTableAdapter = null;
            this.tableAdapterManager.RegistrationDetailsTableAdapter = null;
            this.tableAdapterManager.RegistrationParticipantsTableAdapter = this.registrationParticipantsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MiddleProject1.功能區塊.活動.nhEventDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registrationParticipantsBindingNavigator
            // 
            this.registrationParticipantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registrationParticipantsBindingNavigator.BindingSource = this.registrationParticipantsBindingSource;
            this.registrationParticipantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registrationParticipantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registrationParticipantsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registrationParticipantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registrationParticipantsBindingNavigatorSaveItem});
            this.registrationParticipantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registrationParticipantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registrationParticipantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registrationParticipantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registrationParticipantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registrationParticipantsBindingNavigator.Name = "registrationParticipantsBindingNavigator";
            this.registrationParticipantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registrationParticipantsBindingNavigator.Size = new System.Drawing.Size(900, 27);
            this.registrationParticipantsBindingNavigator.TabIndex = 0;
            this.registrationParticipantsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 27);
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
            // registrationParticipantsBindingNavigatorSaveItem
            // 
            this.registrationParticipantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registrationParticipantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registrationParticipantsBindingNavigatorSaveItem.Image")));
            this.registrationParticipantsBindingNavigatorSaveItem.Name = "registrationParticipantsBindingNavigatorSaveItem";
            this.registrationParticipantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.registrationParticipantsBindingNavigatorSaveItem.Text = "儲存資料";
            this.registrationParticipantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.registrationParticipantsBindingNavigatorSaveItem_Click_1);
            // 
            // registrationIDTextBox
            // 
            this.registrationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "RegistrationID", true));
            this.registrationIDTextBox.Location = new System.Drawing.Point(441, 35);
            this.registrationIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registrationIDTextBox.Name = "registrationIDTextBox";
            this.registrationIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.registrationIDTextBox.TabIndex = 2;
            // 
            // companionIDTextBox
            // 
            this.companionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "CompanionID", true));
            this.companionIDTextBox.Location = new System.Drawing.Point(441, 75);
            this.companionIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companionIDTextBox.Name = "companionIDTextBox";
            this.companionIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.companionIDTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(441, 114);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 27);
            this.nameTextBox.TabIndex = 6;
            // 
            // nationalIDTextBox
            // 
            this.nationalIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "NationalID", true));
            this.nationalIDTextBox.Location = new System.Drawing.Point(441, 153);
            this.nationalIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nationalIDTextBox.Name = "nationalIDTextBox";
            this.nationalIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.nationalIDTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(441, 193);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 27);
            this.emailTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(441, 232);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(224, 27);
            this.addressTextBox.TabIndex = 12;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(441, 271);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(224, 27);
            this.genderTextBox.TabIndex = 14;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationParticipantsBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(441, 310);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.birthDateDateTimePicker.TabIndex = 16;
            // 
            // contactPhoneTextBox
            // 
            this.contactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "ContactPhone", true));
            this.contactPhoneTextBox.Location = new System.Drawing.Point(441, 350);
            this.contactPhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactPhoneTextBox.Name = "contactPhoneTextBox";
            this.contactPhoneTextBox.Size = new System.Drawing.Size(224, 27);
            this.contactPhoneTextBox.TabIndex = 18;
            // 
            // otherRemarksTextBox
            // 
            this.otherRemarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "OtherRemarks", true));
            this.otherRemarksTextBox.Location = new System.Drawing.Point(441, 389);
            this.otherRemarksTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.otherRemarksTextBox.Name = "otherRemarksTextBox";
            this.otherRemarksTextBox.Size = new System.Drawing.Size(224, 27);
            this.otherRemarksTextBox.TabIndex = 20;
            // 
            // emergencyContactNameTextBox
            // 
            this.emergencyContactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "EmergencyContactName", true));
            this.emergencyContactNameTextBox.Location = new System.Drawing.Point(441, 428);
            this.emergencyContactNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emergencyContactNameTextBox.Name = "emergencyContactNameTextBox";
            this.emergencyContactNameTextBox.Size = new System.Drawing.Size(224, 27);
            this.emergencyContactNameTextBox.TabIndex = 22;
            // 
            // emergencyContactPhoneTextBox
            // 
            this.emergencyContactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "EmergencyContactPhone", true));
            this.emergencyContactPhoneTextBox.Location = new System.Drawing.Point(441, 467);
            this.emergencyContactPhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emergencyContactPhoneTextBox.Name = "emergencyContactPhoneTextBox";
            this.emergencyContactPhoneTextBox.Size = new System.Drawing.Size(224, 27);
            this.emergencyContactPhoneTextBox.TabIndex = 24;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(441, 507);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(224, 27);
            this.statusTextBox.TabIndex = 26;
            // 
            // internalRemarksTextBox
            // 
            this.internalRemarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "InternalRemarks", true));
            this.internalRemarksTextBox.Location = new System.Drawing.Point(12, 385);
            this.internalRemarksTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.internalRemarksTextBox.Name = "internalRemarksTextBox";
            this.internalRemarksTextBox.Size = new System.Drawing.Size(224, 27);
            this.internalRemarksTextBox.TabIndex = 28;
            // 
            // createdAtDateTimePicker
            // 
            this.createdAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationParticipantsBindingSource, "CreatedAt", true));
            this.createdAtDateTimePicker.Location = new System.Drawing.Point(12, 424);
            this.createdAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            this.createdAtDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.createdAtDateTimePicker.TabIndex = 30;
            // 
            // lastModifiedAtDateTimePicker
            // 
            this.lastModifiedAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationParticipantsBindingSource, "LastModifiedAt", true));
            this.lastModifiedAtDateTimePicker.Location = new System.Drawing.Point(12, 463);
            this.lastModifiedAtDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastModifiedAtDateTimePicker.Name = "lastModifiedAtDateTimePicker";
            this.lastModifiedAtDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.lastModifiedAtDateTimePicker.TabIndex = 32;
            // 
            // lastModifiedByTextBox
            // 
            this.lastModifiedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationParticipantsBindingSource, "LastModifiedBy", true));
            this.lastModifiedByTextBox.Location = new System.Drawing.Point(12, 503);
            this.lastModifiedByTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastModifiedByTextBox.Name = "lastModifiedByTextBox";
            this.lastModifiedByTextBox.Size = new System.Drawing.Size(224, 27);
            this.lastModifiedByTextBox.TabIndex = 34;
            // 
            // FrmRegistrationParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 746);
            this.Controls.Add(registrationIDLabel);
            this.Controls.Add(this.registrationIDTextBox);
            this.Controls.Add(companionIDLabel);
            this.Controls.Add(this.companionIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(nationalIDLabel);
            this.Controls.Add(this.nationalIDTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(contactPhoneLabel);
            this.Controls.Add(this.contactPhoneTextBox);
            this.Controls.Add(otherRemarksLabel);
            this.Controls.Add(this.otherRemarksTextBox);
            this.Controls.Add(emergencyContactNameLabel);
            this.Controls.Add(this.emergencyContactNameTextBox);
            this.Controls.Add(emergencyContactPhoneLabel);
            this.Controls.Add(this.emergencyContactPhoneTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(internalRemarksLabel);
            this.Controls.Add(this.internalRemarksTextBox);
            this.Controls.Add(createdAtLabel);
            this.Controls.Add(this.createdAtDateTimePicker);
            this.Controls.Add(lastModifiedAtLabel);
            this.Controls.Add(this.lastModifiedAtDateTimePicker);
            this.Controls.Add(lastModifiedByLabel);
            this.Controls.Add(this.lastModifiedByTextBox);
            this.Controls.Add(this.registrationParticipantsBindingNavigator);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegistrationParticipants";
            this.Text = "FrmRegistrationParticipants";
            this.Load += new System.EventHandler(this.FrmRegistrationParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhEventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationParticipantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationParticipantsBindingNavigator)).EndInit();
            this.registrationParticipantsBindingNavigator.ResumeLayout(false);
            this.registrationParticipantsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nhEventDataSet nhEventDataSet;
        private System.Windows.Forms.BindingSource registrationParticipantsBindingSource;
        private nhEventDataSetTableAdapters.RegistrationParticipantsTableAdapter registrationParticipantsTableAdapter;
        private nhEventDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registrationParticipantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registrationParticipantsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox registrationIDTextBox;
        private System.Windows.Forms.TextBox companionIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox nationalIDTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox contactPhoneTextBox;
        private System.Windows.Forms.TextBox otherRemarksTextBox;
        private System.Windows.Forms.TextBox emergencyContactNameTextBox;
        private System.Windows.Forms.TextBox emergencyContactPhoneTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox internalRemarksTextBox;
        private System.Windows.Forms.DateTimePicker createdAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastModifiedAtDateTimePicker;
        private System.Windows.Forms.TextBox lastModifiedByTextBox;
    }
}