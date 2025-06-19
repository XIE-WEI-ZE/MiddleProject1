using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.床位
{
    public partial class FrmMemberImage : Form
    {
        public FrmMemberImage(Image image)
        {
            InitializeComponent();

            if (image != null)
            {
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMemberImage_Load(object sender, EventArgs e)
        {

        }
    }
}
