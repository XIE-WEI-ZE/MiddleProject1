using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MiddleProject1.功能區塊.會員
{
    public partial class FrmAddHealthRecord : Form
    {
        private readonly int _memberId;
        private int? _editingHealthRecordId = null;
        private DateTime? _originalRecordDate = null;
        private string _originalCheckPeriod = null;

        public FrmAddHealthRecord(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
            this.Shown += FormAddHealthRecord_Shown;
        }

        private void FormAddHealthRecord_Shown(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                if (string.IsNullOrEmpty(connStr))
                {
                    throw new ConfigurationErrorsException("連線字串未配置");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"連線字串配置錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (!CheckMemberExists())
            {
                MessageBox.Show($"會員 ID {_memberId} 不存在，請確認會員資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            InitializeControls();
            LoadHealthRecords();
        }

        private bool CheckMemberExists()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string query = "SELECT COUNT(*) FROM Member WHERE MemberID = @MemberID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        cmd.Parameters[0].Value = _memberId;
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"檢查會員是否存在時失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void InitializeControls()
        {
            uiComboBox1.Items.Clear();
            uiComboBox1.Items.Add("早上");
            uiComboBox1.Items.Add("傍晚");
            uiComboBox1.DropDownStyle = UIDropDownStyle.DropDownList;
            uiComboBox1.SelectedIndex = -1;

            uiComboBox2.Items.Clear();
            uiComboBox2.Items.Add("正常");
            uiComboBox2.Items.Add("異常");
            uiComboBox2.DropDownStyle = UIDropDownStyle.DropDownList;
            uiComboBox2.SelectedIndex = -1;

            uiDatePicker1.MaxDate = DateTime.Today;

            if (uiDataGridView1.Columns.Count == 0)
            {
                uiDataGridView1.Columns.Add("HealthRecordID", "ID");
                uiDataGridView1.Columns["HealthRecordID"].Visible = false;

                uiDataGridView1.Columns.Add("RecordDate", "日期");
                uiDataGridView1.Columns.Add("BodyTemperature", "體溫");
                uiDataGridView1.Columns.Add("BloodPressure", "血壓");
                uiDataGridView1.Columns.Add("Pulse", "脈搏");
                uiDataGridView1.Columns.Add("Remark", "備註");
                uiDataGridView1.Columns.Add("IORecord", "I/O紀錄");
                uiDataGridView1.Columns.Add("CheckPeriod", "檢測時段");

                for (int i = 0; i < uiDataGridView1.Columns.Count; i++)
                {
                    uiDataGridView1.Columns[i].DataPropertyName = uiDataGridView1.Columns[i].Name;
                }
            }

            uiDataGridView1.CellValidating += uiDataGridView1_CellValidating;
            uiDataGridView1.CellEndEdit += uiDataGridView1_CellEndEdit;

            UpdateFormTitle();
        }

        private void LoadHealthRecords()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string query = @"
                SELECT HealthRecordID, RecordDate, BodyTemperature, BloodPressure, Pulse, Remark, IORecord, CheckPeriod
                FROM DailyHealthRecord
                WHERE MemberID = @MemberID
                ORDER BY RecordDate DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        cmd.Parameters[0].Value = _memberId;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                DataRow row = table.Rows[i];
                                if (row["IORecord"] == DBNull.Value)
                                {
                                    row["IORecord"] = "正常";
                                }
                                else
                                {
                                    string ioRecord = row["IORecord"].ToString().Trim();
                                    if (ioRecord != "正常" && ioRecord != "異常")
                                    {
                                        row["IORecord"] = "正常";
                                    }
                                }
                            }

                            uiDataGridView1.AutoGenerateColumns = false;
                            uiDataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入健康紀錄失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIfRecordExists(int healthRecordId)
        {
            if (healthRecordId <= 0)
            {
                MessageBox.Show("健康紀錄 ID 無效，無法檢查記錄", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string query = "SELECT COUNT(*) FROM DailyHealthRecord WHERE HealthRecordID = @HealthRecordID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@HealthRecordID", SqlDbType.Int));
                        cmd.Parameters[0].Value = healthRecordId;
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"檢查健康紀錄是否存在時失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckIfRecordDateExists(DateTime recordDate, string checkPeriod, int? excludeHealthRecordId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string query = @"
                SELECT COUNT(*) 
                FROM DailyHealthRecord 
                WHERE MemberID = @MemberID 
                AND RecordDate = @RecordDate 
                AND CheckPeriod = @CheckPeriod";

            if (excludeHealthRecordId.HasValue)
            {
                query += " AND HealthRecordID != @HealthRecordID";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                        cmd.Parameters[0].Value = _memberId;
                        cmd.Parameters.Add(new SqlParameter("@RecordDate", SqlDbType.Date));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = recordDate.Date;
                        cmd.Parameters.Add(new SqlParameter("@CheckPeriod", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = checkPeriod;
                        if (excludeHealthRecordId.HasValue)
                        {
                            cmd.Parameters.Add(new SqlParameter("@HealthRecordID", SqlDbType.Int));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = excludeHealthRecordId.Value;
                        }
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"檢查日期是否存在時失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = "";
            if (!decimal.TryParse(uiTextBox1.Text, out decimal temp) || temp < 35 || temp > 42)
            {
                errorMessage = "體溫必須介於 35.0 至 42.0";
                return false;
            }
            if (!int.TryParse(uiTextBox2.Text, out int bp) || bp <= 0 || bp < 50 || bp > 200)
            {
                errorMessage = "血壓必須介於 50 至 200，且為正數";
                return false;
            }
            if (!int.TryParse(uiTextBox3.Text, out int pulse) || pulse <= 0 || pulse < 30 || pulse > 200)
            {
                errorMessage = "脈搏必須介於 30 至 200，且為正數";
                return false;
            }
            if (uiComboBox1.SelectedIndex == -1)
            {
                errorMessage = "請選擇檢測時段（早上或傍晚）";
                return false;
            }
            if (uiComboBox2.SelectedIndex == -1)
            {
                errorMessage = "請選擇 I/O 紀錄（正常或異常）";
                return false;
            }
            return true;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string remark = uiTextBox4.Text.Trim();
            string ioRecord = uiComboBox2.SelectedItem.ToString();
            string checkPeriod = uiComboBox1.SelectedItem.ToString();
            DateTime recordDate = uiDatePicker1.Value.Date;

            bool dateChanged = _editingHealthRecordId.HasValue && _originalRecordDate.HasValue && _originalRecordDate.Value.Date != recordDate;
            bool periodChanged = _editingHealthRecordId.HasValue && _originalCheckPeriod != null && _originalCheckPeriod != checkPeriod;

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    if (_editingHealthRecordId.HasValue)
                    {
                        if (dateChanged || periodChanged)
                        {
                            if (CheckIfRecordDateExists(recordDate, checkPeriod, _editingHealthRecordId))
                            {
                                MessageBox.Show(
                                    $"日期 {recordDate:yyyy/MM/dd} 的「{checkPeriod}」記錄已存在，請選擇其他日期或時段",
                                    "記錄重複",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                return;
                            }
                        }

                        if (!CheckIfRecordExists(_editingHealthRecordId.Value))
                        {
                            MessageBox.Show(
                                $"健康紀錄 (ID: {_editingHealthRecordId.Value}) 已不存在，可能已被刪除。請重新載入資料。",
                                "記錄不存在",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            LoadHealthRecords();
                            ClearInputs();
                            return;
                        }
                    }
                    else
                    {
                        if (CheckIfRecordDateExists(recordDate, checkPeriod, null))
                        {
                            MessageBox.Show(
                                $"日期 {recordDate:yyyy/MM/dd} 的「{checkPeriod}」記錄已存在，請選擇其他日期或時段，或編輯現有記錄",
                                "記錄重複",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;

                        if (_editingHealthRecordId.HasValue)
                        {
                            cmd.CommandText = @"
                                UPDATE DailyHealthRecord SET
                                    RecordDate = @RecordDate,
                                    BodyTemperature = @BodyTemperature,
                                    BloodPressure = @BloodPressure,
                                    Pulse = @Pulse,
                                    Remark = @Remark,
                                    IORecord = @IORecord,
                                    CheckPeriod = @CheckPeriod
                                WHERE HealthRecordID = @HealthRecordID";

                            cmd.Parameters.Add(new SqlParameter("@HealthRecordID", SqlDbType.Int));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = _editingHealthRecordId.Value;
                            cmd.Parameters.Add(new SqlParameter("@RecordDate", SqlDbType.Date));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = recordDate;
                        }
                        else
                        {
                            cmd.CommandText = @"
                                INSERT INTO DailyHealthRecord 
                                (MemberID, Name, RecordDate, BodyTemperature, BloodPressure, Pulse, Remark, IORecord, CheckPeriod, CreatedDate)
                                VALUES
                                (@MemberID, (SELECT Name FROM Member WHERE MemberID = @MemberID),
                                 @RecordDate, @BodyTemperature, @BloodPressure, @Pulse, @Remark, @IORecord, @CheckPeriod, @CreatedDate)";

                            cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = _memberId;
                            cmd.Parameters.Add(new SqlParameter("@RecordDate", SqlDbType.Date));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = recordDate;
                            cmd.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = DateTime.Now;
                        }

                        cmd.Parameters.Add(new SqlParameter("@BodyTemperature", SqlDbType.Decimal));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = decimal.Parse(uiTextBox1.Text);
                        cmd.Parameters.Add(new SqlParameter("@BloodPressure", SqlDbType.Int));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = int.Parse(uiTextBox2.Text);
                        cmd.Parameters.Add(new SqlParameter("@Pulse", SqlDbType.Int));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = int.Parse(uiTextBox3.Text);
                        cmd.Parameters.Add(new SqlParameter("@Remark", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = string.IsNullOrWhiteSpace(remark) ? (object)DBNull.Value : remark;
                        cmd.Parameters.Add(new SqlParameter("@IORecord", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = ioRecord;
                        cmd.Parameters.Add(new SqlParameter("@CheckPeriod", SqlDbType.NVarChar));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = checkPeriod;

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show(_editingHealthRecordId.HasValue ? "紀錄已更新" : "健康紀錄新增成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadHealthRecords();
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show(
                                $"操作失敗，沒有資料被新增或更新。\n" +
                                $"HealthRecordID: {_editingHealthRecordId?.ToString() ?? "無"}, " +
                                $"MemberID: {_memberId}, " +
                                $"RecordDate: {recordDate:yyyy/MM/dd}, " +
                                $"CheckPeriod: {checkPeriod}\n" +
                                "請檢查資料庫結構或記錄是否已被刪除。",
                                "錯誤",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
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

        private void ClearInputs()
        {
            _editingHealthRecordId = null;
            _originalRecordDate = null;
            _originalCheckPeriod = null;
            uiTextBox1.Text = "";
            uiTextBox2.Text = "";
            uiTextBox3.Text = "";
            uiTextBox4.Text = "";
            uiComboBox1.SelectedIndex = -1;
            uiComboBox2.SelectedIndex = -1;
            uiDatePicker1.Value = DateTime.Today;
            UpdateFormTitle();
        }

        private void UpdateFormTitle()
        {
            this.Text = _editingHealthRecordId.HasValue ? "編輯健康紀錄" : "新增健康紀錄";
        }

        private void uiButtonNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
            MessageBox.Show("表單已清空，請輸入新資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];

                if (row.Cells["HealthRecordID"].Value == null || !int.TryParse(row.Cells["HealthRecordID"].Value.ToString(), out int healthRecordId) || healthRecordId <= 0)
                {
                    MessageBox.Show("選中的健康紀錄 ID 無效，請重新選擇", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                uiTextBox1.TextChanged -= uiTextBox1_TextChanged;
                uiTextBox2.TextChanged -= uiTextBox2_TextChanged;
                uiTextBox3.TextChanged -= uiTextBox3_TextChanged;

                _editingHealthRecordId = healthRecordId;

                _originalRecordDate = row.Cells["RecordDate"].Value != null && DateTime.TryParse(row.Cells["RecordDate"].Value.ToString(), out DateTime recordDate)
                    ? recordDate
                    : DateTime.Today;
                uiDatePicker1.Value = _originalRecordDate.Value;

                _originalCheckPeriod = row.Cells["CheckPeriod"].Value?.ToString();
                uiComboBox1.SelectedItem = string.IsNullOrEmpty(_originalCheckPeriod) ? null : _originalCheckPeriod;

                uiTextBox1.Text = row.Cells["BodyTemperature"].Value != null && decimal.TryParse(row.Cells["BodyTemperature"].Value.ToString(), out decimal temp)
                    ? temp.ToString("F1")
                    : "";

                uiTextBox2.Text = row.Cells["BloodPressure"].Value != null && int.TryParse(row.Cells["BloodPressure"].Value.ToString(), out int bp)
                    ? bp.ToString()
                    : "";

                uiTextBox3.Text = row.Cells["Pulse"].Value != null && int.TryParse(row.Cells["Pulse"].Value.ToString(), out int pulse)
                    ? pulse.ToString()
                    : "";

                uiTextBox4.Text = row.Cells["Remark"].Value?.ToString() ?? "";

                string ioRecord = row.Cells["IORecord"].Value?.ToString();
                uiComboBox2.SelectedItem = string.IsNullOrEmpty(ioRecord) ? null : ioRecord;

                UpdateFormTitle();

                uiTextBox1.TextChanged += uiTextBox1_TextChanged;
                uiTextBox2.TextChanged += uiTextBox2_TextChanged;
                uiTextBox3.TextChanged += uiTextBox3_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入健康紀錄失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputs();
            }
        }

        private void uiDataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = uiDataGridView1.Columns[e.ColumnIndex].Name;
            string newValue = e.FormattedValue?.ToString()?.Trim();

            if (string.IsNullOrEmpty(newValue)) return;

            if (columnName == "BodyTemperature")
            {
                if (!decimal.TryParse(newValue, out decimal temp) || temp < 35 || temp > 42)
                {
                    uiDataGridView1.Rows[e.RowIndex].ErrorText = "體溫必須介於 35.0 至 42.0";
                    e.Cancel = true;
                }
                else
                {
                    uiDataGridView1.Rows[e.RowIndex].ErrorText = "";
                }
            }
            else if (columnName == "Pulse")
            {
                if (!int.TryParse(newValue, out int pulse) || pulse < 30 || pulse > 200)
                {
                    uiDataGridView1.Rows[e.RowIndex].ErrorText = "脈搏必須介於 30 至 200";
                    e.Cancel = true;
                }
                else
                {
                    uiDataGridView1.Rows[e.RowIndex].ErrorText = "";
                }
            }
            else if (columnName == "BloodPressure")
            {
                if (!int.TryParse(newValue, out int bp) || bp < 50 || bp > 200)
                {
                    uiDataGridView1.Rows[e.RowIndex].ErrorText = "血壓必須介於 50 至 200";
                    e.Cancel = true;
                }
                else
                {
                    uiDataGridView1.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            if (row.Cells["HealthRecordID"].Value == null || !int.TryParse(row.Cells["HealthRecordID"].Value.ToString(), out int healthRecordId) || healthRecordId <= 0)
            {
                MessageBox.Show("健康紀錄 ID 無效，無法更新", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHealthRecords();
                return;
            }

            string columnName = uiDataGridView1.Columns[e.ColumnIndex].Name;
            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;

            DateTime recordDate;
            string checkPeriod;

            try
            {
                if (row.Cells["RecordDate"].Value == null || !DateTime.TryParse(row.Cells["RecordDate"].Value.ToString(), out recordDate))
                {
                    throw new InvalidOperationException("日期不能為空或格式錯誤");
                }
                checkPeriod = row.Cells["CheckPeriod"].Value?.ToString() ?? throw new InvalidOperationException("檢測時段不能為空");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"日期或時段資料格式錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHealthRecords();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    if (!CheckIfRecordExists(healthRecordId))
                    {
                        MessageBox.Show("此健康紀錄已不存在，請重新載入資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadHealthRecords();
                        return;
                    }

                    if (CheckIfRecordDateExists(recordDate, checkPeriod, healthRecordId))
                    {
                        MessageBox.Show(
                            $"日期 {recordDate:yyyy/MM/dd} 的「{checkPeriod}」記錄已存在，請選擇其他日期或時段",
                            "記錄重複",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        LoadHealthRecords();
                        return;
                    }

                    string query = "UPDATE DailyHealthRecord SET ";
                    bool hasUpdatedField = false;

                    if (columnName == "BodyTemperature")
                    {
                        query += "BodyTemperature = @BodyTemperature";
                        hasUpdatedField = true;
                    }
                    else if (columnName == "BloodPressure")
                    {
                        query += "BloodPressure = @BloodPressure";
                        hasUpdatedField = true;
                    }
                    else if (columnName == "Pulse")
                    {
                        query += "Pulse = @Pulse";
                        hasUpdatedField = true;
                    }
                    else if (columnName == "Remark")
                    {
                        query += "Remark = @Remark";
                        hasUpdatedField = true;
                    }
                    else if (columnName == "IORecord")
                    {
                        query += "IORecord = @IORecord";
                        hasUpdatedField = true;
                    }
                    else if (columnName == "CheckPeriod")
                    {
                        query += "CheckPeriod = @CheckPeriod";
                        hasUpdatedField = true;
                    }
                    else if (columnName == "RecordDate")
                    {
                        query += "RecordDate = @RecordDate";
                        hasUpdatedField = true;
                    }

                    if (!hasUpdatedField)
                    {
                        MessageBox.Show("未修改任何可更新的欄位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    query += " WHERE HealthRecordID = @HealthRecordID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@HealthRecordID", SqlDbType.Int));
                        cmd.Parameters[cmd.Parameters.Count - 1].Value = healthRecordId;

                        if (columnName == "BodyTemperature")
                        {
                            cmd.Parameters.Add(new SqlParameter("@BodyTemperature", SqlDbType.Decimal));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = Convert.ToDecimal(row.Cells["BodyTemperature"].Value);
                        }
                        else if (columnName == "BloodPressure")
                        {
                            cmd.Parameters.Add(new SqlParameter("@BloodPressure", SqlDbType.Int));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = Convert.ToInt32(row.Cells["BloodPressure"].Value);
                        }
                        else if (columnName == "Pulse")
                        {
                            cmd.Parameters.Add(new SqlParameter("@Pulse", SqlDbType.Int));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = Convert.ToInt32(row.Cells["Pulse"].Value);
                        }
                        else if (columnName == "Remark")
                        {
                            cmd.Parameters.Add(new SqlParameter("@Remark", SqlDbType.NVarChar));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = row.Cells["Remark"].Value?.ToString() ?? (object)DBNull.Value;
                        }
                        else if (columnName == "IORecord")
                        {
                            cmd.Parameters.Add(new SqlParameter("@IORecord", SqlDbType.NVarChar));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = row.Cells["IORecord"].Value?.ToString() ?? "正常";
                        }
                        else if (columnName == "CheckPeriod")
                        {
                            cmd.Parameters.Add(new SqlParameter("@CheckPeriod", SqlDbType.NVarChar));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = checkPeriod;
                        }
                        else if (columnName == "RecordDate")
                        {
                            cmd.Parameters.Add(new SqlParameter("@RecordDate", SqlDbType.Date));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = recordDate;
                        }

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("健康紀錄已更新", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadHealthRecords();
                        }
                        else
                        {
                            MessageBox.Show(
                                $"更新失敗，沒有資料被更新。\n" +
                                $"HealthRecordID: {healthRecordId}, " +
                                $"RecordDate: {recordDate:yyyy/MM/dd}, " +
                                $"CheckPeriod: {checkPeriod}\n" +
                                "請檢查資料庫結構或記錄是否已被刪除。",
                                "錯誤",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            LoadHealthRecords();
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("更新失敗，請檢查資料庫連線或聯繫管理員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHealthRecords();
            }
            catch (Exception)
            {
                MessageBox.Show("更新失敗，請檢查輸入資料或聯繫管理員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHealthRecords();
            }
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(uiTextBox1.Text, out decimal temp))
                uiTextBox1.BackColor = (temp < 35 || temp > 42) ? Color.LightPink : Color.White;
            else
                uiTextBox1.BackColor = string.IsNullOrEmpty(uiTextBox1.Text) ? Color.White : Color.LightPink;
        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(uiTextBox2.Text, out int bp))
                uiTextBox2.BackColor = (bp <= 0 || bp < 50 || bp > 200) ? Color.LightPink : Color.White;
            else
                uiTextBox2.BackColor = string.IsNullOrEmpty(uiTextBox2.Text) ? Color.White : Color.LightPink;
        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(uiTextBox3.Text, out int pulse))
                uiTextBox3.BackColor = (pulse <= 0 || pulse < 30 || pulse > 200) ? Color.LightPink : Color.White;
            else
                uiTextBox3.BackColor = string.IsNullOrEmpty(uiTextBox3.Text) ? Color.White : Color.LightPink;
        }

        private void uiTextBox4_TextChanged(object sender, EventArgs e) { }
        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void uiDatePicker1_ValueChanged(object sender, DateTime value) { }
        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.CurrentRow == null || uiDataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("請選擇要刪除的健康紀錄", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(uiDataGridView1.CurrentRow.Cells["HealthRecordID"].Value?.ToString(), out int healthRecordId) || healthRecordId <= 0)
            {
                MessageBox.Show("健康紀錄 ID 無效", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckIfRecordExists(healthRecordId))
            {
                MessageBox.Show("此健康紀錄已不存在，請重新載入資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHealthRecords();
                return;
            }

            if (MessageBox.Show("確定要刪除這筆健康紀錄嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string sql = "DELETE FROM DailyHealthRecord WHERE HealthRecordID = @HealthRecordID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@HealthRecordID", SqlDbType.Int));
                        cmd.Parameters[0].Value = healthRecordId;
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("健康紀錄已刪除", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadHealthRecords();
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("刪除失敗，沒有紀錄被刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadHealthRecords();
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("刪除失敗，請檢查資料庫連線或聯繫管理員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHealthRecords();
            }
            catch (Exception)
            {
                MessageBox.Show("刪除失敗，請檢查資料或聯繫管理員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadHealthRecords();
            }
        }
    }
}