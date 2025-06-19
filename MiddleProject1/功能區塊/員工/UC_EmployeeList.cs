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
    public partial class UC_EmployeeList : UserControl
    {
        public UC_EmployeeList()
        {
            InitializeComponent();

            // 基本屬性
            this.uiDataGridView1.AutoGenerateColumns = false;
            this.uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.MultiSelect = false;
            this.uiDataGridView1.ReadOnly = true;
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;

            // ✅ 字型設定（標題與內容）
            var font = new Font("微軟正黑體", 12F);
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);

            // 設定欄位（指定每欄字型）
            this.uiDataGridView1.Columns.Clear();

            this.uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeID",
                DataPropertyName = "EmployeeID",
                HeaderText = "員工編號",
                DefaultCellStyle = new DataGridViewCellStyle { Font = font }
            });

            this.uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DepartmentName",
                DataPropertyName = "DepartmentName",
                HeaderText = "部門",
                DefaultCellStyle = new DataGridViewCellStyle { Font = font }
            });

            this.uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "JobTitleName",
                DataPropertyName = "JobTitleName",
                HeaderText = "職位",
                DefaultCellStyle = new DataGridViewCellStyle { Font = font }
            });

            this.uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "姓名",
                DefaultCellStyle = new DataGridViewCellStyle { Font = font }
            });

            // 資料來源與事件
            this.employeeTableAdapter1.FillByEmployeeFull(this.nhEmployeeDataSet1.Employee);
            this.uiDataGridView1.DataSource = this.nhEmployeeDataSet1.Employee;

            this.uiDataGridView1.SelectionChanged += uiDataGridView1_SelectionChanged;

            if (uiDataGridView1.Rows.Count > 0)
            {
                uiDataGridView1.Rows[0].Selected = true;
                uiDataGridView1.CurrentCell = uiDataGridView1.Rows[0].Cells[0];
            }

            UpdateNavigationLabel();
        }

        private void UpdateNavigationLabel()
        {
            int currentIndex = GetCurrentRowIndex();
            int totalCount = uiDataGridView1.Rows.Count;

            if (currentIndex >= 0 && currentIndex < totalCount)
            {
                uiLabel1.Text = $"第 {currentIndex + 1} 筆 / 共 {totalCount} 筆";
            }
            else
            {
                uiLabel1.Text = $"第 0 筆 / 共 {totalCount} 筆";
            }
        }

        private int GetCurrentRowIndex()
        {
            return uiDataGridView1.CurrentRow?.Index ?? -1;
        }

        private void MoveToRow(int index)
        {
            if (index >= 0 && index < uiDataGridView1.Rows.Count)
            {
                uiDataGridView1.ClearSelection();
                uiDataGridView1.Rows[index].Selected = true;
                uiDataGridView1.CurrentCell = uiDataGridView1.Rows[index].Cells[0];
                UpdateNavigationLabel();
            }
        }

        private void uiDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateNavigationLabel();
        }

        private void uiButtonFullData_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];
                int employeeID = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
                FrmEmployeeViewFullData detailForm = new FrmEmployeeViewFullData(employeeID);
                detailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("請先選取一筆員工資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uiButtonFirstLine_Click(object sender, EventArgs e) => MoveToRow(0);

        private void uiButtonPrevious_Click(object sender, EventArgs e)
        {
            int currentIndex = GetCurrentRowIndex();
            if (currentIndex > 0)
                MoveToRow(currentIndex - 1);
        }

        private void uiButtonNext_Click(object sender, EventArgs e)
        {
            int currentIndex = GetCurrentRowIndex();
            if (currentIndex < uiDataGridView1.Rows.Count - 1)
                MoveToRow(currentIndex + 1);
        }

        private void uiButtonLast_Click(object sender, EventArgs e)
        {
            MoveToRow(uiDataGridView1.Rows.Count - 1);
        }

        private void uiButtonAddNewData_Click(object sender, EventArgs e)
        {
            FrmEmployeeAddNewOne addForm = new FrmEmployeeAddNewOne();
            addForm.ShowDialog();
        }

        private void uiButtonDeleteData_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選取一筆員工資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];
            int employeeID = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
            string employeeName = selectedRow.Cells["Name"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"確定要將員工「{employeeName}」標記為離職嗎？",
                "刪除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                var adapter = new NHEmployeeDataSetTableAdapters.EmployeeTableAdapter();
                adapter.UpdateEmploymentStatus("離職", employeeID);

                this.nhEmployeeDataSet1.Employee.Clear();
                this.employeeTableAdapter1.FillByEmployeeFull(this.nhEmployeeDataSet1.Employee);

                MessageBox.Show("已成功標記為離職", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("處理失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}