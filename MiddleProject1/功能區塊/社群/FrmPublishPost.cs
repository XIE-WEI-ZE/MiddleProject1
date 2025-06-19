using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.社群
{
    public partial class FrmPublishPost : Form
    {
        public FrmPublishPost(string memberID)
        {
            InitializeComponent();
            labMemberID.Text = memberID;  // **顯示登入的會員 ID**
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            int newPostID;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // 插入文章標題與內容到 CommunityPosts 資料表並獲取 PostID
                string insertPostQuery = "INSERT INTO CommunityPosts (MemberID, PostTitle, PostContent, CreatedAt, UpdatedAt, PostStatuses) OUTPUT INSERTED.PostID VALUES (@memberid, @title, @content, @createdAt, @updatedAt, @postStatuses)";
                SqlCommand cmdPost = new SqlCommand(insertPostQuery, conn);
                cmdPost.Parameters.AddWithValue("@memberid", this.labMemberID.Text); // **使用登入的會員 ID**
                cmdPost.Parameters.AddWithValue("@title", txtTitle.Text);
                cmdPost.Parameters.AddWithValue("@content", richTextBoxContent.Text);
                cmdPost.Parameters.AddWithValue("@createdAt", DateTime.Now); // 存入當前時間
                cmdPost.Parameters.AddWithValue("@updatedAt", DateTime.Now); // 更新時間也存入當前時間
                cmdPost.Parameters.AddWithValue("@postStatuses", "已發布");

                newPostID = (int)cmdPost.ExecuteScalar(); // 獲取新建立的 PostID

                // **如果有選擇圖片，則存入 CommunityAttachments**
                if (pictureBox1.Image != null)
                {
                    string insertImageQuery = "INSERT INTO CommunityAttachments (PostID, IsImage) VALUES (@postID, @isImage)";
                    SqlCommand cmdImage = new SqlCommand(insertImageQuery, conn);
                    cmdImage.Parameters.AddWithValue("@postID", newPostID);

                    // **存為 Base64**
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, ImageFormat.Png);
                        byte[] imageBytes = ms.ToArray(); // 轉換為 byte[]
                        cmdImage.Parameters.Add("@isImage", SqlDbType.VarBinary).Value = imageBytes;
                    }

                    cmdImage.ExecuteNonQuery(); // **插入圖片**
                }
            }

                // **清空輸入欄位**
                txtTitle.Clear();
                richTextBoxContent.Clear();
                pictureBox1.Image = null; // 清空圖片

                // 更新文章列表
                ((FrmShowAllPosts)Application.OpenForms["FrmShowAllPosts"])?.LoadData(1);

                // 發表成功通知
                MessageBox.Show("文章已成功發表！🎉");
                this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "圖像檔案 (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName); // **顯示選擇的圖片**
            }
        }
    }
}
