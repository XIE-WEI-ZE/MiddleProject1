using MiddleProject1.Properties;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.活動
{
    public partial class FrmEventList : Form
    {
        public FrmEventList()
        {
            InitializeComponent();
            //LoadStatusComboBox();//下拉選單預設
            //requiresFamilyInsuranceCheckBox.Checked = false;
            //isPaidCheckBox.Checked = false;
            //this.eventDetailsBindingNavigatorSaveItem.Click += eventDetailsBindingNavigatorSaveItem_Click;
            //this.eventDetailsBindingNavigatorDeleteItem.Click += eventDetailsBindingNavigatorDeleteItem_Click;
        }



        internal int? EventID = null;
        public FrmEventList(int eventID)
        {
            InitializeComponent();
            this.EventID = eventID;
            //LoadStatusComboBox();//下拉選單預設
            //this.eventDetailsBindingNavigatorSaveItem.Click += eventDetailsBindingNavigatorSaveItem_Click;
            //this.eventDetailsBindingNavigatorDeleteItem.Click += eventDetailsBindingNavigatorDeleteItem_Click;
        }

        //存檔
        //private bool _skipValidation = false; // 新增 flag
        private void eventDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (eventIDTextBox .Text!= "")  //0605
            {
                // === 驗證區開始 ===
                if (string.IsNullOrWhiteSpace(eventNameTextBox.Text))
                {
                    MessageBox.Show("請輸入活動名稱！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    eventNameTextBox.Focus();
                    return; // 中止儲存流程
                }


                if (string.IsNullOrWhiteSpace(organizerTextBox.Text))
                {
                    MessageBox.Show("請輸入主辦單位", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    organizerTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(targetAudienceTextBox.Text))
                {
                    MessageBox.Show("請輸入活動對象", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    targetAudienceTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(categoryIDTextBox.Text))
                {
                    MessageBox.Show("請選擇活動類別", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    categoryIDTextBox.Focus();
                    return;
                }
                //statusTextBox
                if (string.IsNullOrWhiteSpace(statusTextBox.Text))
                {
                    MessageBox.Show("請選擇活動狀態", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    statusTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(contactPersonIDTextBox.Text))
                {
                    MessageBox.Show("請選擇聯絡人", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contactPersonIDTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(contactPhoneTextBox.Text))
                {
                    MessageBox.Show("請輸入聯絡電話", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contactPhoneTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(eventLocationTextBox.Text))
                {
                    MessageBox.Show("請輸入活動地點", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    eventLocationTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
                {
                    MessageBox.Show("請輸入活動內容", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    descriptionTextBox.Focus();
                    return;
                }
                if (isPaidCheckBox.Checked)
                {
                    if (string.IsNullOrWhiteSpace(totalAmountTextBox.Text))
                    {
                        MessageBox.Show("請輸入總金額。", "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        totalAmountTextBox.Focus();
                        return;
                    }
                    if (!int.TryParse(totalAmountTextBox.Text, out int amount))
                    {
                        MessageBox.Show("總金額必須是整數。", "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        totalAmountTextBox.Focus();
                        return;
                    }


                    if (amount < 0)
                    {
                        MessageBox.Show("總金額不能小於 0。", "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        totalAmountTextBox.Focus();
                        return;
                    }
                }
                else
                {
                    // 若未勾選付費，總金額欄位必須為空
                    if (!string.IsNullOrWhiteSpace(totalAmountTextBox.Text))
                    {
                        MessageBox.Show("未勾選需付費時，總金額欄位必須為空。", "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        totalAmountTextBox.Focus();
                        return;
                    }
                }
            }
            try
            {
                this.Validate();
                this.eventDetailsBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.nhEventDataSet1);

                MessageBox.Show("儲存成功");
                this.Close();//關閉視窗
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("資料已被其他人修改，請重新載入。");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // 主鍵或唯一索引衝突
                {
                    MessageBox.Show("儲存失敗：此記錄已存在，請檢查是否重複。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 547) // Foreign key constraint
                {
                    MessageBox.Show("儲存失敗：資料與其他資料表有關聯，無法進行此操作。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("發生資料庫錯誤：" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存過程發生錯誤：" + ex.Message);
            }
            //finally {
            //    _skipValidation = false;  // 無論成功或失敗都重設
            //}
            


        }

        private void FrmEventList_Load(object sender, EventArgs e)
        {
            eventIDTextBox.ReadOnly = true;         //欄位僅能讀取
            categoryIDTextBox.ReadOnly = true;
            contactPersonIDTextBox.ReadOnly = true;
            createdAtDateTimePicker.Visible = false;
            createdByTextBox.Visible = false;
            lastModifiedAtDateTimePicker.Visible = false;
            lastModifiedByTextBox.Visible = false;

            if (EventID.HasValue && EventID.Value > 0)
            {
                this.eventDetailsTableAdapter1.FillByEventDetails_EventID(this.nhEventDataSet1.EventDetails, EventID.Value);

            }
            else
            {
                this.eventDetailsBindingSource.AddNew();
                createdAtDateTimePicker.Value = DateTime.Now;
                createdByTextBox.Text = "20";
                //新增時預設
                requiresFamilyInsuranceCheckBox.Checked = false;
                isPaidCheckBox.Checked = false;
            }

            LoadStatusComboBox();
        }


        //private void eventDetailsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.eventDetailsBindingSource.EndEdit();
        //    this.tableAdapterManager1.UpdateAll(this.nhEventDataSet1);

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSelectEventList f = new FrmSelectEventList("EventCategory");
            if (f.ShowDialog() == DialogResult.OK)
            {
                int selectedEventID = f.SelectedEventID;

                categoryIDTextBox.Text = selectedEventID.ToString();
            }

        }

        private void LoadStatusComboBox()
        {
            string connStr = Settings.Default.NursingHomeConnectionString;
            string query = "SELECT StatusID, StatusName FROM EventStatus ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox1.DisplayMember = "StatusName";
                    comboBox1.ValueMember = "StatusID";
                    comboBox1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        statusTextBox.Text = "";
                        return; // 無資料直接離開
                    }

                    if (!string.IsNullOrEmpty(statusTextBox.Text))
                    {
                        // 如果已經有狀態值，就設定選項
                        comboBox1.SelectedValue = int.Parse(statusTextBox.Text);
                        //comboBox1.SelectedIndex = 3; //int.Parse(statusTextBox.Text);
                    }
                    else
                    {
                        // 如果是空的，就選第一筆並同步到 statusTextBox
                        comboBox1.SelectedIndex = 0;
                        statusTextBox.Text = dt.Rows[0]["StatusID"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入狀態選單失敗：" + ex.Message);
            }
        }
        private void eventDetailsBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("確定要刪除這筆資料嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {

                //_skipValidation = true;
                eventDetailsBindingSource.RemoveCurrent();

                this.Validate();
                eventDetailsBindingSource.EndEdit();
                tableAdapterManager1.UpdateAll(nhEventDataSet1);

                MessageBox.Show("刪除成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // FK 限制
                {
                    MessageBox.Show("刪除失敗：此資料與其他資料有關聯，無法刪除。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("資料庫錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                statusTextBox.Text = comboBox1.SelectedValue.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmSelectEventList f = new FrmSelectEventList("Employee");
            if (f.ShowDialog() == DialogResult.OK)
            {
                int selectedEventID = f.SelectedEventID;

                contactPersonIDTextBox.Text = selectedEventID.ToString();
            }

        }

    }
}
