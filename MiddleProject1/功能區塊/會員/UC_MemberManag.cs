using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MiddleProject1.功能區塊.健康;
using MiddleProject1.功能區塊.會員;

namespace MiddleProject1.功能區塊
{
    public partial class UC_MemberManag : UserControl
    {
        private DataTable _memberData = new DataTable();
        private readonly int _pageSize = 20;
        private int _currentPage = 1;
        private int _totalPages = 0;
        private bool _isOpeningForm = false;

        public UC_MemberManag()
        {
            InitializeComponent();

            uiDataGridView1.CellDoubleClick -= uiDataGridView1_CellDoubleClick;
            uiDataGridView1.CellDoubleClick += uiDataGridView1_CellDoubleClick;
            LoadMemberData();
        }

        private void LoadMemberData()
        {
            // 檢查連線字串是否存在
            if (ConfigurationManager.ConnectionStrings["MyConnString"] == null)
            {
                MessageBox.Show("找不到資料庫連線設定！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string query = "SELECT MemberID, Name, Gender, BirthDate, ResidesInCareHome FROM Member";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        _memberData.Clear();
                        adapter.Fill(_memberData);
                    }
                }

                _totalPages = (_memberData.Rows.Count + _pageSize - 1) / _pageSize;
                ShowPage(_currentPage);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"連線資料庫失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入會員資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPage(int page)
        {
            ShowPageInternal(page);
        }

        private void ShowPageInternal(int page)
        {
            // 處理空資料情況
            if (_memberData.Rows.Count == 0)
            {
                uiDataGridView1.DataSource = null;
                uiLabel1.Text = "無資料";
                return;
            }

            int startIndex = (page - 1) * _pageSize;
            int endIndex = Math.Min(startIndex + _pageSize, _memberData.Rows.Count);

            DataTable pageTable = _memberData.Clone();
            for (int i = startIndex; i < endIndex; i++)
            {
                pageTable.ImportRow(_memberData.Rows[i]);
            }

            uiDataGridView1.DataSource = pageTable;
            uiDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uiDataGridView1.ReadOnly = true;

            if (uiDataGridView1.Columns.Contains("MemberID"))
            {
                uiDataGridView1.Columns["MemberID"].Visible = false;
            }

            uiLabel1.Text = $"第 {_currentPage} 頁 / 共 {_totalPages} 頁";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            ShowPage(_currentPage);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                ShowPage(_currentPage);
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                ShowPage(_currentPage);
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            _currentPage = _totalPages;
            ShowPage(_currentPage);
        }

        //private void uiButton6_Click(object sender, EventArgs e)
        //{
        //    // 檢查連線字串是否存在
        //    if (ConfigurationManager.ConnectionStrings["MyConnString"] == null)
        //    {
        //        MessageBox.Show("找不到資料庫連線設定！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    string connStr = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connStr))
        //        {
        //            conn.Open();

        //            foreach (DataGridViewRow row in uiDataGridView1.Rows)
        //            {
        //                if (row.IsNewRow) continue;

        //                try
        //                {
        //                    if (row.Cells["MemberID"].Value == null ||
        //                        row.Cells["Name"].Value == null ||
        //                        row.Cells["Gender"].Value == null ||
        //                        row.Cells["BirthDate"].Value == null ||
        //                        row.Cells["ResidesInCareHome"].Value == null)
        //                    {
        //                        MessageBox.Show("資料欄位不完整，請檢查！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        return;
        //                    }

        //                    int memberId = Convert.ToInt32(row.Cells["MemberID"].Value);
        //                    string name = row.Cells["Name"].Value.ToString();
        //                    string gender = row.Cells["Gender"].Value.ToString();
        //                    DateTime birthDate;
        //                    if (!DateTime.TryParse(row.Cells["BirthDate"].Value.ToString(), out birthDate))
        //                    {
        //                        MessageBox.Show("生日格式錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        return;
        //                    }
        //                    bool residesInCare = Convert.ToBoolean(row.Cells["ResidesInCareHome"].Value);

        //                    DataRow originalRow = null;
        //                    foreach (DataRow dataRow in _memberData.Rows)
        //                    {
        //                        if (Convert.ToInt32(dataRow["MemberID"]) == memberId)
        //                        {
        //                            originalRow = dataRow;
        //                            break;
        //                        }
        //                    }

        //                    if (originalRow == null) continue;

        //                    bool needUpdate = false;
        //                    string updateSql = "UPDATE Member SET ";
        //                    int paramCount = 0;

        //                    // 計算需要幾個參數，最多可能有 4 個參數 (Name, Gender, BirthDate, ResidesInCareHome)
        //                    if (name != originalRow["Name"].ToString()) paramCount++;
        //                    if (gender != originalRow["Gender"].ToString()) paramCount++;
        //                    if (birthDate != Convert.ToDateTime(originalRow["BirthDate"])) paramCount++;
        //                    if (residesInCare != Convert.ToBoolean(originalRow["ResidesInCareHome"])) paramCount++;

        //                    // 加上 MemberID 參數
        //                    SqlParameter[] parameters = new SqlParameter[paramCount + 1];
        //                    int paramIndex = 0;

        //                    if (name != originalRow["Name"].ToString())
        //                    {
        //                        updateSql += "Name = @Name, ";
        //                        parameters[paramIndex] = new SqlParameter("@Name", name);
        //                        paramIndex++;
        //                        needUpdate = true;
        //                    }

        //                    if (gender != originalRow["Gender"].ToString())
        //                    {
        //                        updateSql += "Gender = @Gender, ";
        //                        parameters[paramIndex] = new SqlParameter("@Gender", gender);
        //                        paramIndex++;
        //                        needUpdate = true;
        //                    }

        //                    if (birthDate != Convert.ToDateTime(originalRow["BirthDate"]))
        //                    {
        //                        updateSql += "BirthDate = @BirthDate, ";
        //                        parameters[paramIndex] = new SqlParameter("@BirthDate", birthDate);
        //                        paramIndex++;
        //                        needUpdate = true;
        //                    }

        //                    if (residesInCare != Convert.ToBoolean(originalRow["ResidesInCareHome"]))
        //                    {
        //                        updateSql += "ResidesInCareHome = @ResidesInCareHome, ";
        //                        parameters[paramIndex] = new SqlParameter("@ResidesInCareHome", residesInCare);
        //                        paramIndex++;
        //                        needUpdate = true;
        //                    }

        //                    if (!needUpdate) continue;

        //                    // 移除最後的逗號並加上 WHERE
        //                    updateSql = updateSql.TrimEnd(',', ' ') + " WHERE MemberID = @MemberID";
        //                    parameters[paramIndex] = new SqlParameter("@MemberID", memberId);

        //                    using (SqlCommand cmd = new SqlCommand(updateSql, conn))
        //                    {
        //                        for (int i = 0; i < parameters.Length; i++)
        //                        {
        //                            cmd.Parameters.Add(parameters[i]);
        //                        }
        //                        cmd.ExecuteNonQuery();
        //                    }
        //                }
        //                catch (FormatException)
        //                {
        //                    MessageBox.Show("資料格式錯誤，請檢查輸入！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }
        //                catch (InvalidCastException)
        //                {
        //                    MessageBox.Show("資料類型錯誤，請檢查輸入！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }
        //            }
        //        }

        //        MessageBox.Show("儲存完成", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadMemberData();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show($"資料庫操作失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"儲存失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void uiDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_isOpeningForm || e.RowIndex < 0) return;

            _isOpeningForm = true;

            try
            {
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                if (row.Cells["MemberID"].Value == null) return;

                int memberId = Convert.ToInt32(row.Cells["MemberID"].Value);

                using (FrmMemberDetail detailForm = new FrmMemberDetail(memberId))
                {
                    if (detailForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMemberData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"無法開啟會員詳情：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isOpeningForm = false;
            }
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmDailyCare().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"無法開啟健康紀錄表單：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}