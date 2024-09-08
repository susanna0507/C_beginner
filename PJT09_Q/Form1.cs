using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT09_Q
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            pb_image.SizeMode = PictureBoxSizeMode.StretchImage;

            if (rb_dog.Checked)
                pb_image.Image = Bitmap.FromFile("D:\\CookC#\\images\\dog1.png");
            else if (rb_cat.Checked)
                pb_image.Image = Bitmap.FromFile("D:\\CookC#\\images\\cat1.png");
            else if (rb_penguin.Checked)
                pb_image.Image = Bitmap.FromFile("D:\\CookC#\\images\\bird1.png");
            else
                MessageBox.Show("먼저 동물을 선택하세요");

        }
    }
}
