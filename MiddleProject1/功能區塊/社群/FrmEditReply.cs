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

namespace MiddleProject1.功能區塊.社群
{
    public partial class FrmEditReply : Form
    {
        private string replyID;

        public FrmEditReply(string replyID, string replyContent)
        {
            InitializeComponent();
            this.replyID = replyID;
            txtReplyContent.Text = replyContent; // **預填入回覆內容**
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string updatedContent = txtReplyContent.Text;

            string connString = "Data Source=.;Initial Catalog=NursingHome;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE CommunityReplys SET ReplyContent = @content WHERE ReplyID = @replyID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@content", updatedContent);
                cmd.Parameters.AddWithValue("@replyID", replyID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("回覆已成功修改！");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
