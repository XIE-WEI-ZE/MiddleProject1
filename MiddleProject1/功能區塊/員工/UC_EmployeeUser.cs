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
    public partial class UC_EmployeeUser : UserControl
    {
        public UC_EmployeeUser()
        {
            InitializeComponent();
        }

        private void uiButtonUserEditData_Click(object sender, EventArgs e)
        {
            int currentUserID = 1; // 這裡帶入目前使用者 ID
            FrmUserEditData editForm = new FrmUserEditData(currentUserID);
            editForm.ShowDialog(); 
        }

        private void uiButtonUserAttendanceCheck_Click(object sender, EventArgs e)
        {
            int currentUserID = 1; // 這裡帶入目前使用者 ID
            FrmUserAttendanceCheck editForm = new FrmUserAttendanceCheck(currentUserID);
            editForm.ShowDialog();
        }

        private void uiButtonUserSalaryCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
