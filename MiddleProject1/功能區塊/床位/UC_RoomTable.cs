using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleProject1.Properties;
using System.IO; 
using MiddleProject1.功能區塊.床位;

namespace MiddleProject1.功能區塊.床位
{
    public partial class UC_RoomTable : UserControl
    {
        DataTable productsTable = new DataTable();
        int maxRows = 100;
        private ImageList profileImageList = new ImageList();
        private Image defaultImage = null; // 用於顯示預設圖片

        public UC_RoomTable()
        {
            InitializeComponent();

            // 設置預設圖片
            defaultImage = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                g.Clear(Color.Gray);
                g.DrawString("無圖片", new Font("Arial", 10), Brushes.White, new PointF(20, 40));
            }

            // 綁定 CheckBox 與 RoomType 欄位
            try
            {
                roomTypeCheckBox.DataBindings.Add("Checked", roomTableBindingSource, "RoomType", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CheckBox 綁定失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("error.log", $"{DateTime.Now}: CheckBox 綁定失敗 - {ex.ToString()}\n");
            }

            // 載入資料
            try
            {
                this.roomTableTableAdapter.Fill(this.nursingHomeDataSet2.RoomTable);
                this.roomTableBindingSource.DataSource = this.nursingHomeDataSet2.RoomTable;
                File.AppendAllText("log.txt", $"{DateTime.Now}: 成功載入 RoomTable 資料，行數：{nursingHomeDataSet2.RoomTable.Rows.Count}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("error.log", $"{DateTime.Now}: 載入資料失敗 - {ex.ToString()}\n");
            }

            this.listView1.View = View.Details;
            profileImageList.ImageSize = new Size(64, 64);
            profileImageList.ColorDepth = ColorDepth.Depth32Bit;
            listView1.SmallImageList = profileImageList;
        }

        private void RoomTable_Load(object sender, EventArgs e)
        {


            File.AppendAllText("log.txt", $"{DateTime.Now}: RoomTable_Load 開始執行\n");
            roomTableBindingSource.PositionChanged += CheckUnsavedChangesBeforeNavigate;
            roomTableBindingSource.ListChanged += roomTableBindingSource_ListChanged;
            roomTableBindingSource.CurrentChanged += roomTableBindingSource_CurrentChanged;

            // 移除 roomPriceTextBox_TextChanged 事件，避免干擾 DataGridView 編輯
            // this.roomPriceTextBox.TextChanged += roomPriceTextBox_TextChanged;

            LoadMemberIDsToComboBox();
            CreateListViewColumnsFromRoomTable();
            InitializeManualRoomTableColumns();

            roomTableDataGridView.SelectionChanged += roomTableDataGridView_SelectionChanged;
            listView1.MouseClick += listView1_MouseClick;

            // 檢查是否有資料
            if (nursingHomeDataSet2.RoomTable.Rows.Count == 0)
            {
                MessageBox.Show("目前無房間資料，請新增資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.AppendAllText("log.txt", $"{DateTime.Now}: RoomTable 無資料\n");
                roomImagePictureBox.Image = defaultImage;
            }
            else
            {
                // 主動選中第一行
                if (roomTableDataGridView.Rows.Count > 0)
                {
                    roomTableDataGridView.Rows[0].Selected = true;
                    File.AppendAllText("log.txt", $"{DateTime.Now}: 表單載入時選中第一行\n");
                }
            }

            File.AppendAllText("log.txt", $"{DateTime.Now}: RoomTable_Load 執行結束\n");
        }

        private void InitializeManualRoomTableColumns()
        {
            roomTableDataGridView.AutoGenerateColumns = false;
            roomTableDataGridView.Columns.Clear();

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MemberID",
                HeaderText = "會員編號",
                Name = "MemberID"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomNumber",
                HeaderText = "房間編號",
                Name = "RoomNumber"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomName",
                HeaderText = "房間名稱",
                Name = "RoomName"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "RoomType",
                HeaderText = "房間房型",
                Name = "RoomType"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BedCount",
                HeaderText = "房間床數",
                Name = "BedCount"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomPrice",
                HeaderText = "房間價格",
                Name = "RoomPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "'NT$' #,0" }
            });

            roomTableDataGridView.Columns.Add(new DataGridViewImageColumn
            {
                HeaderText = "房間照片",
                Name = "RoomImage",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            roomTableDataGridView.CellFormatting += RoomTableDataGridView_CellFormatting;
        }

        private void RoomTableDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (roomTableDataGridView.Columns[e.ColumnIndex].Name == "RoomImage")
            {
                DataRowView row = roomTableDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView;

                if (row != null && row["RoomImage"] != DBNull.Value)
                {
                    byte[] imageBytes = row["RoomImage"] as byte[];

                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                e.Value = Image.FromStream(ms);
                                File.AppendAllText("log.txt", $"{DateTime.Now}: 房間照片欄位顯示成功 - 房號 {row["RoomNumber"]}\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            e.Value = defaultImage;
                            File.AppendAllText("error.log", $"{DateTime.Now}: 房間照片欄位顯示失敗 - 房號 {row["RoomNumber"]} - {ex.ToString()}\n");
                        }
                    }
                    else
                    {
                        e.Value = defaultImage;
                        File.AppendAllText("log.txt", $"{DateTime.Now}: 房間照片欄位為空 - 房號 {row["RoomNumber"]}\n");
                    }

                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = defaultImage;
                    e.FormattingApplied = true;
                }
            }
        }

