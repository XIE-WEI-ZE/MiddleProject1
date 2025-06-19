using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MiddleProject1.功能區塊.健康;

namespace MiddleProject1.功能區塊.會員
{
    public partial class FrmMemberDetail : Form
    {
        private readonly int _memberId;
        private byte[] _profileImageBytes;

        public FrmMemberDetail(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
            uiRadioButtonYes.CheckedChanged += ToggleMoveOutDatePicker;
            uiRadioButtonNo.CheckedChanged += ToggleMoveOutDatePicker;
            this.FormClosing += FrmMemberDetail_FormClosing;
        }

        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {
            if (_memberId <= 0)
            {
                MessageBox.Show("會員編號錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            SetupMobilityComboBox();
            if (!LoadMemberData())
                return;

            ToggleMoveOutDatePicker(null, null);
            ToggleCareButtons(true);
        }

        private void SetupMobilityComboBox()
        {
            uiComboBox2.Items.Clear();
            uiComboBox2.Items.Add("需協助行走");
            uiComboBox2.Items.Add("可自行行走");
            uiComboBox2.Items.Add("癱瘓");
            uiComboBox2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
        }

        private bool LoadMemberData()
        {
            if (ConfigurationManager.ConnectionStrings["MyConnString"] == null)
            {
                MessageBox.Show("找不到資料庫連線設定！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string query = "SELECT * FROM Member WHERE MemberID = @MemberID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        cmd.Parameters[0].Value = _memberId;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("找不到該會員資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                return false;
                            }

                            uiTextBox1.Text = reader["MemberID"].ToString();
                            uiTextBox2.Text = reader["Name"].ToString();
                            uiTextBox6.Text = reader["Email"].ToString();
                            uiTextBox7.Text = reader["Username"].ToString();
                            uiRadioButtonBoy.Checked = reader["Gender"].ToString() == "男";
                            uiRadioButtonGirl.Checked = reader["Gender"].ToString() == "女";
                            dateTimePicker1.Value = reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? DateTime.Today : reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                            uiTextBox3.Text = reader.IsDBNull(reader.GetOrdinal("Height")) ? "" : reader["Height"].ToString();
                            uiTextBox4.Text = reader.IsDBNull(reader.GetOrdinal("Weight")) ? "" : reader["Weight"].ToString();
                            uiTextBox5.Text = reader["IDNumber"].ToString();

                            string mobility = reader["Mobility"].ToString().Trim();
                            uiComboBox2.SelectedIndex = uiComboBox2.Items.IndexOf(mobility);
                            if (uiComboBox2.SelectedIndex == -1) // 檢查 Mobility 是否有效
                            {
                                MessageBox.Show("行動能力資料無效，請聯繫管理員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                return false;
                            }

                            bool inCare = Convert.ToBoolean(reader["ResidesInCareHome"]);
                            uiRadioButtonYes.Checked = inCare;
                            uiRadioButtonNo.Checked = !inCare;

                            dateTimePicker2.Value = reader.IsDBNull(reader.GetOrdinal("CreatedDate")) ? DateTime.Today : reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                            dateTimePicker3.Value = reader.IsDBNull(reader.GetOrdinal("MoveInDate")) ? DateTime.Today : reader.GetDateTime(reader.GetOrdinal("MoveInDate"));
                            dateTimePicker4.Value = reader.IsDBNull(reader.GetOrdinal("MoveOutDate")) ? DateTime.Today : reader.GetDateTime(reader.GetOrdinal("MoveOutDate"));

                            if (reader["ProfilePicture"] != DBNull.Value)
                            {
                                _profileImageBytes = (byte[])reader["ProfilePicture"];
                                using (var ms = new MemoryStream(_profileImageBytes))
                                {
                                    pictureBox1.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pictureBox1.Image = null;
                                _profileImageBytes = null;
                            }
                        }
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"資料庫連線失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入會員資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }
        }

        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(uiTextBox2.Text))
            {
                errorMessage = "姓名不可為空！";
                return false;
            }

            if (string.IsNullOrWhiteSpace(uiTextBox7.Text) || !Regex.IsMatch(uiTextBox7.Text, @"^[a-zA-Z0-9]{3,20}$"))
            {
                errorMessage = "使用者名稱格式錯誤（應為 3-20 個字母或數字）！";
                return false;
            }

            if (uiRadioButtonNo.Checked && dateTimePicker4.Value < dateTimePicker3.Value)
            {
                errorMessage = "離院日期不可早於入院日期！";
                return false;
            }

            if (!Regex.IsMatch(uiTextBox6.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "請輸入正確的電子郵件格式（例如：example@domain.com）！";
                return false;
            }

            if (!string.IsNullOrEmpty(uiTextBox3.Text))
            {
                if (!decimal.TryParse(uiTextBox3.Text, out decimal height) || height < 50 || height > 250)
                {
                    errorMessage = "身高格式錯誤或超出範圍（50 至 250 公分）！";
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(uiTextBox4.Text))
            {
                if (!decimal.TryParse(uiTextBox4.Text, out decimal weight) || weight < 10 || weight > 300)
                {
                    errorMessage = "體重格式錯誤或超出範圍（10 至 300 公斤）！";
                    return false;
                }
            }

            if (!Regex.IsMatch(uiTextBox5.Text, @"^[A-Z][0-9]{9}$"))
            {
                errorMessage = "身份證號格式錯誤（應為 1 個大寫字母 + 9 個數字，例如：A123456789）！";
                return false;
            }

            if (uiComboBox2.SelectedItem == null)
            {
                errorMessage = "請選擇行動能力！";
                return false;
            }

            return true;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ConfigurationManager.ConnectionStrings["MyConnString"] == null)
            {
                MessageBox.Show("找不到資料庫連線設定！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string updateMemberSql = @"
                UPDATE Member SET
                    Name = @Name,
                    Gender = @Gender,
                    BirthDate = @BirthDate,
                    Height = @Height,
                    Weight = @Weight,
                    IDNumber = @IDNumber,
                    Mobility = @Mobility,
                    Email = @Email,
                    Username = @Username,
                    ResidesInCareHome = @ResidesInCareHome,
                    MoveInDate = @MoveInDate,
                    MoveOutDate = @MoveOutDate,
                    CreatedDate = @CreatedDate,
                    ProfilePicture = @ProfilePicture
                WHERE MemberID = @MemberID";
            string updateHealthRecordSql = @"
                UPDATE DailyHealthRecord
                SET Name = @Name
                WHERE MemberID = @MemberID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(updateMemberSql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiTextBox2.Text.Trim();
                        cmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiRadioButtonBoy.Checked ? "男" : "女";
                        cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.DateTime));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = dateTimePicker1.Value;
                        cmd.Parameters.Add(new SqlParameter("@Height", SqlDbType.Decimal));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = string.IsNullOrEmpty(uiTextBox3.Text) ? (object)DBNull.Value : Convert.ToDecimal(uiTextBox3.Text);
                        cmd.Parameters.Add(new SqlParameter("@Weight", SqlDbType.Decimal));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = string.IsNullOrEmpty(uiTextBox4.Text) ? (object)DBNull.Value : Convert.ToDecimal(uiTextBox4.Text);
                        cmd.Parameters.Add(new SqlParameter("@IDNumber", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiTextBox5.Text.Trim();
                        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiTextBox6.Text.Trim();
                        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiTextBox7.Text.Trim();
                        cmd.Parameters.Add(new SqlParameter("@Mobility", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiComboBox2.SelectedItem.ToString();
                        cmd.Parameters.Add(new SqlParameter("@ResidesInCareHome", SqlDbType.Bit));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiRadioButtonYes.Checked;
                        cmd.Parameters.Add(new SqlParameter("@MoveInDate", SqlDbType.DateTime));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = dateTimePicker3.Value;
                        cmd.Parameters.Add(new SqlParameter("@MoveOutDate", SqlDbType.DateTime));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiRadioButtonNo.Checked ? dateTimePicker4.Value : (object)DBNull.Value;
                        cmd.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = dateTimePicker2.Value;
                        cmd.Parameters.Add(new SqlParameter("@ProfilePicture", SqlDbType.VarBinary));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = _profileImageBytes ?? (object)DBNull.Value;
                        cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = _memberId;

                        if (cmd.ExecuteNonQuery() <= 0)
                        {
                            MessageBox.Show("會員資料儲存失敗，沒有資料被更新！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(updateHealthRecordSql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = uiTextBox2.Text.Trim();
                        cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = _memberId;
                        int healthRecordUpdated = cmd.ExecuteNonQuery();
                        if (healthRecordUpdated == 0)
                        {
                            MessageBox.Show("注意：健康紀錄未更新，可能尚未新增健康紀錄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    MessageBox.Show("儲存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("儲存失敗，請檢查資料庫連線或聯繫管理員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("儲存失敗，請檢查輸入資料或聯繫管理員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ToggleMoveOutDatePicker(object sender, EventArgs e)
        {
            dateTimePicker4.Enabled = uiRadioButtonNo.Checked;
            ToggleCareButtons(true);
        }

        private void ToggleCareButtons(bool enable)
        {
            bool isInCare = uiRadioButtonYes.Checked;
            uiButton1.Enabled = enable && isInCare;
            uiButton4.Enabled = enable && isInCare;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "選擇大頭貼";
                openFileDialog.Filter = "圖片檔 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _profileImageBytes = File.ReadAllBytes(openFileDialog.FileName);
                        if (_profileImageBytes.Length > 3 * 1024 * 1024)
                        {
                            MessageBox.Show("圖片大小超過 3MB，請選擇較小的圖片！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _profileImageBytes = null;
                            pictureBox1.Image = null;
                            return;
                        }
                        using (var ms = new MemoryStream(_profileImageBytes))
                        {
                            pictureBox1.Image?.Dispose();
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"無法讀取圖片：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBox1.Image = null;
                        _profileImageBytes = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"載入圖片失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBox1.Image = null;
                        _profileImageBytes = null;
                    }
                }
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmEmergencyContact(_memberId).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"無法開啟緊急聯絡人表單：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmAddHealthRecord(_memberId).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"無法開啟健康紀錄表單：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMemberDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}