namespace MiddleProject1.功能區塊.床位
{
    partial class UC_RoomTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label memberIDLabel;
            System.Windows.Forms.Label roomNumberLabel;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label roomTypeLabel;
            System.Windows.Forms.Label bedCountLabel;
            System.Windows.Forms.Label roomImageLabel;
            System.Windows.Forms.Label roomPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RoomTable));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.roomTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.roomTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nursingHomeDataSet2 = new MiddleProject1.NhdsRoom();
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
            this.roomTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.bedCountTextBox = new System.Windows.Forms.TextBox();
            this.roomImagePictureBox = new System.Windows.Forms.PictureBox();
            this.roomPriceTextBox = new System.Windows.Forms.TextBox();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.roomTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.uiButton7 = new Sunny.UI.UIButton();
            this.uiButton8 = new Sunny.UI.UIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableTableAdapter = new MiddleProject1.NursingHomeDataSet2TableAdapters.RoomTableTableAdapter();
            this.tableAdapterManager = new MiddleProject1.NursingHomeDataSet2TableAdapters.TableAdapterManager();
            this.nursingHomeDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            memberIDLabel = new System.Windows.Forms.Label();
            roomNumberLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            roomTypeLabel = new System.Windows.Forms.Label();
            bedCountLabel = new System.Windows.Forms.Label();
            roomImageLabel = new System.Windows.Forms.Label();
            roomPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingNavigator)).BeginInit();
            this.roomTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursingHomeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursingHomeDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            memberIDLabel.Location = new System.Drawing.Point(17, 49);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(97, 25);
            memberIDLabel.TabIndex = 46;
            memberIDLabel.Text = "會員編號:";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            roomNumberLabel.Location = new System.Drawing.Point(17, 80);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new System.Drawing.Size(97, 25);
            roomNumberLabel.TabIndex = 48;
            roomNumberLabel.Text = "房間編號:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            roomNameLabel.Location = new System.Drawing.Point(17, 111);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(97, 25);
            roomNameLabel.TabIndex = 50;
            roomNameLabel.Text = "房間名稱:";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            roomTypeLabel.Location = new System.Drawing.Point(17, 144);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new System.Drawing.Size(97, 25);
            roomTypeLabel.TabIndex = 52;
            roomTypeLabel.Text = "房間房型:";
            // 
            // bedCountLabel
            // 
            bedCountLabel.AutoSize = true;
            bedCountLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            bedCountLabel.Location = new System.Drawing.Point(17, 172);
            bedCountLabel.Name = "bedCountLabel";
            bedCountLabel.Size = new System.Drawing.Size(97, 25);
            bedCountLabel.TabIndex = 54;
            bedCountLabel.Text = "房間床數:";
            // 
            // roomImageLabel
            // 
            roomImageLabel.AutoSize = true;
            roomImageLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            roomImageLabel.Location = new System.Drawing.Point(17, 322);
            roomImageLabel.Name = "roomImageLabel";
            roomImageLabel.Size = new System.Drawing.Size(97, 25);
            roomImageLabel.TabIndex = 56;
            roomImageLabel.Text = "房間照片:";
            // 
            // roomPriceLabel
            // 
            roomPriceLabel.AutoSize = true;
            roomPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            roomPriceLabel.Location = new System.Drawing.Point(17, 203);
            roomPriceLabel.Name = "roomPriceLabel";
            roomPriceLabel.Size = new System.Drawing.Size(97, 25);
            roomPriceLabel.TabIndex = 58;
            roomPriceLabel.Text = "房間價錢:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // roomTableBindingNavigator
            // 
            this.roomTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomTableBindingNavigator.BindingSource = this.roomTableBindingSource;
            this.roomTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.roomTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.roomTableBindingNavigatorSaveItem});
            this.roomTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roomTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomTableBindingNavigator.Name = "roomTableBindingNavigator";
            this.roomTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomTableBindingNavigator.Size = new System.Drawing.Size(1569, 31);
            this.roomTableBindingNavigator.TabIndex = 18;
            this.roomTableBindingNavigator.Text = "bindingNavigator1";
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
            // roomTableBindingSource
            // 
            this.roomTableBindingSource.DataMember = "RoomTable";
            this.roomTableBindingSource.DataSource = this.nursingHomeDataSet2;
            // 
            // nursingHomeDataSet2
            // 
            this.nursingHomeDataSet2.DataSetName = "NursingHomeDataSet2";
            this.nursingHomeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // roomTableBindingNavigatorSaveItem
            // 
            this.roomTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roomTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomTableBindingNavigatorSaveItem.Image")));
            this.roomTableBindingNavigatorSaveItem.Name = "roomTableBindingNavigatorSaveItem";
            this.roomTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.roomTableBindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1078, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "房間總表";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Location = new System.Drawing.Point(302, 542);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(96, 35);
            this.uiButton1.TabIndex = 33;
            this.uiButton1.Text = "新增圖片";
            this.uiButton1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Click += new System.EventHandler(this.btnAddRoomImage_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(507, 159);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 25);
            this.textBox3.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "房名搜索:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(670, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 25);
            this.textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(507, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 25);
            this.textBox1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "房間價格搜索:";
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Location = new System.Drawing.Point(1138, 107);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 42;
            this.uiButton2.Text = "背景調色";
            this.uiButton2.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Click += new System.EventHandler(this.btnChangeBackground_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 634);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1157, 133);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionChanged);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Items.AddRange(new object[] {
            " "});
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(629, 589);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(201, 29);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 45;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            this.uiComboBox1.Click += new System.EventHandler(this.btnRefreshRoomTable_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton3.Location = new System.Drawing.Point(302, 583);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(96, 35);
            this.uiButton3.TabIndex = 46;
            this.uiButton3.Text = "更新資料";
            this.uiButton3.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton3.Click += new System.EventHandler(this.btnUpdateListView_Click);
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "MemberID", true));
            this.memberIDTextBox.Location = new System.Drawing.Point(120, 49);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(147, 25);
            this.memberIDTextBox.TabIndex = 47;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "RoomNumber", true));
            this.roomNumberTextBox.Location = new System.Drawing.Point(120, 80);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(147, 25);
            this.roomNumberTextBox.TabIndex = 49;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "RoomName", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(120, 111);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(147, 25);
            this.roomNameTextBox.TabIndex = 51;
            // 
            // roomTypeCheckBox
            // 
            this.roomTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomTableBindingSource, "RoomType", true));
            this.roomTypeCheckBox.Location = new System.Drawing.Point(138, 145);
            this.roomTypeCheckBox.Name = "roomTypeCheckBox";
            this.roomTypeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.roomTypeCheckBox.TabIndex = 53;
            this.roomTypeCheckBox.Text = "多人套房";
            this.roomTypeCheckBox.UseVisualStyleBackColor = true;
            this.roomTypeCheckBox.CheckedChanged += new System.EventHandler(this.Checked);
            // 
            // bedCountTextBox
            // 
            this.bedCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "BedCount", true));
            this.bedCountTextBox.Location = new System.Drawing.Point(120, 172);
            this.bedCountTextBox.Name = "bedCountTextBox";
            this.bedCountTextBox.Size = new System.Drawing.Size(147, 25);
            this.bedCountTextBox.TabIndex = 55;
            // 
            // roomImagePictureBox
            // 
            this.roomImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.roomTableBindingSource, "RoomImage", true));
            this.roomImagePictureBox.Location = new System.Drawing.Point(3, 350);
            this.roomImagePictureBox.Name = "roomImagePictureBox";
            this.roomImagePictureBox.Size = new System.Drawing.Size(293, 278);
            this.roomImagePictureBox.TabIndex = 57;
            this.roomImagePictureBox.TabStop = false;
            // 
            // roomPriceTextBox
            // 
            this.roomPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTableBindingSource, "RoomPrice", true));
            this.roomPriceTextBox.Location = new System.Drawing.Point(120, 203);
            this.roomPriceTextBox.Name = "roomPriceTextBox";
            this.roomPriceTextBox.Size = new System.Drawing.Size(147, 25);
            this.roomPriceTextBox.TabIndex = 59;
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton4.Location = new System.Drawing.Point(22, 234);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(100, 35);
            this.uiButton4.TabIndex = 60;
            this.uiButton4.Text = "修改";
            this.uiButton4.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton4.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(836, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 41;
            this.button2.Text = "搜尋";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(836, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSearchByPrice_Click);
            // 
            // uiButton5
            // 
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton5.Location = new System.Drawing.Point(151, 234);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Size = new System.Drawing.Size(100, 35);
            this.uiButton5.TabIndex = 61;
            this.uiButton5.Text = "儲存";
            this.uiButton5.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton5.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // roomTableDataGridView
            // 
            this.roomTableDataGridView.AutoGenerateColumns = false;
            this.roomTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.RoomImage,
            this.dataGridViewTextBoxColumn5});
            this.roomTableDataGridView.DataSource = this.roomTableBindingSource;
            this.roomTableDataGridView.Location = new System.Drawing.Point(302, 197);
            this.roomTableDataGridView.Name = "roomTableDataGridView";
            this.roomTableDataGridView.RowHeadersWidth = 51;
            this.roomTableDataGridView.RowTemplate.Height = 27;
            this.roomTableDataGridView.Size = new System.Drawing.Size(1163, 339);
            this.roomTableDataGridView.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoomNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "RoomNumber";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoomName";
            this.dataGridViewTextBoxColumn3.HeaderText = "RoomName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "RoomType";
            this.dataGridViewCheckBoxColumn1.HeaderText = "RoomType";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BedCount";
            this.dataGridViewTextBoxColumn4.HeaderText = "BedCount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // RoomImage
            // 
            this.RoomImage.DataPropertyName = "RoomImage";
            this.RoomImage.HeaderText = "RoomImage";
            this.RoomImage.MinimumWidth = 6;
            this.RoomImage.Name = "RoomImage";
            this.RoomImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RoomImage.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RoomPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "RoomPrice";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // uiButton6
            // 
            this.uiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton6.Location = new System.Drawing.Point(1138, 155);
            this.uiButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton6.Name = "uiButton6";
            this.uiButton6.Size = new System.Drawing.Size(100, 35);
            this.uiButton6.TabIndex = 62;
            this.uiButton6.Text = "重新整理";
            this.uiButton6.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton6.Click += new System.EventHandler(this.btnRefreshRoomTable_Click);
            // 
            // uiButton7
            // 
            this.uiButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton7.Location = new System.Drawing.Point(151, 275);
            this.uiButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton7.Name = "uiButton7";
            this.uiButton7.Size = new System.Drawing.Size(100, 35);
            this.uiButton7.TabIndex = 63;
            this.uiButton7.Text = "刪除";
            this.uiButton7.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton7.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uiButton8
            // 
            this.uiButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton8.Location = new System.Drawing.Point(22, 275);
            this.uiButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton8.Name = "uiButton8";
            this.uiButton8.Size = new System.Drawing.Size(100, 35);
            this.uiButton8.TabIndex = 64;
            this.uiButton8.Text = "新增資料";
            this.uiButton8.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton8.Click += new System.EventHandler(this.btnAddNewRoom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(468, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "會員編號選單:";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = this.nursingHomeDataSet2;
            this.memberBindingSource.Position = 0;
            // 
            // roomTableTableAdapter
            // 
            this.roomTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyHealthRecordTableAdapter = null;
            this.tableAdapterManager.RoomBedTableTableAdapter = null;
            this.tableAdapterManager.RoomBillingDetailTableTableAdapter = null;
            this.tableAdapterManager.RoomBillingRecordTableTableAdapter = null;
            this.tableAdapterManager.RoomItemRequestTableTableAdapter = null;
            this.tableAdapterManager.RoomTableTableAdapter = this.roomTableTableAdapter;
            this.tableAdapterManager.ShopProductsTableAdapter = null;
            this.tableAdapterManager.StoreProductsTableAdapter = null;
            this.tableAdapterManager.TransferOrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MiddleProject1.NursingHomeDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nursingHomeDataSet2BindingSource
            // 
            this.nursingHomeDataSet2BindingSource.DataSource = this.nursingHomeDataSet2;
            this.nursingHomeDataSet2BindingSource.Position = 0;
            // 
            // UC_RoomTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiButton8);
            this.Controls.Add(this.uiButton7);
            this.Controls.Add(this.uiButton6);
            this.Controls.Add(this.roomTableDataGridView);
            this.Controls.Add(this.uiButton5);
            this.Controls.Add(this.uiButton4);
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
            this.Controls.Add(roomImageLabel);
            this.Controls.Add(this.roomImagePictureBox);
            this.Controls.Add(roomPriceLabel);
            this.Controls.Add(this.roomPriceTextBox);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomTableBindingNavigator);
            this.Name = "UC_RoomTable";
            this.Size = new System.Drawing.Size(1569, 991);
            this.Load += new System.EventHandler(this.RoomTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingNavigator)).EndInit();
            this.roomTableBindingNavigator.ResumeLayout(false);
            this.roomTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursingHomeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursingHomeDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NhdsRoom nursingHomeDataSet2;
        private System.Windows.Forms.BindingSource roomTableBindingSource;
        private NursingHomeDataSet2TableAdapters.RoomTableTableAdapter roomTableTableAdapter;
        private NursingHomeDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roomTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton roomTableBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Sunny.UI.UIButton uiButton2;
        private System.Windows.Forms.ListView listView1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton uiButton3;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.CheckBox roomTypeCheckBox;
        private System.Windows.Forms.TextBox bedCountTextBox;
        private System.Windows.Forms.PictureBox roomImagePictureBox;
        private System.Windows.Forms.TextBox roomPriceTextBox;
        private Sunny.UI.UIButton uiButton4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Sunny.UI.UIButton uiButton5;
        private System.Windows.Forms.BindingSource nursingHomeDataSet2BindingSource;
        private System.Windows.Forms.DataGridView roomTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn RoomImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UIButton uiButton7;
        private Sunny.UI.UIButton uiButton8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource memberBindingSource;
    }
}
