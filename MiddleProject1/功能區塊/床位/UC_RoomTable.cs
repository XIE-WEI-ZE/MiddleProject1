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
using MiddleProject1.�\��϶�.�ɦ�;

namespace MiddleProject1.�\��϶�.�ɦ�
{
    public partial class UC_RoomTable : UserControl
    {
        DataTable productsTable = new DataTable();
        int maxRows = 100;
        private ImageList profileImageList = new ImageList();
        private Image defaultImage = null; // �Ω���ܹw�]�Ϥ�

        public UC_RoomTable()
        {
            InitializeComponent();

            // �]�m�w�]�Ϥ�
            defaultImage = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                g.Clear(Color.Gray);
                g.DrawString("�L�Ϥ�", new Font("Arial", 10), Brushes.White, new PointF(20, 40));
            }

            // �j�w CheckBox �P RoomType ���
            try
            {
                roomTypeCheckBox.DataBindings.Add("Checked", roomTableBindingSource, "RoomType", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CheckBox �j�w���ѡG{ex.Message}", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("error.log", $"{DateTime.Now}: CheckBox �j�w���� - {ex.ToString()}\n");
            }

            // ���J���
            try
            {
                this.roomTableTableAdapter.Fill(this.nursingHomeDataSet2.RoomTable);
                this.roomTableBindingSource.DataSource = this.nursingHomeDataSet2.RoomTable;
                File.AppendAllText("log.txt", $"{DateTime.Now}: ���\���J RoomTable ��ơA��ơG{nursingHomeDataSet2.RoomTable.Rows.Count}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���J��ƥ��ѡG{ex.Message}", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("error.log", $"{DateTime.Now}: ���J��ƥ��� - {ex.ToString()}\n");
            }

            this.listView1.View = View.Details;
            profileImageList.ImageSize = new Size(64, 64);
            profileImageList.ColorDepth = ColorDepth.Depth32Bit;
            listView1.SmallImageList = profileImageList;
        }

        private void RoomTable_Load(object sender, EventArgs e)
        {


            File.AppendAllText("log.txt", $"{DateTime.Now}: RoomTable_Load �}�l����\n");
            roomTableBindingSource.PositionChanged += CheckUnsavedChangesBeforeNavigate;
            roomTableBindingSource.ListChanged += roomTableBindingSource_ListChanged;
            roomTableBindingSource.CurrentChanged += roomTableBindingSource_CurrentChanged;

            // ���� roomPriceTextBox_TextChanged �ƥ�A�קK�z�Z DataGridView �s��
            // this.roomPriceTextBox.TextChanged += roomPriceTextBox_TextChanged;

            LoadMemberIDsToComboBox();
            CreateListViewColumnsFromRoomTable();
            InitializeManualRoomTableColumns();

            roomTableDataGridView.SelectionChanged += roomTableDataGridView_SelectionChanged;
            listView1.MouseClick += listView1_MouseClick;

            // �ˬd�O�_�����
            if (nursingHomeDataSet2.RoomTable.Rows.Count == 0)
            {
                MessageBox.Show("�ثe�L�ж���ơA�зs�W��ơI", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.AppendAllText("log.txt", $"{DateTime.Now}: RoomTable �L���\n");
                roomImagePictureBox.Image = defaultImage;
            }
            else
            {
                // �D�ʿ襤�Ĥ@��
                if (roomTableDataGridView.Rows.Count > 0)
                {
                    roomTableDataGridView.Rows[0].Selected = true;
                    File.AppendAllText("log.txt", $"{DateTime.Now}: �����J�ɿ襤�Ĥ@��\n");
                }
            }

            File.AppendAllText("log.txt", $"{DateTime.Now}: RoomTable_Load ���浲��\n");
        }

        private void InitializeManualRoomTableColumns()
        {
            roomTableDataGridView.AutoGenerateColumns = false;
            roomTableDataGridView.Columns.Clear();

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MemberID",
                HeaderText = "�|���s��",
                Name = "MemberID"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomNumber",
                HeaderText = "�ж��s��",
                Name = "RoomNumber"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomName",
                HeaderText = "�ж��W��",
                Name = "RoomName"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "RoomType",
                HeaderText = "�ж��Ы�",
                Name = "RoomType"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BedCount",
                HeaderText = "�ж��ɼ�",
                Name = "BedCount"
            });

            roomTableDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomPrice",
                HeaderText = "�ж�����",
                Name = "RoomPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "'NT$' #,0" }
            });