        private void roomTableDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = roomTableDataGridView.CurrentRow != null;
            roomTypeCheckBox.Enabled = hasSelection;
            uiButton4.Enabled = hasSelection;
            uiButton7.Enabled = hasSelection;

            if (hasSelection && roomTableBindingSource.Current is DataRowView rowView)
            {
                try
                {
                    roomTypeCheckBox.CheckedChanged -= Checked;
                    roomTypeCheckBox.Checked = Convert.ToBoolean(rowView["RoomType"]);
                    roomTypeCheckBox.CheckedChanged += Checked;
                }
                catch
                {
                    roomTypeCheckBox.Checked = false;
                }
            }
            else
            {
                ClearPictureBoxImage();
                roomImagePictureBox.Image = defaultImage;
            }
        }

        private void roomTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView currentRow = roomTableBindingSource.Current as DataRowView;

            if (currentRow != null)
            {
                ClearPictureBoxImage();

                try
                {
                    if (currentRow.Row.Table.Columns.Contains("RoomImage") && currentRow["RoomImage"] != DBNull.Value)
                    {
                        byte[] imageBytes = currentRow["RoomImage"] as byte[];

                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                roomImagePictureBox.Image = Image.FromStream(ms);
                                File.AppendAllText("log.txt", $"{DateTime.Now}: roomImagePictureBox 圖片載入成功 - 房號 {currentRow["RoomNumber"]}\n");
                            }
                        }
                        else
                        {
                            roomImagePictureBox.Image = defaultImage;
                            File.AppendAllText("log.txt", $"{DateTime.Now}: roomImagePictureBox 圖片為空 - 房號 {currentRow["RoomNumber"]}\n");
                        }
                    }
                    else
                    {
                        roomImagePictureBox.Image = defaultImage;
                        File.AppendAllText("log.txt", $"{DateTime.Now}: roomImagePictureBox 圖片為 DBNull - 房號 {currentRow["RoomNumber"]}\n");
                    }
                }
                catch (Exception ex)
                {
                    roomImagePictureBox.Image = defaultImage;
                    File.AppendAllText("error.log", $"{DateTime.Now}: roomImagePictureBox 顯示圖片失敗 - 房號 {currentRow["RoomNumber"]} - {ex.ToString()}\n");
                }
            }
            else
            {
                ClearPictureBoxImage();
                roomImagePictureBox.Image = defaultImage;
                File.AppendAllText("log.txt", $"{DateTime.Now}: roomTableBindingSource.Current 為 null，未載入圖片\n");
            }
        }

        private readonly Dictionary<string, string> memberColumnHeaders = new Dictionary<string, string>
        {
            {"MemberID", "會員編號"},
            {"IDNumber", "身分證字號"},
            {"Name", "姓名"},
            {"Gender", "性別"},
            {"BirthDate", "出生日期"},
            {"Mobility", "行動力"},
            {"MedicalHistory", "病史"},
            {"MoveInDate", "入住日期"},
            {"DietaryHabit", "飲食習慣"},
            {"ResidesInCareHome", "是否住院"},
        };

        private void ClearPictureBoxImage()
        {
            if (roomImagePictureBox.Image != null && roomImagePictureBox.Image != defaultImage)
            {
                var oldImage = roomImagePictureBox.Image;
                roomImagePictureBox.Image = null;
                oldImage.Dispose();
            }
        }

        private void roomTableBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                uiButton5.Enabled = true;
            }
        }

        private bool isModified = false; //修改的方法判斷
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (roomTableDataGridView.CurrentRow == null)
            {
                MessageBox.Show("請先選取一筆房間資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roomTableDataGridView.EndEdit();
            roomTableBindingSource.EndEdit();

            DataRowView currentRow = (DataRowView)roomTableBindingSource.Current;
            if (currentRow == null) return;

            // 原始資料
            string oldRoomNumber = currentRow["RoomNumber"].ToString();
            string oldRoomName = currentRow["RoomName"].ToString();
            bool oldRoomType = Convert.ToBoolean(currentRow["RoomType"]);
            int oldBedCount = Convert.ToInt32(currentRow["BedCount"]);
            decimal oldRoomPrice = Convert.ToDecimal(currentRow["RoomPrice"]);

            // 使用 .Cells 的 EditedFormattedValue 取得目前使用者輸入值
            string newRoomNumber = roomTableDataGridView.CurrentRow.Cells["RoomNumber"].EditedFormattedValue?.ToString() ?? oldRoomNumber;
            string newRoomName = roomTableDataGridView.CurrentRow.Cells["RoomName"].EditedFormattedValue?.ToString() ?? oldRoomName;
            bool newRoomType = Convert.ToBoolean(roomTableDataGridView.CurrentRow.Cells["RoomType"].EditedFormattedValue);
            int newBedCount = int.TryParse(roomTableDataGridView.CurrentRow.Cells["BedCount"].EditedFormattedValue?.ToString(), out var count) ? count : oldBedCount;
            string rawPriceText = roomTableDataGridView.CurrentRow.Cells["RoomPrice"].EditedFormattedValue?.ToString().Replace("NT$", "").Replace(",", "").Trim() ?? oldRoomPrice.ToString();
            decimal newRoomPrice = decimal.TryParse(rawPriceText, out var price) ? price : oldRoomPrice;

            // 日誌記錄與比對判斷
            File.AppendAllText("log.txt", $"{DateTime.Now}: 房號 {oldRoomNumber} 檢查變更中\n");


            // 顯示確認視窗
            using (var confirmForm = new FrmConfirmationToRoomTable())
            {
                confirmForm.Message = "確定要儲存這筆修改嗎？";
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    currentRow["RoomNumber"] = newRoomNumber;
                    currentRow["RoomName"] = newRoomName;
                    currentRow["RoomType"] = newRoomType;
                    currentRow["BedCount"] = newBedCount;
                    currentRow["RoomPrice"] = newRoomPrice;

                    roomTableBindingSource.EndEdit();
                    isModified = true; // 設定已變更但尚未存檔
                    MessageBox.Show("資料已修改，尚未儲存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void CheckUnsavedChangesBeforeNavigate(object sender, EventArgs e)
        {
            if (isModified)
            {
                var result = MessageBox.Show("您有尚未儲存的變更，確定要切換資料？變更將會遺失。", "尚未儲存", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    // 還原位置
                    roomTableBindingSource.PositionChanged -= CheckUnsavedChangesBeforeNavigate;
                    roomTableBindingSource.Position = previousPosition;
                    roomTableBindingSource.PositionChanged += CheckUnsavedChangesBeforeNavigate;
                    return;
                }

                isModified = false; // 允許切換，但重置旗標
            }

            previousPosition = roomTableBindingSource.Position;
        }
        private int previousPosition = 0;


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                roomTableDataGridView.EndEdit();
                roomTableBindingSource.EndEdit();
                roomTableTableAdapter.Update(nursingHomeDataSet2.RoomTable);
                int rowsAffected = roomTableTableAdapter.Update(nursingHomeDataSet2.RoomTable);
                
                isModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message);
            }
        }


        private void Checked(object sender, EventArgs e)
        {
            if (roomTableBindingSource.Current is DataRowView rowView)
            {
                rowView["RoomType"] = roomTypeCheckBox.Checked;
                roomTableBindingSource.EndEdit();
            }
        }

        private void btnSearchByPrice_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    if (!decimal.TryParse(textBox1.Text.Trim(), out decimal minPrice))
                    {
                        MessageBox.Show("請輸入正確的最小價格！");
                        return;
                    }

                    if (!decimal.TryParse(textBox2.Text.Trim(), out decimal maxPrice))
                    {
                        MessageBox.Show("請輸入正確的最大價格！");
                        return;
                    }

                    if (minPrice > maxPrice)
                    {
                        MessageBox.Show("最小價格不可大於最大價格！");
                        return;
                    }

                    string query = "SELECT TOP (@limit) * FROM RoomTable WHERE RoomPrice BETWEEN @minPrice AND @maxPrice";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@minPrice", minPrice);
                    cmd.Parameters.AddWithValue("@maxPrice", maxPrice);
                    cmd.Parameters.AddWithValue("@limit", maxRows);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    productsTable.Clear();
                    adapter.Fill(productsTable);

                    this.roomTableBindingSource.DataSource = productsTable;
                    if (productsTable.Rows.Count == 0)
                        MessageBox.Show("查無資料");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤：" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: 房間價錢搜索失敗 - {ex.ToString()}\n");
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string keyword = textBox3.Text.Trim();
                    if (string.IsNullOrEmpty(keyword))
                    {
                        MessageBox.Show("請輸入關鍵字！");
                        return;
                    }

                    string query = @"
                SELECT TOP (@limit) *
                FROM RoomTable
                WHERE RoomName LIKE @kw    
                   OR MemberID LIKE @kw
                   OR RoomNumber LIKE @kw";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
                    cmd.Parameters.AddWithValue("@limit", maxRows);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    productsTable.Clear();
                    adapter.Fill(productsTable);

                    this.roomTableBindingSource.DataSource = productsTable;
                    if (productsTable.Rows.Count == 0)
                        MessageBox.Show("查無資料");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤：" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: 房間名子搜索失敗 - {ex.ToString()}\n");
            }
        }

        private void btnAddRoomImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                try
                {
                    // 檢查圖片格式
                    string extension = Path.GetExtension(imagePath).ToLower();
                    if (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".bmp")
                    {
                        MessageBox.Show("僅支援 JPG、JPEG、PNG 和 BMP 格式的圖片！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    File.AppendAllText("log.txt", $"{DateTime.Now}: 上傳圖片 - 檔案 {imagePath}，長度為 {imageBytes.Length} 位元組\n");

                    ClearPictureBoxImage();

                    roomImagePictureBox.Image = Image.FromFile(imagePath);

                    if (roomTableDataGridView.CurrentRow != null)
                    {
                        DataRowView rowView = (DataRowView)roomTableDataGridView.CurrentRow.DataBoundItem;
                        rowView["RoomImage"] = imageBytes;
                        roomTableBindingSource.EndEdit();
                        MessageBox.Show("圖片已上傳，請按儲存按鈕以更新資料庫！");
                    }
                    else
                    {
                        MessageBox.Show("請先選擇一筆房間資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("圖片上傳失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.AppendAllText("error.log", $"{DateTime.Now}: 圖片上傳失敗 - {ex.ToString()}\n");
                }
            }
            else
            {
                MessageBox.Show("已取消選擇圖片。");
            }
        }

        private void btnChangeBackground_Click(object sender, EventArgs e)
        {
            DialogResult result2 = this.colorDialog1.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                this.BackColor = this.colorDialog1.Color;
            }
        }

        private string CheckRelatedRecords(string roomNumber)
        {
            if (string.IsNullOrEmpty(roomNumber))
            {
                return "房號為空，無法檢查相關記錄！";
            }

            string connString = Settings.Default.NursingHomeConnectionString;
            string message = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // 檢查每張表是否有 RoomNumber 欄位前先查欄位存在與否
                    string[] relatedTables = { "RoomBedTable", "RoomBillingRecordTable" };

                    foreach (string table in relatedTables)
                    {
                        string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' AND COLUMN_NAME = 'RoomNumber'";
                        using (SqlCommand checkColCmd = new SqlCommand(query, conn))
                        {
                            int exists = (int)checkColCmd.ExecuteScalar();
                            if (exists == 0)
                            {
                                message += $"表格 {table} 中找不到欄位 RoomNumber；\n";
                                continue; // 跳過這張表
                            }
                        }

                        string countQuery = $"SELECT COUNT(*) FROM {table} WHERE RoomNumber = @roomNumber";
                        using (SqlCommand cmd = new SqlCommand(countQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                message += $"在 {table} 中有 {count} 筆關聯資料；\n";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string err = $"檢查房號 {roomNumber} 關聯資料失敗：{ex.Message}";
                File.AppendAllText("error.log", $"{DateTime.Now}: {err}\n");
                return err;
            }

            return message;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (roomTableDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選取要刪除的房間資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"確定要刪除這 {roomTableDataGridView.SelectedRows.Count} 筆房間資料嗎？",
                "確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in roomTableDataGridView.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView rowView)
                    {
                        rowView.Row.Delete(); // 標記為刪除
                    }
                }

                roomTableBindingSource.EndEdit();
                uiButton5.Enabled = true; // 啟用儲存按鈕
                MessageBox.Show("刪除成功，請點擊儲存以更新資料庫！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void LoadMemberIDsToComboBox()
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT MemberID FROM Member ORDER BY CAST(MemberID AS INT)", conn);
                    SqlDataReader reader = command.ExecuteReader();

                    uiComboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        uiComboBox1.Items.Add(reader["MemberID"].ToString());
                    }

                    if (uiComboBox1.Items.Count > 0)
                    {
                        uiComboBox1.SelectedIndex = 0;
                        comboBoxSelectionChanged(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ComboBox 載入失敗：" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: ComboBox 載入失敗 - {ex}\n");
            }
        }

        private void CreateListViewColumnsFromRoomTable()
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Member", conn);
                    SqlDataReader reader = command.ExecuteReader();

                    listView1.Columns.Clear();

                    string[] targetColumns = new string[]
                    {
                        "MemberID", "IDNumber", "Name", "Gender", "BirthDate",
                        "Mobility", "MedicalHistory", "MoveInDate", "DietaryHabit",
                        "ResidesInCareHome",
                    };

                    foreach (string column in targetColumns)
                    {
                        string headerText = memberColumnHeaders.ContainsKey(column) ? memberColumnHeaders[column] : column;
                        listView1.Columns.Add(headerText);
                    }

                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("建立 ListView 欄位失敗：" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: 建立 ListView 欄位失敗 - {ex.ToString()}\n");
            }
        }

        private void comboBoxSelectionChanged(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Member WHERE MemberID = @mid", conn);
                    command.Parameters.AddWithValue("@mid", uiComboBox1.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    listView1.BeginUpdate();
                    listView1.Items.Clear();

                    string[] targetColumns = new string[]
                    {
                        "MemberID", "IDNumber", "Name", "Gender", "BirthDate",
                        "Mobility", "MedicalHistory", "MoveInDate", "DietaryHabit",
                        "ResidesInCareHome",
                    };

                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader["MemberID"].ToString());
                        foreach (string col in targetColumns.Skip(1))
                        {
                            lvi.SubItems.Add(reader[col].ToString());
                        }
                        lvi.BackColor = (lvi.Index % 2 == 0) ? Color.LightGray : Color.LightGreen;
                        listView1.Items.Add(lvi);
                        if (reader["ProfilePicture"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["ProfilePicture"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                Image img = Image.FromStream(ms);

                                string memberId = reader["MemberID"].ToString();

                                if (!profileImageList.Images.ContainsKey(memberId))
                                {
                                    profileImageList.Images.Add(memberId, img);
                                }

                                lvi.ImageKey = memberId;
                            }
                        }
                    }

                    listView1.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查詢失敗：" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: 下拉選單查詢失敗 - {ex.ToString()}\n");
            }
        }

        private void btnUpdateListView_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NursingHomeConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Member WHERE MemberID = @mid", conn);
                    command.Parameters.AddWithValue("@mid", uiComboBox1.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    listView1.BeginUpdate();
                    listView1.Items.Clear();
                    profileImageList.Images.Clear();

                    string[] targetColumns = new string[]
                    {
                        "MemberID", "IDNumber", "Name", "Gender", "BirthDate",
                        "Mobility", "MedicalHistory", "MoveInDate", "DietaryHabit",
                        "ResidesInCareHome",
                    };

                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader["MemberID"].ToString());
                        foreach (string col in targetColumns.Skip(1))
                        {
                            lvi.SubItems.Add(reader[col].ToString());
                        }

                        if (reader["ProfilePicture"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["ProfilePicture"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                Image img = Image.FromStream(ms);
                                string key = reader["MemberID"].ToString();

                                if (!profileImageList.Images.ContainsKey(key))
                                {
                                    profileImageList.Images.Add(key, img);
                                }
                                lvi.ImageKey = key;
                            }
                        }

                        lvi.BackColor = (lvi.Index % 2 == 0) ? Color.LightGray : Color.LightGreen;
                        listView1.Items.Add(lvi);
                    }

                    listView1.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失敗：" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: 資料更新失敗 - {ex.ToString()}\n");
            }
        }

        private void btnRefreshRoomTable_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomTableBindingSource.DataSource = this.nursingHomeDataSet2.RoomTable;
                this.roomTableTableAdapter.Fill(this.nursingHomeDataSet2.RoomTable);
                this.roomTableBindingSource.ResetBindings(false);
                uiButton5.Enabled = false;
                ClearPictureBoxImage();

                if (roomTableDataGridView.CurrentRow != null)
                {
                    DataRowView rowView = (DataRowView)roomTableDataGridView.CurrentRow.DataBoundItem;
                    File.AppendAllText("log.txt", $"{DateTime.Now}: 刷新後房號 {rowView["RoomNumber"]} 的 RoomType 為 {rowView["RoomType"]}\n");
                    if (rowView.Row.Table.Columns.Contains("RoomImage") && rowView["RoomImage"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])rowView["RoomImage"];
                        File.AppendAllText("log.txt", $"{DateTime.Now}: 刷新後房號 {rowView["RoomNumber"]} 的 RoomImage 長度為 {imageBytes.Length} 位元組\n");
                    }
                    else
                    {
                        File.AppendAllText("log.txt", $"{DateTime.Now}: 刷新後房號 {rowView["RoomNumber"]} 的 RoomImage 為 DBNull\n");
                    }
                }

                MessageBox.Show("資料已重新整理！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("重新整理失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("error.log", $"{DateTime.Now}: 重新整理失敗 - {ex.ToString()}\n");
            }
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            using (FrmAddDateToRoomTable addForm = new FrmAddDateToRoomTable())
            {
                var result = addForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        DataRow newRow = nursingHomeDataSet2.RoomTable.NewRoomTableRow();

                        newRow["MemberID"] = addForm.MemberID;
                        newRow["RoomNumber"] = addForm.RoomNumber;
                        newRow["RoomName"] = addForm.RoomName;
                        newRow["RoomType"] = addForm.RoomType;
                        newRow["BedCount"] = addForm.BedCount;
                        newRow["RoomPrice"] = addForm.RoomPrice;

                        nursingHomeDataSet2.RoomTable.Rows.Add(newRow);
                        uiButton5.Enabled = true;

                        MessageBox.Show("資料已新增，請點擊儲存以同步到資料庫！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"新增資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        File.AppendAllText("error.log", $"{DateTime.Now}: 新增房間資料失敗 - {ex.ToString()}\n");
                    }
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = listView1.HitTest(e.Location);
            if (hit.Item != null)
            {
                int imageWidth = profileImageList.ImageSize.Width + 4;
                Rectangle itemBounds = hit.Item.Bounds;

                if (e.X >= itemBounds.Left && e.X <= itemBounds.Left + imageWidth)
                {
                    string memberId = hit.Item.Text;
                    if (profileImageList.Images.ContainsKey(memberId))
                    {
                        Image profileImg = profileImageList.Images[memberId];
                        using (FrmMemberImage imgForm = new FrmMemberImage(profileImg))
                        {
                            imgForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("此會員沒有圖片資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
