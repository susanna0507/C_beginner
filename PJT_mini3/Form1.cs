using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT_mini3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(tb_kor.Text) + Convert.ToDouble(tb_math.Text) + Convert.ToDouble(tb_eng.Text);

            double avg = sum / 3;

            tb_total.Text = sum.ToString();
            tb_avg.Text = avg.ToString("0.0");
        }
    }
}