            roomTableDataGridView.Columns.Add(new DataGridViewImageColumn
            {
                HeaderText = "�ж��Ӥ�",
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
                                File.AppendAllText("log.txt", $"{DateTime.Now}: �ж��Ӥ������ܦ��\ - �и� {row["RoomNumber"]}\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            e.Value = defaultImage;
                            File.AppendAllText("error.log", $"{DateTime.Now}: �ж��Ӥ������ܥ��� - �и� {row["RoomNumber"]} - {ex.ToString()}\n");
                        }
                    }
                    else
                    {
                        e.Value = defaultImage;
                        File.AppendAllText("log.txt", $"{DateTime.Now}: �ж��Ӥ���쬰�� - �и� {row["RoomNumber"]}\n");
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
                                File.AppendAllText("log.txt", $"{DateTime.Now}: roomImagePictureBox �Ϥ����J���\ - �и� {currentRow["RoomNumber"]}\n");
                            }
                        }
                        else
                        {
                            roomImagePictureBox.Image = defaultImage;
                            File.AppendAllText("log.txt", $"{DateTime.Now}: roomImagePictureBox �Ϥ����� - �и� {currentRow["RoomNumber"]}\n");
                        }
                    }
                    else
                    {
                        roomImagePictureBox.Image = defaultImage;
                        File.AppendAllText("log.txt", $"{DateTime.Now}: roomImagePictureBox �Ϥ��� DBNull - �и� {currentRow["RoomNumber"]}\n");
                    }
                }
                catch (Exception ex)
                {
                    roomImagePictureBox.Image = defaultImage;
                    File.AppendAllText("error.log", $"{DateTime.Now}: roomImagePictureBox ��ܹϤ����� - �и� {currentRow["RoomNumber"]} - {ex.ToString()}\n");
                }
            }
            else
            {
                ClearPictureBoxImage();
                roomImagePictureBox.Image = defaultImage;
                File.AppendAllText("log.txt", $"{DateTime.Now}: roomTableBindingSource.Current �� null�A�����J�Ϥ�\n");
            }
        }

        private readonly Dictionary<string, string> memberColumnHeaders = new Dictionary<string, string>
        {
            {"MemberID", "�|���s��"},
            {"IDNumber", "�����Ҧr��"},
            {"Name", "�m�W"},
            {"Gender", "�ʧO"},
            {"BirthDate", "�X�ͤ��"},
            {"Mobility", "��ʤO"},
            {"MedicalHistory", "�f�v"},
            {"MoveInDate", "�J����"},
            {"DietaryHabit", "�����ߺD"},
            {"ResidesInCareHome", "�O�_��|"},
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

        private bool isModified = false; //�ק諸��k�P�_
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (roomTableDataGridView.CurrentRow == null)
            {
                MessageBox.Show("�Х�����@���ж���ơI", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roomTableDataGridView.EndEdit();
            roomTableBindingSource.EndEdit();

            DataRowView currentRow = (DataRowView)roomTableBindingSource.Current;
            if (currentRow == null) return;

            // ��l���
            string oldRoomNumber = currentRow["RoomNumber"].ToString();
            string oldRoomName = currentRow["RoomName"].ToString();
            bool oldRoomType = Convert.ToBoolean(currentRow["RoomType"]);
            int oldBedCount = Convert.ToInt32(currentRow["BedCount"]);
            decimal oldRoomPrice = Convert.ToDecimal(currentRow["RoomPrice"]);

            // �ϥ� .Cells �� EditedFormattedValue ���o�ثe�ϥΪ̿�J��
            string newRoomNumber = roomTableDataGridView.CurrentRow.Cells["RoomNumber"].EditedFormattedValue?.ToString() ?? oldRoomNumber;
            string newRoomName = roomTableDataGridView.CurrentRow.Cells["RoomName"].EditedFormattedValue?.ToString() ?? oldRoomName;
            bool newRoomType = Convert.ToBoolean(roomTableDataGridView.CurrentRow.Cells["RoomType"].EditedFormattedValue);
            int newBedCount = int.TryParse(roomTableDataGridView.CurrentRow.Cells["BedCount"].EditedFormattedValue?.ToString(), out var count) ? count : oldBedCount;
            string rawPriceText = roomTableDataGridView.CurrentRow.Cells["RoomPrice"].EditedFormattedValue?.ToString().Replace("NT$", "").Replace(",", "").Trim() ?? oldRoomPrice.ToString();
            decimal newRoomPrice = decimal.TryParse(rawPriceText, out var price) ? price : oldRoomPrice;

            // ��x�O���P���P�_
            File.AppendAllText("log.txt", $"{DateTime.Now}: �и� {oldRoomNumber} �ˬd�ܧ�\n");


            // ��ܽT�{����
            using (var confirmForm = new FrmConfirmationToRoomTable())
            {
                confirmForm.Message = "�T�w�n�x�s�o���ק�ܡH";
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    currentRow["RoomNumber"] = newRoomNumber;
                    currentRow["RoomName"] = newRoomName;
                    currentRow["RoomType"] = newRoomType;
                    currentRow["BedCount"] = newBedCount;
                    currentRow["RoomPrice"] = newRoomPrice;

                    roomTableBindingSource.EndEdit();
                    isModified = true; // �]�w�w�ܧ���|���s��
                    MessageBox.Show("��Ƥw�ק�A�|���x�s", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void CheckUnsavedChangesBeforeNavigate(object sender, EventArgs e)
        {
            if (isModified)
            {
                var result = MessageBox.Show("�z���|���x�s���ܧ�A�T�w�n������ơH�ܧ�N�|�򥢡C", "�|���x�s", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    // �٭��m
                    roomTableBindingSource.PositionChanged -= CheckUnsavedChangesBeforeNavigate;
                    roomTableBindingSource.Position = previousPosition;
                    roomTableBindingSource.PositionChanged += CheckUnsavedChangesBeforeNavigate;
                    return;
                }

                isModified = false; // ���\�����A�����m�X��
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
                MessageBox.Show("�x�s���ѡG" + ex.Message);
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
                        MessageBox.Show("�п�J���T���̤p����I");
                        return;
                    }

                    if (!decimal.TryParse(textBox2.Text.Trim(), out decimal maxPrice))
                    {
                        MessageBox.Show("�п�J���T���̤j����I");
                        return;
                    }

                    if (minPrice > maxPrice)
                    {
                        MessageBox.Show("�̤p���椣�i�j��̤j����I");
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
                        MessageBox.Show("�d�L���");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("���~�G" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: �ж������j������ - {ex.ToString()}\n");
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
                        MessageBox.Show("�п�J����r�I");
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
                        MessageBox.Show("�d�L���");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("���~�G" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: �ж��W�l�j������ - {ex.ToString()}\n");
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
                    // �ˬd�Ϥ��榡
                    string extension = Path.GetExtension(imagePath).ToLower();
                    if (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".bmp")
                    {
                        MessageBox.Show("�Ȥ䴩 JPG�BJPEG�BPNG �M BMP �榡���Ϥ��I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    File.AppendAllText("log.txt", $"{DateTime.Now}: �W�ǹϤ� - �ɮ� {imagePath}�A���׬� {imageBytes.Length} �줸��\n");

                    ClearPictureBoxImage();

                    roomImagePictureBox.Image = Image.FromFile(imagePath);

                    if (roomTableDataGridView.CurrentRow != null)
                    {
                        DataRowView rowView = (DataRowView)roomTableDataGridView.CurrentRow.DataBoundItem;
                        rowView["RoomImage"] = imageBytes;
                        roomTableBindingSource.EndEdit();
                        MessageBox.Show("�Ϥ��w�W�ǡA�Ы��x�s���s�H��s��Ʈw�I");
                    }
                    else
                    {
                        MessageBox.Show("�Х���ܤ@���ж���ơI", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�Ϥ��W�ǥ��ѡG" + ex.Message, "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.AppendAllText("error.log", $"{DateTime.Now}: �Ϥ��W�ǥ��� - {ex.ToString()}\n");
                }
            }
            else
            {
                MessageBox.Show("�w������ܹϤ��C");
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
                return "�и����šA�L�k�ˬd�����O���I";
            }

            string connString = Settings.Default.NursingHomeConnectionString;
            string message = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // �ˬd�C�i��O�_�� RoomNumber ���e���d���s�b�P�_
                    string[] relatedTables = { "RoomBedTable", "RoomBillingRecordTable" };

                    foreach (string table in relatedTables)
                    {
                        string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' AND COLUMN_NAME = 'RoomNumber'";
                        using (SqlCommand checkColCmd = new SqlCommand(query, conn))
                        {
                            int exists = (int)checkColCmd.ExecuteScalar();
                            if (exists == 0)
                            {
                                message += $"��� {table} ���䤣����� RoomNumber�F\n";
                                continue; // ���L�o�i��
                            }
                        }

                        string countQuery = $"SELECT COUNT(*) FROM {table} WHERE RoomNumber = @roomNumber";
                        using (SqlCommand cmd = new SqlCommand(countQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                message += $"�b {table} ���� {count} �����p��ơF\n";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string err = $"�ˬd�и� {roomNumber} ���p��ƥ��ѡG{ex.Message}";
                File.AppendAllText("error.log", $"{DateTime.Now}: {err}\n");
                return err;
            }

            return message;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (roomTableDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("�Х�����n�R�����ж���ơI", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"�T�w�n�R���o {roomTableDataGridView.SelectedRows.Count} ���ж���ƶܡH",
                "�T�{�R��",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in roomTableDataGridView.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView rowView)
                    {
                        rowView.Row.Delete(); // �аO���R��
                    }
                }

                roomTableBindingSource.EndEdit();
                uiButton5.Enabled = true; // �ҥ��x�s���s
                MessageBox.Show("�R�����\�A���I���x�s�H��s��Ʈw�I", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("ComboBox ���J���ѡG" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: ComboBox ���J���� - {ex}\n");
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
                MessageBox.Show("�إ� ListView ��쥢�ѡG" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: �إ� ListView ��쥢�� - {ex.ToString()}\n");
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
                MessageBox.Show("�d�ߥ��ѡG" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: �U�Կ��d�ߥ��� - {ex.ToString()}\n");
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
                MessageBox.Show("��s���ѡG" + ex.Message);
                File.AppendAllText("error.log", $"{DateTime.Now}: ��Ƨ�s���� - {ex.ToString()}\n");
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
                    File.AppendAllText("log.txt", $"{DateTime.Now}: ��s��и� {rowView["RoomNumber"]} �� RoomType �� {rowView["RoomType"]}\n");
                    if (rowView.Row.Table.Columns.Contains("RoomImage") && rowView["RoomImage"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])rowView["RoomImage"];
                        File.AppendAllText("log.txt", $"{DateTime.Now}: ��s��и� {rowView["RoomNumber"]} �� RoomImage ���׬� {imageBytes.Length} �줸��\n");
                    }
                    else
                    {
                        File.AppendAllText("log.txt", $"{DateTime.Now}: ��s��и� {rowView["RoomNumber"]} �� RoomImage �� DBNull\n");
                    }
                }

                MessageBox.Show("��Ƥw���s��z�I", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("���s��z���ѡG" + ex.Message, "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("error.log", $"{DateTime.Now}: ���s��z���� - {ex.ToString()}\n");
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

                        MessageBox.Show("��Ƥw�s�W�A���I���x�s�H�P�B���Ʈw�I", "���\", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"�s�W��ƥ��ѡG{ex.Message}", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        File.AppendAllText("error.log", $"{DateTime.Now}: �s�W�ж���ƥ��� - {ex.ToString()}\n");
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
                        MessageBox.Show("���|���S���Ϥ���ơI", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
