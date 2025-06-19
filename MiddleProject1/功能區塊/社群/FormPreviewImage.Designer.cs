namespace MiddleProject1.功能區塊.社群
{
    partial class FormPreviewImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFullSize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFullSize
            // 
            this.pictureBoxFullSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFullSize.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFullSize.Name = "pictureBoxFullSize";
            this.pictureBoxFullSize.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxFullSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFullSize.TabIndex = 0;
            this.pictureBoxFullSize.TabStop = false;
            // 
            // FormPreviewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxFullSize);
            this.Name = "FormPreviewImage";
            this.Text = "FormPreviewImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFullSize;
    }
}