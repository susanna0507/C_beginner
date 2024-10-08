﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT09_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_change.BackColor = Color.Blue;
            btn_change.ForeColor = Color.Yellow;
            btn_change.Size = new Size(200, 100);
            btn_change.Location = new Point(0,0);
            btn_change.Text = "C#은 꿀잼";
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            this.Text = "버튼을 눌렀어요";
            this.BackColor = Color.Yellow;
            btn_change.Hide();

            MessageBox.Show("버튼이 없어졌어요");
        }

        private void btn_change_MouseEnter(object sender, EventArgs e)
        {
            btn_change.Text = "마우스 올라옴~";
            btn_change.BackColor = Color.Magenta;
        }

        private void btn_change_MouseLeave(object sender, EventArgs e)
        {
            btn_change.Text = "마우스 떠나감ㅠ";
            btn_change.BackColor= Color.Black;
        }
    }
}
