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

namespace PJT04_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_draw_Click(object sender, EventArgs e)
        {
            // Turtle.Forward();

            
            Turtle.Delay = 500;
            /*
            Turtle.Rotate(45);
            Turtle.Forward(100);
            Turtle.Rotate(45);
            Turtle.Backward(100);
            */

            Turtle.PenColor = Color.Red;
            Turtle.PenUp();
            Turtle.MoveTo(-150, 0); // 시작점
            for (int i = 0; i < 9; i++)
            {
                Turtle.PenDown();
                Turtle.Rotate(20);
                Turtle.Forward(50);

                Turtle.PenUp();
                Turtle.Rotate(20);
                Turtle.Forward(50);

            }; 
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
