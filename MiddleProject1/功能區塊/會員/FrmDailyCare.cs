using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.健康
{
    public partial class FrmDailyCare : Form
    {
        private DataTable _healthRecords = new DataTable();
        private bool _isFirstLoad = true;

        public FrmDailyCare()
        {
            InitializeComponent();
        }

        private void FrmDailyCare_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            // 初始載入時顯示所有資料
            uiTextBoxName.Text = "";
            uiDatePickerDate.Value = DateTime.Today; // 開始日期設為今天
            uiDatePicker1.Value = DateTime.Today;    // 結束日期設為今天
            LoadHealthRecords("", null, null, false); // 不使用日期過濾，顯示所有資料

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ReadOnly = true;
            }

            SetEditableColumn("BodyTemperature");
            SetEditableColumn("BloodPressure");
            SetEditableColumn("Pulse");
            SetEditableColumn("Remark");
            SetEditableColumn("IORecord");
            SetEditableColumn("CheckPeriod");

            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
            dataGridView1.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridView1_CellValidating);

            _isFirstLoad = false;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 空的處理方法，避免資料錯誤時跳出預設錯誤訊息
        }

        private void SetEditableColumn(string columnName)
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.DataPropertyName == columnName || col.Name == columnName)
                {
                    col.ReadOnly = false;
                    return;
                }
            }
        }

        private void LoadHealthRecords(string nameFilter, DateTime? startDate, DateTime? endDate, bool filterByDateRange)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"] == null ? "" : ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            if (string.IsNullOrEmpty(connStr))
            {
                MessageBox.Show("找不到資料庫連線設定！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
                SELECT D.HealthRecordID, D.MemberID, M.Name, D.RecordDate, 
                       D.BodyTemperature, D.BloodPressure, D.Pulse, D.Remark, 
                       D.IORecord, D.CheckPeriod
                FROM DailyHealthRecord D
                JOIN Member M ON D.MemberID = M.MemberID
                WHERE 1 = 1";

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query += " AND M.Name LIKE @Name";
            }
            if (filterByDateRange && startDate.HasValue && endDate.HasValue)
            {
                query += " AND D.RecordDate BETWEEN @StartDate AND @EndDate";
            }

            query += " ORDER BY D.RecordDate DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(nameFilter))
                        {
                            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar));
                            cmd.Parameters[0].Value = "%" + nameFilter + "%";
                        }
                        if (filterByDateRange && startDate.HasValue && endDate.HasValue)
                        {
                            cmd.Parameters.Add(new SqlParameter("@StartDate", SqlDbType.DateTime));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = startDate.Value.Date;
                            cmd.Parameters.Add(new SqlParameter("@EndDate", SqlDbType.DateTime));
                            cmd.Parameters[cmd.Parameters.Count - 1].Value = endDate.Value.Date.AddDays(1).AddSeconds(-1); // 包含整天
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            _healthRecords.Clear();
                            adapter.Fill(_healthRecords);
                        }
                    }
                }

                for (int i = 0; i < _healthRecords.Rows.Count; i++)
                {
                    DataRow row = _healthRecords.Rows[i];
                    row["RecordDate"] = row["RecordDate"] == DBNull.Value ? DateTime.Today : row["RecordDate"];
                    row["BodyTemperature"] = row["BodyTemperature"] == DBNull.Value ? 0m : Convert.ToDecimal(row["BodyTemperature"]);
                    row["BloodPressure"] = row["BloodPressure"] == DBNull.Value ? 0 : Convert.ToInt32(row["BloodPressure"]);
                    row["Pulse"] = row["Pulse"] == DBNull.Value ? 0 : Convert.ToInt32(row["Pulse"]);
                    row["Remark"] = row["Remark"] == DBNull.Value ? "" : row["Remark"];
                    row["IORecord"] = row["IORecord"] == DBNull.Value ? "正常" : row["IORecord"].ToString().Trim();
                    row["CheckPeriod"] = row["CheckPeriod"] == DBNull.Value ? "" : row["CheckPeriod"];
                }

                dataGridView1.DataSource = _healthRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入健康紀錄失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterRecords(bool filterByDateRange = true, bool showNoRecordsMessage = true)
        {
            string nameFilter = uiTextBoxName.Text.Trim();
            DateTime? startDate = uiDatePickerDate.Value.Date; // 開始日期
            DateTime? endDate = uiDatePicker1.Value.Date;     // 結束日期

            // 檢查日期範圍是否有效
            if (filterByDateRange && startDate.HasValue && endDate.HasValue && startDate > endDate)
            {
                MessageBox.Show("開始日期不能晚於結束日期！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadHealthRecords(nameFilter, startDate, endDate, filterByDateRange);

            if (_healthRecords.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                if (showNoRecordsMessage && !_isFirstLoad)
                {
                    MessageBox.Show("目前無健康紀錄，請先新增資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            dataGridView1.DataSource = _healthRecords;
            if (_healthRecords.Rows.Count == 0 && showNoRecordsMessage)
            {
                MessageBox.Show("無符合條件的健康紀錄，請嘗試調整名稱或日期範圍，或點擊「顯示當天資料」按鈕！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].ReadOnly)
                return;

            string column = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            string newValue = e.FormattedValue == null ? "" : e.FormattedValue.ToString().Trim();

            if (string.IsNullOrEmpty(newValue)) return;

            if (column == "BodyTemperature")
            {
                decimal temp;
                if (!decimal.TryParse(newValue, out temp) || temp < 35 || temp > 42)
                {
                    ShowError("體溫格式錯誤或超出範圍（35.0 ~ 42.0）", e);
                }
            }
            else if (column == "BloodPressure")
            {
                int bp;
                if (!int.TryParse(newValue, out bp) || bp < 50 || bp > 200)
                {
                    ShowError("血壓格式錯誤或超出範圍（50 ~ 200）", e);
                }
            }
            else if (column == "Pulse")
            {
                int pulse;
                if (!int.TryParse(newValue, out pulse) || pulse < 30 || pulse > 200)
                {
                    ShowError("脈搏格式錯誤或超出範圍（30 ~ 200）", e);
                }
            }
            else if (column == "IORecord")
            {
                if (newValue != "正常" && newValue != "異常")
                {
                    ShowError("I/O 狀態僅限「正常」或「異常」", e);
                }
            }
            else if (column == "CheckPeriod")
            {
                if (newValue != "早上" && newValue != "傍晚")
                {
                    ShowError("檢測時段僅限「早上」或「傍晚」", e);
                }
            }
            else if (column == "Remark")
            {
                if (newValue.Length > 500)
                {
                    ShowError("備註長度不得超過 500 字！", e);
                }
            }
        }

        private void ShowError(string msg, DataGridViewCellValidatingEventArgs e)
        {
            MessageBox.Show(msg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void uiButtonSearch_Click_1(object sender, EventArgs e)
        {
            FilterRecords(true, true);
        }

        private void uiTextBoxName_TextChanged(object sender, EventArgs e)
        {
            // 移除即時觸發，使用者需點擊搜尋按鈕
        }

        //private void uiDatePickerDate_ValueChanged(object sender, EventArgs e)
        //{
        //    // 移除即時觸發，使用者需點擊搜尋按鈕
        //}

        //private void uiDatePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    // 移除即時觸發，使用者需點擊搜尋按鈕
        //}

        //private void uiButtonCancel_Click(object sender, EventArgs e)
        //{
        //    LoadHealthRecords("", null, null, false);
        //    dataGridView1.DataSource = _healthRecords;
        //    uiTextBoxName.Text = "";
        //    uiDatePickerDate.Value = DateTime.Today;
        //    uiDatePicker1.Value = DateTime.Today;
        //    MessageBox.Show("已還原所有編輯！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void uiButton3_Click(object sender, EventArgs e)
        {
            LoadHealthRecords("", null, null, false);
            dataGridView1.DataSource = _healthRecords;
            uiTextBoxName.Text = "";
            uiDatePickerDate.Value = DateTime.Today;
            uiDatePicker1.Value = DateTime.Today;
            MessageBox.Show("已顯示全部健康紀錄", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("請選擇要刪除的健康紀錄", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int recordId;
            if (!int.TryParse(dataGridView1.CurrentRow.Cells["HealthRecordID"].Value == null ? "" : dataGridView1.CurrentRow.Cells["HealthRecordID"].Value.ToString(), out recordId))
            {
                MessageBox.Show("健康紀錄 ID 無效", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("確定要刪除這筆紀錄嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DeleteRecord(recordId);
        }

        private void DeleteRecord(int recordId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"] == null ? "" : ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string sql = "DELETE FROM DailyHealthRecord WHERE HealthRecordID = @ID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
                        cmd.Parameters[0].Value = recordId;
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadHealthRecords("", null, null, false);
                dataGridView1.DataSource = _healthRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            if (_healthRecords.Rows.Count == 0)
            {
                MessageBox.Show("沒有可儲存的健康紀錄", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"] == null ? "" : ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string sql = @"
                UPDATE DailyHealthRecord 
                SET BodyTemperature = @Temperature,
                    BloodPressure = @BloodPressure,
                    Pulse = @Pulse,
                    Remark = @Remark,
                    IORecord = @IORecord,
                    CheckPeriod = @CheckPeriod,
                    RecordDate = @RecordDate
                WHERE HealthRecordID = @RecordID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    for (int i = 0; i < _healthRecords.Rows.Count; i++)
                    {
                        DataRow row = _healthRecords.Rows[i];
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.Add(new SqlParameter("@Temperature", row["BodyTemperature"]));
                            cmd.Parameters.Add(new SqlParameter("@BloodPressure", row["BloodPressure"]));
                            cmd.Parameters.Add(new SqlParameter("@Pulse", row["Pulse"]));
                            string remark = row["Remark"].ToString();
                            if (string.IsNullOrWhiteSpace(remark))
                            {
                                cmd.Parameters.Add(new SqlParameter("@Remark", DBNull.Value));
                            }
                            else
                            {
                                cmd.Parameters.Add(new SqlParameter("@Remark", remark));
                            }
                            cmd.Parameters.Add(new SqlParameter("@IORecord", row["IORecord"]));
                            string checkPeriod = row["CheckPeriod"].ToString();
                            if (string.IsNullOrWhiteSpace(checkPeriod))
                            {
                                cmd.Parameters.Add(new SqlParameter("@CheckPeriod", DBNull.Value));
                            }
                            else
                            {
                                cmd.Parameters.Add(new SqlParameter("@CheckPeriod", checkPeriod));
                            }
                            cmd.Parameters.Add(new SqlParameter("@RecordDate", row["RecordDate"]));
                            cmd.Parameters.Add(new SqlParameter("@RecordID", row["HealthRecordID"]));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("儲存成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHealthRecords("", null, null, false);
                dataGridView1.DataSource = _healthRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            // 顯示當天所有資料
            uiTextBoxName.Text = ""; // 清空名稱過濾條件
            uiDatePickerDate.Value = DateTime.Today;
            uiDatePicker1.Value = DateTime.Today;
            FilterRecords(true, true);
            if (_healthRecords.Rows.Count > 0)
            {
                MessageBox.Show($"已顯示 {DateTime.Today.ToString("yyyy-MM-dd")} 的健康紀錄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}