using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.員工
{
    public partial class FrmUserAttendanceCheck : Form
    {
        private int _employeeID;

        public FrmUserAttendanceCheck(int employeeID)
        {
            InitializeComponent();
            _employeeID = employeeID;
            this.Load += FrmUserAttendanceCheck_Load;

            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.MultiSelect = false;
            uiDataGridView1.ReadOnly = true;
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
        }

        private void FrmUserAttendanceCheck_Load(object sender, EventArgs e)
        {
            uiComboBoxType.Items.AddRange(new string[] { "全部", "正常", "異常", "遲到", "加班", "遲到&加班" });
            uiComboBoxType.SelectedIndex = 0;

            uiTextBox1.Text = _employeeID.ToString();
            uiTextBox1.ReadOnly = true;
            uiTextBox2.ReadOnly = true;

            var employeeTable = new NHEmployeeDataSet.EmployeeDataTable();
            var adapter = new NHEmployeeDataSetTableAdapters.EmployeeTableAdapter();
            adapter.FillByEmployeeID(employeeTable, _employeeID);
            if (employeeTable.Rows.Count > 0)
            {
                uiTextBox2.Text = employeeTable[0]["Name"].ToString();
            }

            uiDatePickerStart.Value = DateTime.Today.AddDays(-7);
            uiDatePickerEnd.Value = DateTime.Today;
        }

        private void uiButtonQuery_Click(object sender, EventArgs e)
        {
            string type = uiComboBoxType.Text;
            DateTime start = uiDatePickerStart.Value.Date;
            DateTime end = uiDatePickerEnd.Value.Date;

            var allTable = new NHEmployeeDataSet.EmployeeDailyAttendanceDataTable();
            var adapter = new NHEmployeeDataSetTableAdapters.EmployeeDailyAttendanceTableAdapter();
            adapter.Fill(allTable);

            var filtered = allTable.AsEnumerable()
                .Where(row => row.Field<int>("EmployeeID") == _employeeID)
                .Where(row => row.Field<DateTime>("AttendanceDate") >= start && row.Field<DateTime>("AttendanceDate") <= end);

            if (type == "正常")
            {
                filtered = filtered.Where(row => TryGetInt(row["LateMinutes"]) == 0 && TryGetInt(row["OvertimeMinutes"]) == 0);
            }
            else if (type == "遲到")
            {
                filtered = filtered.Where(row => TryGetInt(row["LateMinutes"]) > 0 && TryGetInt(row["OvertimeMinutes"]) == 0);
            }
            else if (type == "加班")
            {
                filtered = filtered.Where(row => TryGetInt(row["LateMinutes"]) == 0 && TryGetInt(row["OvertimeMinutes"]) > 0);
            }
            else if (type == "遲到&加班")
            {
                filtered = filtered.Where(row => TryGetInt(row["LateMinutes"]) > 0 && TryGetInt(row["OvertimeMinutes"]) > 0);
            }
            else if (type == "異常")
            {
                filtered = filtered.Where(row => TryGetInt(row["LateMinutes"]) > 0 || TryGetInt(row["OvertimeMinutes"]) > 0);
            }

            // 清除之前的查無資料顯示
            uiDataGridView1.DataSource = null;
            uiDataGridView1.Rows.Clear();
            uiDataGridView1.Columns.Clear();

            if (filtered.Any())
            {
                var result = filtered.Select(row => new
                {
                    出勤日期 = row.Field<DateTime>("AttendanceDate").ToString("yyyy-MM-dd"),
                    班別 = row["ShiftID"].ToString(),
                    出勤狀況 = row["Status"].ToString(),
                    遲到分鐘 = row["LateMinutes"].ToString(),
                    加班分鐘 = row["OvertimeMinutes"].ToString()
                }).ToList();

                uiDataGridView1.DataSource = result;
            }
            else
            {
                DataTable noDataTable = new DataTable();
                noDataTable.Columns.Add("提示");
                var row = noDataTable.NewRow();
                row["提示"] = "查無資訊，請重新查詢";
                noDataTable.Rows.Add(row);

                uiDataGridView1.DataSource = noDataTable;
                uiDataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                uiDataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private int TryGetInt(object value)
        {
            return int.TryParse(value?.ToString(), out int result) ? result : 0;
        }

        private void uiButtonExceptionForm_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                var row = uiDataGridView1.SelectedRows[0];
                string status = row.Cells["出勤狀況"].Value?.ToString();

                if (status == "正常")
                {
                    MessageBox.Show("該筆出勤紀錄為正常，不需填寫異常申請單！", "提示");
                    return;
                }

                // 其餘欄位資料
                string shiftID = row.Cells["班別"].Value?.ToString();
                string lateMinutes = row.Cells["遲到分鐘"].Value?.ToString();
                string overtimeMinutes = row.Cells["加班分鐘"].Value?.ToString();

                int employeeID = int.Parse(uiTextBox1.Text);
                string employeeName = uiTextBox2.Text;

                FrmUserExceptionForm form = new FrmUserExceptionForm(
                    employeeID, employeeName, shiftID, status, lateMinutes, overtimeMinutes);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選取一筆資料行！", "提示");
            }
        }
    }
}