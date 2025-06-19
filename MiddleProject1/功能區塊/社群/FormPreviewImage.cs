using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.社群
{
    public partial class FormPreviewImage : Form
    {
        //只是拿來顯示圖片的表單
        public FormPreviewImage(Image originalImage)
        {
            InitializeComponent();
            pictureBoxFullSize.Image = originalImage;
            pictureBoxFullSize.SizeMode = PictureBoxSizeMode.AutoSize;

            // 讓表單大小與圖片一致
            this.ClientSize = new Size(pictureBoxFullSize.Image.Width, pictureBoxFullSize.Image.Height);
            this.StartPosition = FormStartPosition.CenterScreen; // 讓視窗顯示在螢幕中央
        }
    }
}
