using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Sunny.UI;

namespace MiddleProject1.功能區塊.會員
{
    public partial class FrmEmergencyContact : Form
    {
        private int _memberId;

        public FrmEmergencyContact(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
            this.FormClosing += FrmEmergencyContact_FormClosing;
        }

        private void FormEmergencyContact_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings["MyConnString"] == null)
            {
                MessageBox.Show("找不到資料庫連線設定！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            uiComboBox1.Items.Clear();
            uiComboBox1.Items.Add("子女");
            uiComboBox1.Items.Add("配偶");
            uiComboBox1.Items.Add("兄弟姊妹");
            uiComboBox1.Items.Add("社會安置中心");
            uiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string query = @"
                SELECT TOP 1 * FROM EmergencyContact
                WHERE MemberID = @MemberID
                ORDER BY FamilyID DESC";

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
                            if (reader.Read())
                            {
                                uiTextBox1.Text = reader["Name"].ToString();
                                uiComboBox1.Text = reader["Relationship"].ToString();
                                uiTextBox3.Text = reader["PhoneNumber"].ToString();
                                uiTextBox4.Text = reader["ResidentialAddress"].ToString();
                            }
                            else
                            {
                                uiTextBox1.Text = "";
                                uiComboBox1.SelectedIndex = -1;
                                uiTextBox3.Text = "";
                                uiTextBox4.Text = "";
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"資料庫連線失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string name = uiTextBox1.Text.Trim();
            string relationship = uiComboBox1.Text.Trim();
            string phone = uiTextBox3.Text.Trim();
            string address = uiTextBox4.Text.Trim();

            // 資料驗證
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(relationship) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("請完整填寫姓名、關係與電話！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 移除破折號並驗證電話號碼
            phone = phone.Replace("-", ""); // 移除破折號
            if (!Regex.IsMatch(phone, @"^09\d{8}$") && !Regex.IsMatch(phone, @"^0[1-8]\d{8}$"))
            {
                MessageBox.Show("電話號碼格式錯誤（應為 09XX-XXX-XXX 或 10 位數字）！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (address.Length > 100)
            {
                MessageBox.Show("地址長度不得超過 100 個字！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (uiComboBox1.SelectedItem == null)
            {
                MessageBox.Show("請選擇有效的關係！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ConfigurationManager.ConnectionStrings["MyConnString"] == null)
            {
                MessageBox.Show("找不到資料庫連線設定！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    bool exists = false;

                    // 檢查是否已有資料
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM EmergencyContact WHERE MemberID = @MemberID", conn))
                    {
                        checkCmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        checkCmd.Parameters[0].Value = _memberId;
                        exists = (int)checkCmd.ExecuteScalar() > 0;
                    }

                    // 執行 INSERT 或 UPDATE
                    using (SqlCommand cmd = new SqlCommand("", conn))
                    {
                        if (exists)
                        {
                            cmd.CommandText = @"
                        UPDATE EmergencyContact SET
                            Name = @Name,
                            Relationship = @Relationship,
                            PhoneNumber = @PhoneNumber,
                            ResidentialAddress = @ResidentialAddress
                        WHERE MemberID = @MemberID";
                        }
                        else
                        {
                            cmd.CommandText = @"
                        INSERT INTO EmergencyContact (MemberID, Name, Gender, Relationship, PhoneNumber, ResidentialAddress)
                        VALUES (@MemberID, @Name, @Gender, @Relationship, @PhoneNumber, @ResidentialAddress)";
                            cmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Int));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = 1; // 硬編碼，建議改進
                        }

                        cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = _memberId;
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = name;
                        cmd.Parameters.Add(new SqlParameter("@Relationship", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = relationship;
                        cmd.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = phone;
                        cmd.Parameters.Add(new SqlParameter("@ResidentialAddress", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = address;

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("儲存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("儲存失敗，沒有資料被更新！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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

        private void FrmEmergencyContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}