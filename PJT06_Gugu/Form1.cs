using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace PJT06_Gugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            float tX = -400, tY = 400;
            int swidth = 800, sheight = 800;
            this.Text = "거북이 구구단";
            this.ClientSize = new Size(sheight, swidth);
            Turtle.Delay = 10;

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int k = 2; k < 10; k++)
                {
                    Turtle.PenUp();
                    Turtle.PenColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    Turtle.MoveTo(tX + 80 * k, tY - 80 * i);
                    Turtle.PenSize = i * k;
                    Turtle.PenDown();
                    Turtle.Forward();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
