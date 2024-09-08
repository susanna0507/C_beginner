using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace PJT_mini2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mat inCvImage, outCvImage;
        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "";
            ofd.Filter = "컬러필터 | * .jpg; *.png; * .bmp; * .tif";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            string fileName = ofd.FileName;

            inCvImage = Cv2.ImRead(fileName);
            outCvImage = inCvImage.Clone();

            DisplayImage();
        }


        void DisplayImage()
        {
            int outH = outCvImage.Height;
            int outW = outCvImage.Width;

            int menuHeight = menuStrip1.Height;
            this.ClientSize = new System.Drawing.Size(outW, outH + menuHeight);
            pbox_image.Location = new System.Drawing.Point(0, menuHeight);
            pbox_image.Size = new System.Drawing.Size(outW, outH);

            pbox_image.Image = BitmapConverter.ToBitmap(outCvImage);
        }


        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "";
            sfd.Filter = "PNG 파일(*.png) | * .png";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            string saveFname = sfd.FileName;

            Cv2.ImWrite(saveFname, outCvImage);
        }


        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("확대 배율 입력");
            double value = double.Parse(str);

            int inH = inCvImage.Height;
            int inW = inCvImage.Width;
            Cv2.Resize(inCvImage, outCvImage, new OpenCvSharp.Size(inW * value, inH * value));
            DisplayImage();
        }


        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("축소 배율 입력");
            double value = double.Parse(str);

            int inH = inCvImage.Height;
            int inW = inCvImage.Width;
            Cv2.Resize(inCvImage, outCvImage, new OpenCvSharp.Size(inW / value, inH / value));
            DisplayImage();
        }

        private void 상하반전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.Flip(inCvImage, outCvImage, FlipMode.X);
            DisplayImage();
        }

        private void 좌우반전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.Flip(inCvImage, outCvImage, FlipMode.Y);
            DisplayImage();
        }

        private void 회전90도ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.Rotate(inCvImage, outCvImage, RotateFlags.Rotate90Clockwise);
            DisplayImage();
        }

        private void 회전180도ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.Rotate(inCvImage, outCvImage, RotateFlags.Rotate180);
            DisplayImage();
        }


        private void 회전270도ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.Rotate(inCvImage, outCvImage, RotateFlags.Rotate90Counterclockwise);
            DisplayImage();
        }

        private void 회색이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.CvtColor(inCvImage, outCvImage, ColorConversionCodes.BGR2GRAY);
            DisplayImage();
        }

        private void 반전이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.BitwiseNot(inCvImage, outCvImage);
            DisplayImage();
        }


        private void 흑백이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("기준값 입력(0~255)");
            int value = int.Parse(str);

            Cv2.CvtColor(inCvImage, outCvImage, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(outCvImage, outCvImage, value, 255, ThresholdTypes.Binary);
            DisplayImage();
        }

        private void 블러링ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("블러링 값 입력(3~20)");
            int value = int.Parse(str);

            Cv2.Blur(inCvImage, outCvImage, new OpenCvSharp.Size(value, value),
            new OpenCvSharp.Point(-1, -1), BorderTypes.Default);

            DisplayImage();
        }

        private void 윤곽선검출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cv2.Canny(inCvImage, outCvImage, 100, 200, 3, true);
            DisplayImage();
        }
    }
}
