using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Nakov.TurtleGraphics;

namespace PJT_Rainbow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 400, sheight = 400;

            this.Text = "거북이가 그리는 무지개 색상의 원";
            this.ClientSize = new Size(sheight, swidth);

            Turtle.Delay = 10;
            Turtle.PenUp();
            Turtle.MoveTo(0, 100);
            Turtle.RotateTo(90);
            Turtle.PenDown();
            for (int i = 0; i < 14; i++)
            {
                switch (i % 7)
                {
                    case 0: Turtle.PenColor = Color.Red; break;
                    case 1:
                        Turtle.PenColor = Color.Orange; break;
                    case 2:
                        Turtle.PenColor = Color.Yellow; break;
                    case 3:
                        Turtle.PenColor = Color.Green; break;
                    case 4:
                        Turtle.PenColor = Color.Blue; break;
                    case 5:
                        Turtle.PenColor = Color.Navy; break;
                    case 6:
                        Turtle.PenColor = Color.Purple; break;

                }
                for (int angle = 0; angle < 36; angle++)
                {
                    Turtle.Forward(10 + i);
                    Turtle.Rotate(10);
                }

            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }
    }
}
