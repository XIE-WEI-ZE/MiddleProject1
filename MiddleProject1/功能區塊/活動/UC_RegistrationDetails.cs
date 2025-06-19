using MiddleProject1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.活動
{
    public partial class UC_RegistrationDetails : UserControl
    {
        private List<RegistrationDetailModel> registrationDetail = new List<RegistrationDetailModel>();//allevent
        private BindingSource bindingSource = new BindingSource();
        private int pageSize = 20;

        public UC_RegistrationDetails()
        {
            InitializeComponent();
            LoadAllRegistrationDetail();
            GetRegistrationDetailsColumnNames();
            dataGridView1.AllowUserToAddRows = false;//不讓新增
        }

        private void GetRegistrationDetailsColumnNames()
        {

            var columnMapping = new Dictionary<string, string>()
    {
        { "報名編號", "RegistrationID" },
        { "活動梯次", "EventBatchID" },
        { "活動名稱", "EventName" },
        { "會員編號", "MemberID" },
        { "會員名稱", "MemberName" },
        { "人數", "NumberOfPeople" },
        { "繳費狀態編號", "PaymentStatus" },
        { "繳費狀態", "PaymentStatusName" },
        { "需繳金額", "AmountDue" },
        { "報名時間", "RegistrationDateTime" },
        { "目前狀態編號", "CurrentStatus" },
        { "目前狀態", "CurrentStatusName" },
        { "備註", "InternalRemarks" },
        //{ "最後修改時間", "LastModifiedAt" },
        //{ "最後修改人員", "LastModifiedBy" }
    };

            comboBox1.DataSource = new BindingSource(columnMapping, null);
            comboBox1.DisplayMember = "Key";   // 顯示中文名稱
            comboBox1.ValueMember = "Value";   // 實際值為欄位英文名稱
        }



        private void LoadAllRegistrationDetail()
        {
            //select
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string value = textBox1.Text.Trim();
                    SqlCommand cmd;

                    cmd = new SqlCommand($"SELECT RegistrationID      ,EventBatchID  ,ed.EventName      ,r.MemberID  ,m.Name      ,NumberOfPeople      ,PaymentStatus  ,ps.StatusName as 繳費狀態      ,AmountDue      ,RegistrationDateTime      ,CurrentStatus  ,es.StatusName      ,InternalRemarks      ,r.LastModifiedAt      ,r.LastModifiedBy  FROM RegistrationDetails as r  join Member as m on m.MemberID=r.MemberID  join EventBatch as eb on eb.BatchID=r.EventBatchID  join EventDetails as ed  on ed.EventID=eb.EventID  join  EventStatus as es  on es.StatusID=CurrentStatus  JOIN EventStatus AS ps ON ps.StatusID = r.PaymentStatus ; ", conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    registrationDetail.Clear();
                    while (reader.Read())
                    {
                        registrationDetail.Add(new RegistrationDetailModel
                        {
                            RegistrationID = reader.GetInt32(0),
                            EventBatchID = reader.GetInt32(1),
                            EventName = reader.GetString(2),
                            MemberID = reader.GetInt32(3),
                            MemberName = reader.GetString(4),

                            NumberOfPeople = reader.GetInt32(5),
                            PaymentStatus = reader.GetInt32(6),
                            PaymentStatusName = reader.GetString(7),
                            AmountDue = reader.IsDBNull(8) ? (int?)null : reader.GetInt32(5),
                            RegistrationDateTime = reader.GetDateTime(9),
                            CurrentStatus = reader.GetInt32(10),
                            CurrentStatusName = reader.GetString(11),
                            InternalRemarks = reader.GetString(12),
                            //LastModifiedAt = reader.IsDBNull(13) ? (DateTime?)null : reader.GetDateTime(9),
                            //LastModifiedBy = reader.IsDBNull(14) ? (int?)null : reader.GetInt32(10),

                        });
                    }
                }
                SetupPagination();
                DisplayPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DisplayPage()
        {
            int pageIndex = bindingSource.Position;
            int start = pageIndex * pageSize;
            var currentPage = registrationDetail.Skip(start).Take(pageSize).ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 加入欄位
            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.HeaderText = "";
            editLink.Text = "修改";
            editLink.UseColumnTextForLinkValue = true;

            //欄位名稱
            dataGridView1.Columns.Add("RegistrationID", "報名編號");
            dataGridView1.Columns.Add("EventBatchID", "活動梯次");
            dataGridView1.Columns.Add("EventName", "活動名稱");
            //dataGridView1.Columns.Add("MemberID", "會員編號");
            dataGridView1.Columns.Add("MemberName", "會員名稱");
            dataGridView1.Columns.Add("NumberOfPeople", "人數");
            //dataGridView1.Columns.Add("PaymentStatus", "繳費狀態編號");
            dataGridView1.Columns.Add("PaymentStatusName", "繳費狀態");
            dataGridView1.Columns.Add("AmountDue", "需繳金額");
            dataGridView1.Columns.Add("RegistrationDateTime", "報名時間");
            //dataGridView1.Columns.Add("CurrentStatus", "目前狀態編號");
            dataGridView1.Columns.Add("CurrentStatusName", "目前狀態");
            dataGridView1.Columns.Add("InternalRemarks", "備註");
            //dataGridView1.Columns.Add("LastModifiedAt", "最後修改時間");
            //dataGridView1.Columns.Add("LastModifiedBy", "最後修改人員");
            dataGridView1.Columns.Add(editLink);

            foreach (var item in currentPage)
            {
                dataGridView1.Rows.Add(  //內容
                    item.RegistrationID,
            item.EventBatchID,
            item.EventName,
            item.MemberID+item.MemberName,
            item.NumberOfPeople,
            item.PaymentStatus+item.PaymentStatusName,
            item.AmountDue,
            item.RegistrationDateTime.ToString("yyyy-MM-dd HH:mm"),
            item.CurrentStatus+ item.CurrentStatusName,
            item.InternalRemarks,
            //item.LastModifiedAt,
            //item.LastModifiedBy,
            "修改"
                );
            }

            //0603
            int totalPages = (int)Math.Ceiling((double)registrationDetail.Count / pageSize);
            label2.Text = $"第 {pageIndex + 1} 頁 / 共 {totalPages} 頁";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void SetupPagination()
        {
            int totalPages = (int)Math.Ceiling((double)registrationDetail.Count / pageSize);
            bindingSource.DataSource = Enumerable.Range(0, totalPages).ToList();
            bindingSource.Position = 0;
        }

        private void uiButton6_Click(object sender, EventArgs e)//搜尋
        {
            //select
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string colname = comboBox1.SelectedValue.ToString();
                    string value = textBox1.Text.Trim();
                    SqlCommand cmd;

                    if (value == "")
                    {
                        cmd = new SqlCommand($"SELECT RegistrationID      ,EventBatchID  ,ed.EventName      ,r.MemberID  ,m.Name      ,NumberOfPeople      ,PaymentStatus  ,ps.StatusName as 繳費狀態      ,AmountDue      ,RegistrationDateTime      ,CurrentStatus  ,es.StatusName      ,InternalRemarks      ,r.LastModifiedAt      ,r.LastModifiedBy  FROM RegistrationDetails as r  join Member as m on m.MemberID=r.MemberID  join EventBatch as eb on eb.BatchID=r.EventBatchID  join EventDetails as ed  on ed.EventID=eb.EventID  join  EventStatus as es  on es.StatusID=CurrentStatus  JOIN EventStatus AS ps ON ps.StatusID = r.PaymentStatus ", conn);

                    }
                    else
                    {
                        //cmd = new SqlCommand($"SELECT * FROM EventBatch WHERE {colname} = @value", conn);
                        cmd = new SqlCommand($"SELECT RegistrationID      ,EventBatchID  ,ed.EventName      ,r.MemberID  ,m.Name      ,NumberOfPeople      ,PaymentStatus  ,ps.StatusName as 繳費狀態      ,AmountDue      ,RegistrationDateTime      ,CurrentStatus  ,es.StatusName      ,InternalRemarks      ,r.LastModifiedAt      ,r.LastModifiedBy  FROM RegistrationDetails as r  join Member as m on m.MemberID=r.MemberID  join EventBatch as eb on eb.BatchID=r.EventBatchID  join EventDetails as ed  on ed.EventID=eb.EventID  join  EventStatus as es  on es.StatusID=CurrentStatus  JOIN EventStatus AS ps ON ps.StatusID = r.PaymentStatus" +
                            $" WHERE {colname} = @value", conn);

                    }

                    cmd.Parameters.AddWithValue("@value", value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    registrationDetail.Clear();
                    while (reader.Read())
                    {
                        registrationDetail.Add(new RegistrationDetailModel
                        {
                            RegistrationID = reader.GetInt32(0),
                            EventBatchID = reader.GetInt32(1),
                            EventName = reader.GetString(2),
                            MemberID = reader.GetInt32(3),
                            MemberName = reader.GetString(4),

                            NumberOfPeople = reader.GetInt32(5),
                            PaymentStatus = reader.GetInt32(6),
                            PaymentStatusName = reader.GetString(7),
                            AmountDue = reader.IsDBNull(8) ? (int?)null : reader.GetInt32(5),
                            RegistrationDateTime = reader.GetDateTime(9),
                            CurrentStatus = reader.GetInt32(10),
                            CurrentStatusName = reader.GetString(11),
                            InternalRemarks = reader.GetString(12),
                            LastModifiedAt = reader.IsDBNull(13) ? (DateTime?)null : reader.GetDateTime(9),
                            LastModifiedBy = reader.IsDBNull(14) ? (int?)null : reader.GetInt32(10),


                        });
                    }
                }
                DisplayPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int registrationID = (int)this.dataGridView1.Rows[e.RowIndex].Cells["RegistrationID"].Value;

            // 判斷是否點擊 "修改"
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                dataGridView1.Columns[e.ColumnIndex].HeaderText == "")
            {

                FrmRegistrationDetails editForm = new FrmRegistrationDetails(registrationID);
                editForm.ShowDialog();

                //重新載入頁面
                LoadAllRegistrationDetail();       // 重新載入資料
            }
        }
        //不需要新增功能
        //private void uiButton5_Click(object sender, EventArgs e)
        //{
        //    FrmRegistrationDetails f = new FrmRegistrationDetails();
        //    f.Show();
        //}


        //<<
        private void uiButton1_Click(object sender, EventArgs e)
        {
            bindingSource.Position = 0;
            DisplayPage();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position--;
                DisplayPage();
            }

        }
        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
                DisplayPage();
            }

        }
        private void uiButton4_Click(object sender, EventArgs e)
        {
            bindingSource.Position = bindingSource.Count - 1;
            DisplayPage();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int registrationID = (int)dataGridView1.Rows[e.RowIndex].Cells["RegistrationID"].Value;

                // 跳出 FrmRegistrationParticipants 並傳遞 registrationID
                FrmRegistrationParticipants participantForm = new FrmRegistrationParticipants(registrationID);
                participantForm.ShowDialog();
            }

        }
    }
}
