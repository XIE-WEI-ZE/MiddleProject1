using Microsoft.Extensions.Logging;
using MiddleProject1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleProject1.功能區塊.活動;

namespace MiddleProject1.功能區塊.活動
{
    public partial class FrmEventPhotoUpload : Form
    {
        internal int? EventID = null;
        internal int? EventRecordID = null;
        private PictureBox selectedPictureBox = null;
        string type;
        public FrmEventPhotoUpload(int eventID, string type)
        {
            InitializeComponent();
            //flowLayoutPanel1設定
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.DragEnter += FlowLayoutPanel1_DragEnter;
            this.flowLayoutPanel1.DragDrop += FlowLayoutPanel1_DragDrop;//放入多張照片
            if (type == "eventlist")
            {
                this.EventID = eventID;
                flowLayoutPanel1show_eventlist();
                this.label2.Text = "活動";
                this.type = "eventlist";

            }
            else if (type == "eventRecord")
            {
                this.EventRecordID = eventID;
                flowLayoutPanel1show_eventRecord();
                this.label2.Text = "活動紀錄";
                this.type = "eventRecord";
            }
        }
        //0603
        private void flowLayoutPanel1show_eventRecord()
        {
            this.label1.Text = EventRecordID.ToString();
            flowLayoutPanel1.Controls.Clear(); // 先清除舊的圖片（如果有）

            string connStr = Settings.Default.NursingHomeConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = " SELECT PhotoID, PhotoData FROM EventRecordPhotos WHERE EventRecordID = @EventRecordID";

                //int num = countrynum(this.comboBox1.Text);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventRecordID", EventRecordID); // 可依需求更改 CountryNum

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int photoId = (int)reader["PhotoID"];
                            byte[] imgBytes = (byte[])reader["PhotoData"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                Image img = Image.FromStream(ms);
                                PictureBox picBox = new PictureBox();
                                picBox.Image = img;
                                picBox.Tag = photoId;
                                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                                picBox.Width = 100;
                                picBox.Height = 100;
                                picBox.Margin = new Padding(5);

                                flowLayoutPanel1.Controls.Add(picBox);
                                picBox.Click += (s, e) => HighlightSelectedPictureBox(picBox);
                                {
                                    if (selectedPictureBox != null)
                                        selectedPictureBox.BackColor = Color.Transparent;

                                    selectedPictureBox = picBox;
                                    selectedPictureBox.BackColor = Color.LightBlue;
                                };
                            }
                        }
                    }

                }
            }
        }

        private void FlowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;//允許拖拉
        }

        private void FlowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {

            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            // this.pictureBox1.Image = Image.FromFile(filenames[0]);
            for (int i = 0; i <= filenames.Length - 1; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(filenames[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 100;
                pic.Height = 70;



                this.flowLayoutPanel1.Controls.Add(pic);
                if (type == "eventlist")
                {
                    SaveImageToDatabase_eventlist(pic.Image);

                }
                else if (type == "eventRecord")
                {
                    SaveImageToDatabase_eventRecord(pic.Image);
                }

            }
        }
        private void flowLayoutPanel1show_eventlist()
        {
            string name = 活動.Events.getEventName((int)EventID);
            this.label1.Text = EventID.ToString() + name;
            flowLayoutPanel1.Controls.Clear(); // 先清除舊的圖片（如果有）

            string connStr = Settings.Default.NursingHomeConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT PhotoID, PhotoData FROM EventPhotos WHERE EventID = @EventID";

                //int num = countrynum(this.comboBox1.Text);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", EventID); // 可依需求更改 CountryNum

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int photoId = (int)reader["PhotoID"];
                            byte[] imgBytes = (byte[])reader["PhotoData"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                Image img = Image.FromStream(ms);
                                PictureBox picBox = new PictureBox();
                                picBox.Image = img;
                                picBox.Tag = photoId;
                                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                                picBox.Width = 100;
                                picBox.Height = 100;
                                picBox.Margin = new Padding(5);

                                flowLayoutPanel1.Controls.Add(picBox);
                                picBox.Click += (s, e) =>
                                {
                                    if (selectedPictureBox != null)
                                        selectedPictureBox.BackColor = Color.Transparent;

                                    selectedPictureBox = picBox;
                                    selectedPictureBox.BackColor = Color.LightBlue;
                                };
                            }
                        }
                    }

                }
            }
        }

        private int SaveImageToDatabase_eventlist(Image image)
        {
            byte[] imageBytes = ImageToByteArray(image);
            string connString = Settings.Default.NursingHomeConnectionString;
            int newPhotoID = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = @"
                INSERT INTO EventPhotos (EventID, PhotoData, CreatedAt, CreatedBy) 
                OUTPUT INSERTED.PhotoID
                VALUES (@EventID, @PhotoData, GETDATE(), '20')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@EventID", SqlDbType.Int).Value = EventID;
                        cmd.Parameters.Add("@PhotoData", SqlDbType.VarBinary).Value = imageBytes;

                        newPhotoID = (int)cmd.ExecuteScalar(); // 取得新 ID
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return newPhotoID;
        }

        private int SaveImageToDatabase_eventRecord(Image image)
        {
            byte[] imageBytes = ImageToByteArray(image);
            string connString = Settings.Default.NursingHomeConnectionString;
            int newPhotoID = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = @"
                      INSERT INTO EventRecordPhotos (EventRecordID, PhotoData, CreatedAt, CreatedBy) 
                      VALUES (@EventRecordID, @PhotoData, GETDATE(), '20')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@EventRecordID", SqlDbType.Int).Value = EventRecordID;
                        cmd.Parameters.Add("@PhotoData", SqlDbType.VarBinary).Value = imageBytes;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return newPhotoID;
        }


        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // 或 PNG
                return ms.ToArray();
            }
        }
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (selectedPictureBox == null)
            {
                MessageBox.Show("請先選取要刪除的照片！");
                return;
            }

            DialogResult result = MessageBox.Show("確定要刪除此照片嗎？", "刪除確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int photoID = (int)selectedPictureBox.Tag;

                DeletePhotoFromDatabase(photoID);

                flowLayoutPanel1.Controls.Remove(selectedPictureBox);
                selectedPictureBox.Dispose();
                selectedPictureBox = null;
            }
        }

        private void DeletePhotoFromDatabase(int photoID)
        {
            string connStr = Settings.Default.NursingHomeConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query="";
                if (type == "eventlist")
                {
                     query = @"DELETE FROM EventPhotos WHERE PhotoID = @PhotoID";

                }
                else if (type == "eventRecord")
                {
                     query = @"DELETE FROM EventRecordPhotos WHERE PhotoID = @PhotoID";
                }


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@PhotoID", SqlDbType.Int).Value = photoID;

                    int affected = cmd.ExecuteNonQuery();
                    if (affected == 0)
                    {
                        MessageBox.Show("刪除失敗，可能找不到此圖片。");
                    }
                }
            }
        }
        //0603
        private void HighlightSelectedPictureBox(PictureBox picBox)
        {
            if (selectedPictureBox != null)
            {
                selectedPictureBox.Padding = new Padding(0);
                selectedPictureBox.BackColor = Color.Transparent;
                selectedPictureBox.BorderStyle = BorderStyle.None;
            }

            selectedPictureBox = picBox;
            selectedPictureBox.Padding = new Padding(2);
            selectedPictureBox.BackColor = Color.Red;
            selectedPictureBox.BorderStyle = BorderStyle.FixedSingle;
        }


    }
}
