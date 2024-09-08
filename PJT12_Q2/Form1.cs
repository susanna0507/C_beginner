using Nakov.TurtleGraphics;
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

namespace PJT12_Q2
{
    public partial class Form1 : Form
    {
        int startX, startY, endX, endY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;

            if (startX > endX)
            {
                int tmp = startX;
                startX = endX;
                endX = tmp;
            }
            if(startY > endY)
            {
                int tmp = startY;
                startY = endY;
                endY = tmp;
            }

            if (e.Button == MouseButtons.Left)
            {
                CookRectangle rect1 = new CookRectangle(startX, startY, endX, endY, this);

            }
        }
    }

    abstract class Shape
    {
        public Color color;
        public int pSize;
        public int x1, y1, x2, y2;

        abstract public void DrawShape();
    }

    class CookRectangle : Shape
    {
        Form baseForm;
        public CookRectangle(int x1, int y1, int x2, int y2, Form form)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

            Random rnd = new Random();
            pSize rnd = rnd.Next(1, 15);
            byte r = (byte)rnd.Next(0, 256);
            byte g = (byte)rnd.Next(0, 256);
            byte b = (byte)rnd.Next(0, 256);
            color = Color.FromArgb(r, g, b);

            baseForm = form;
        }
        public override void DrawShape()
        {

            Graphics g = baseForm.CreateGraphics();
            g.DrawRectangle(new Pen(color, pSize), new Rectangle());
            
        }
    }

    class CookCircle : Shape
    {
        Form baseForm;
        public CookCircle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void DrawShape()
        {
            Graphics g = baseForm.CreateGraphics
        }
    }
}
