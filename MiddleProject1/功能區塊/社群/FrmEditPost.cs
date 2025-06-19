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

namespace MiddleProject1.功能區塊.社群
{
    public partial class FrmEditPost : Form
    {

        private string postID;
        private string postAuthorID;

        public FrmEditPost(string postID, string postAuthorID, string title, string content, Image postImage)
        {
            InitializeComponent();
            this.postID = postID;
            this.postAuthorID = postAuthorID;

            txtEditTitle.Text = title;
            txtEditContent.Text = content;
            pictureBoxEdit.Image = postImage;
        }

        /// 按下「儲存變更」按鈕的事件處理器
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string updatedTitle = txtEditTitle.Text;
            string updatedContent = txtEditContent.Text;

            // 將圖片轉換為 Byte 陣列
            byte[] imageBytes = null;
            if (pictureBoxEdit.Image != null) // 如果圖片不為空，則轉換為byte[]
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxEdit.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }
            }

            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                // 更新文章標題與內容
                string query = "UPDATE CommunityPosts SET PostTitle = @title, PostContent = @content WHERE PostID = @postID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", updatedTitle);
                cmd.Parameters.AddWithValue("@content", updatedContent);
                cmd.Parameters.AddWithValue("@postID", postID);
                cmd.ExecuteNonQuery();

                // 檢查是否已存在圖片
                string checkImageQuery = "SELECT COUNT(*) FROM CommunityAttachments WHERE PostID = @postID";
                SqlCommand checkCmd = new SqlCommand(checkImageQuery, conn);
                checkCmd.Parameters.AddWithValue("@postID", postID);
                int imageCount = (int)checkCmd.ExecuteScalar();


                if (imageBytes != null)
                {
                    //如果資料庫內已有圖片，則更新
                    if (imageCount > 0)
                    {
                        string updateImageQuery = "UPDATE CommunityAttachments SET IsImage = @imageBytes WHERE PostID = @postID";
                        SqlCommand updateCmd = new SqlCommand(updateImageQuery, conn);
                        updateCmd.Parameters.AddWithValue("@imageBytes", imageBytes);
                        updateCmd.Parameters.AddWithValue("@postID", postID);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //如果資料庫內沒有圖片，則插入新圖片
                        string insertImageQuery = "INSERT INTO CommunityAttachments (PostID, IsImage) VALUES (@postID, @imageBytes)";
                        SqlCommand insertCmd = new SqlCommand(insertImageQuery, conn);
                        insertCmd.Parameters.AddWithValue("@postID", postID);
                        insertCmd.Parameters.AddWithValue("@imageBytes", imageBytes);
                        insertCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    // 如果圖片為空，則移除
                    string removeImageQuery = "UPDATE CommunityAttachments SET IsImage = NULL WHERE PostID = @postID";
                    SqlCommand removeCmd = new SqlCommand(removeImageQuery, conn);
                    removeCmd.Parameters.AddWithValue("@postID", postID);
                    removeCmd.ExecuteNonQuery();
                }
            }
            
            MessageBox.Show("文章已成功更新！");

            // 通知 FrmShowAllPosts 更新文章列表
            FrmShowAllPosts mainForm = Application.OpenForms["FrmShowAllPosts"] as FrmShowAllPosts;
            if (mainForm != null)
            {
                mainForm.RefreshPosts(); // 刷新文章列表
            }

            // 通知 FrmPostDetails 文章已更新
            this.DialogResult = DialogResult.OK;
            this.Close(); // 關閉編輯表單
        }

        /// 按下「更換圖片」按鈕的事件處理器
        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEdit.Image = Image.FromFile(openFileDialog.FileName); // 更新預覽
                }
            }
        }

        /// 按下「移除圖片」按鈕的事件處理器
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pictureBoxEdit.Image = null; // 清除圖片
        }

        // 按下「返回」按鈕的事件處理器
        private void btnBack_Click(object sender, EventArgs e)
        {
            // 通知 FrmPostDetails 文章已更新
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
