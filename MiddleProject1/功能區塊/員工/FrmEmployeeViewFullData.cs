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
    public partial class FrmEmployeeViewFullData : Form
    {
        private int _employeeID;

        public FrmEmployeeViewFullData(int employeeID)
        {
            InitializeComponent();
            _employeeID = employeeID;
            this.Load += FrmEmployeeViewFullData_Load;
        }

        private void FrmEmployeeViewFullData_Load(object sender, EventArgs e)
        {
            LoadDepartments();

            if (uiComboBox1.SelectedValue != null)
            {
                int selectedDeptID = (int)uiComboBox1.SelectedValue;
                LoadJobTitles(selectedDeptID);
            }

            uiComboBox1.SelectedIndexChanged += uiComboBox1_SelectedIndexChanged;
            InitComboBoxOptions();
            LoadEmployeeData();

            uiTextBox1.ReadOnly = true;
            uiTextBox8.ReadOnly = true;
        }

        private void InitComboBoxOptions()
        {
            uiComboBox3.Items.Clear();
            uiComboBox3.Items.AddRange(new string[] { "男", "女" });

            uiComboBox4.Items.Clear();
            uiComboBox4.Items.AddRange(new string[]
            {
                "國小", "國中", "高中", "大學", "碩士", "博士", "二技", "四技", "五專", "專科"
            });

            uiComboBox5.Items.Clear();
            uiComboBox5.Items.AddRange(new string[] { "有", "無" });

            uiComboBox6.Items.Clear();
            uiComboBox6.Items.AddRange(new string[] { "子女", "父母", "配偶", "祖父母", "孫子女" });
        }

        private void LoadDepartments()
        {
            var deptTable = new NHEmployeeDataSet.EmployeeDepartmentDataTable();
            var deptAdapter = new NHEmployeeDataSetTableAdapters.EmployeeDepartmentTableAdapter();
            deptAdapter.Fill(deptTable);

            uiComboBox1.DataSource = deptTable;
            uiComboBox1.DisplayMember = "DepartmentName";
            uiComboBox1.ValueMember = "DepartmentID";
        }

        private void LoadJobTitles(int departmentID)
        {
            var jobTable = new NHEmployeeDataSet.EmployeeJobTitleDataTable();
            var jobAdapter = new NHEmployeeDataSetTableAdapters.EmployeeJobTitleTableAdapter();
            jobAdapter.Fill(jobTable);

            var filteredJobs = jobTable.AsEnumerable()
                .Where(j => j.Field<int>("DepartmentID") == departmentID)
                .CopyToDataTable();

            uiComboBox2.DataSource = filteredJobs;
            uiComboBox2.DisplayMember = "JobName";
            uiComboBox2.ValueMember = "JobTitleID";
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedValue != null)
            {
                int selectedDeptID = (int)uiComboBox1.SelectedValue;
                LoadJobTitles(selectedDeptID);
            }
        }

        private void LoadEmployeeData()
        {
            var table = new NHEmployeeDataSet.EmployeeDataTable();
            var adapter = new NHEmployeeDataSetTableAdapters.EmployeeTableAdapter();
            adapter.FillByEmployeeID(table, _employeeID);

            if (table.Rows.Count > 0)
            {
                var row = table.Rows[0];
                uiTextBox1.Text = row["EmployeeID"].ToString();
                uiComboBox1.SelectedValue = row["DepartmentID"];
                uiComboBox2.SelectedValue = row["JobTitleID"];
                uiTextBox2.Text = row["Name"].ToString();
                uiComboBox3.Text = row["Gender"].ToString();
                uiTextBox3.Text = row["EmployeeIDNumber"].ToString();
                if (row["DateOfBirth"] != DBNull.Value)
                    uiDatePicker1.Value = Convert.ToDateTime(row["DateOfBirth"]);
                uiTextBox4.Text = row["MobileNumber"].ToString();
                uiTextBox5.Text = row["Email"].ToString();
                uiTextBox6.Text = row["CurrentAddress"].ToString();
                uiTextBox7.Text = row["RegisteredAddress"].ToString();
                if (row["DateOfHire"] != DBNull.Value)
                    uiDatePicker2.Value = Convert.ToDateTime(row["DateOfHire"]);

                if (row["DateOfHire"] != DBNull.Value)
                {
                    DateTime hireDate = Convert.ToDateTime(row["DateOfHire"]);
                    DateTime now = DateTime.Now;
                    int totalMonths = (now.Year - hireDate.Year) * 12 + (now.Month - hireDate.Month);
                    if (now.Day < hireDate.Day)
                        totalMonths--;
                    int years = totalMonths / 12;
                    int months = totalMonths % 12;
                    uiTextBox8.Text = $"{years}年{months}個月";
                }
                else
                {
                    uiTextBox8.Text = "無";
                }

                uiComboBox4.Text = row["EducationLevel"].ToString();
                uiTextBox9.Text = row["Height"].ToString();
                uiTextBox10.Text = row["Weight"].ToString();
                uiComboBox5.Text = (row["PoliceClearanceCertificate"] != DBNull.Value && (bool)row["PoliceClearanceCertificate"]) ? "有" : "無";
                uiTextBox11.Text = row["PayrollBankAccount"].ToString();
                uiTextBox12.Text = row["EmergencyContactPerson"].ToString();
                uiComboBox6.Text = row["EmergencyContactRelationship"].ToString();
                uiTextBox13.Text = row["EmergencyContactPhone"].ToString();
                uiCheckBoxIsAdmin.Checked = row["IsAdmin"] != DBNull.Value && (bool)row["IsAdmin"];
                uiCheckBoxIsSupervisor.Checked = row["IsSupervisor"] != DBNull.Value && (bool)row["IsSupervisor"];
            }
            else
            {
                MessageBox.Show("查無此員工資料！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void uiButtonSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                var adapter = new NHEmployeeDataSetTableAdapters.EmployeeTableAdapter();
                var table = new NHEmployeeDataSet.EmployeeDataTable();
                adapter.FillByEmployeeID(table, _employeeID);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("找不到員工資料，無法儲存！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var row = table[0];
                row["DepartmentID"] = uiComboBox1.SelectedValue;
                row["JobTitleID"] = uiComboBox2.SelectedValue;
                row["Name"] = uiTextBox2.Text.Trim();
                row["Gender"] = uiComboBox3.Text;
                row["EmployeeIDNumber"] = uiTextBox3.Text.Trim();
                row["DateOfBirth"] = uiDatePicker1.Value.Date;
                row["MobileNumber"] = uiTextBox4.Text.Trim();
                row["Email"] = uiTextBox5.Text.Trim();
                row["CurrentAddress"] = uiTextBox6.Text.Trim();
                row["RegisteredAddress"] = uiTextBox7.Text.Trim();
                row["DateOfHire"] = uiDatePicker2.Value.Date;
                row["EducationLevel"] = uiComboBox4.Text;
                row["Height"] = decimal.TryParse(uiTextBox9.Text, out decimal h) ? h : 0;
                row["Weight"] = decimal.TryParse(uiTextBox10.Text, out decimal w) ? w : 0;
                row["PoliceClearanceCertificate"] = uiComboBox5.Text == "有";
                row["PayrollBankAccount"] = uiTextBox11.Text.Trim();
                row["EmergencyContactPerson"] = uiTextBox12.Text.Trim();
                row["EmergencyContactRelationship"] = uiComboBox6.Text;
                row["EmergencyContactPhone"] = uiTextBox13.Text.Trim();
                row["IsAdmin"] = uiCheckBoxIsAdmin.Checked;
                row["IsSupervisor"] = uiCheckBoxIsSupervisor.Checked;

                adapter.Update(table);
                MessageBox.Show("儲存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
