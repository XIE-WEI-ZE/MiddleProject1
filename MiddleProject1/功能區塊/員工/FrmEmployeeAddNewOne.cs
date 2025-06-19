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
    public partial class FrmEmployeeAddNewOne : Form
    {
        public FrmEmployeeAddNewOne()
        {
            InitializeComponent();
            this.Load += FrmEmployeeAddNewOne_Load;
            this.uiButtonSaveData.Click += uiButtonSaveData_Click;
            this.uiButtonCancel.Click += uiButtonCancel_Click;
        }

        private void FrmEmployeeAddNewOne_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            InitComboBoxOptions();

            uiComboBox1.SelectedIndexChanged += uiComboBox1_SelectedIndexChanged;
            uiTextBox1.ReadOnly = true;
            uiTextBox1.Text = "(系統自動產生)";
            uiTextBox8.ReadOnly = true;
            uiTextBox1.Text = "(系統自動產生)";
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

        private void InitComboBoxOptions()
        {
            // 性別
            uiComboBox3.Items.AddRange(new string[] { "男", "女" });

            // 學歷
            uiComboBox4.Items.AddRange(new string[]
            {
                "國小", "國中", "高中", "大學", "碩士", "博士", "二技", "四技", "五專", "專科"
            });

            // 良民證
            uiComboBox5.Items.AddRange(new string[] { "有", "無" });

            // 緊急連絡人關係
            uiComboBox6.Items.AddRange(new string[] { "子女", "父母", "配偶", "祖父母", "孫子女" });
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedValue != null)
            {
                int deptID = (int)uiComboBox1.SelectedValue;
                LoadJobTitles(deptID);
            }
        }

        private void uiButtonSaveData_Click(object sender, EventArgs e)
        {
            // ✅ 基本欄位是否為空檢查
            if (string.IsNullOrWhiteSpace(uiTextBox2.Text) || // 姓名
                string.IsNullOrWhiteSpace(uiTextBox3.Text) || // 身分證
                string.IsNullOrWhiteSpace(uiTextBox4.Text) || // 手機
                string.IsNullOrWhiteSpace(uiTextBox5.Text) || // Email
                string.IsNullOrWhiteSpace(uiTextBox6.Text) || // 現居地址
                string.IsNullOrWhiteSpace(uiTextBox7.Text) || // 戶籍地址
                string.IsNullOrWhiteSpace(uiTextBox9.Text) || // 身高
                string.IsNullOrWhiteSpace(uiTextBox10.Text) || // 體重
                string.IsNullOrWhiteSpace(uiTextBox11.Text) || // 銀行帳戶
                string.IsNullOrWhiteSpace(uiTextBox12.Text) || // 緊急聯絡人
                string.IsNullOrWhiteSpace(uiTextBox13.Text))   // 緊急聯絡電話
            {
                MessageBox.Show("請完整填寫所有欄位。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ 下拉式選單值驗證
            if (uiComboBox3.Text != "男" && uiComboBox3.Text != "女")
            {
                MessageBox.Show("性別欄位僅能選擇「男」或「女」。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (uiComboBox5.Text != "有" && uiComboBox5.Text != "無")
            {
                MessageBox.Show("良民證欄位僅能選擇「有」或「無」。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] allowedRelations = { "子女", "父母", "配偶", "祖父母", "孫子女" };
            if (!allowedRelations.Contains(uiComboBox6.Text))
            {
                MessageBox.Show("請選擇有效的緊急聯絡人關係。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(uiTextBox9.Text, out decimal height) || height <= 0)
            {
                MessageBox.Show("請填寫正確的員工身高（正數）。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(uiTextBox10.Text, out decimal weight) || weight <= 0)
            {
                MessageBox.Show("請填寫正確的員工體重（正數）。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ 資料寫入
            try
            {
                var adapter = new NHEmployeeDataSetTableAdapters.EmployeeTableAdapter();
                var table = new NHEmployeeDataSet.EmployeeDataTable();
                var newRow = table.NewEmployeeRow();

                newRow.DepartmentID = (int)uiComboBox1.SelectedValue;
                newRow.JobTitleID = (int)uiComboBox2.SelectedValue;
                newRow.Name = uiTextBox2.Text.Trim();
                newRow.Gender = uiComboBox3.Text;
                newRow.EmployeeIDNumber = uiTextBox3.Text.Trim();
                newRow.DateOfBirth = uiDatePicker1.Value.Date;
                newRow.MobileNumber = uiTextBox4.Text.Trim();
                newRow.Email = uiTextBox5.Text.Trim();
                newRow.CurrentAddress = uiTextBox6.Text.Trim();
                newRow.RegisteredAddress = uiTextBox7.Text.Trim();
                newRow.DateOfHire = uiDatePicker2.Value.Date;
                newRow.EducationLevel = uiComboBox4.Text;
                newRow.Height = height;
                newRow.Weight = weight;
                newRow.PoliceClearanceCertificate = uiComboBox5.Text == "有";
                newRow.PayrollBankAccount = uiTextBox11.Text.Trim();
                newRow.EmergencyContactPerson = uiTextBox12.Text.Trim();
                newRow.EmergencyContactRelationship = uiComboBox6.Text;
                newRow.EmergencyContactPhone = uiTextBox13.Text.Trim();

                // ✅ 預設值
                newRow.EmploymentStatus = "在職";
                newRow.IsAdmin = uiCheckBoxIsAdmin.Checked;
                newRow.IsSupervisor = uiCheckBoxIsSupervisor.Checked;

                table.Rows.Add(newRow);
                adapter.Update(table);

                MessageBox.Show("新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void uiButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // 不儲存資料直接關閉
        }
    }
}