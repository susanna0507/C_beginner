using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT09_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            list_lang.Items.Add(combo_lang.Text);
        }

        private void datepick_birth_ValueChanged(object sender, EventArgs e)
        {
            masktb_birth.Text = datepick_birth.Value.ToString();
        }
    }
}
