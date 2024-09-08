using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT11_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num1.Maximum = num2.Maximum = Int32.MaxValue;
            num1.Minimum = num2.Minimum = Int32.MinValue;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int result = CookMath.Add((int)num1.Value, (int)num2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int result = CookMath.Subtract((int)num1.Value, (int)num2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int result = CookMath.Multiply((int)num1.Value, (int)num2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int result = CookMath.Divide((int)num1.Value, (int)num2.Value);
            tb_result.Text = result.ToString();
        }
    }

    public static class CookMath
    {
        public static double COOK_PI = 3.141592653;
        public static double COOK_E = 2.718281;

        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}

