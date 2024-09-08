using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT_mini1
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void InsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CookDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            string data1, data2, data3, data4, sql;

            data1 = tb_id.Text;
            data2 = tb_name.Text;
            data3 = tb_email.Text;
            data4 = tb_birth.Text;

            sql = "INSERT INTO member VALUES('"+data1+"','" + data2 + "','" + data3 + "'," + data4+")";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            MessageBox.Show("아이디(" + data1 + ")가 잘 입력되었습니다. 창이 닫힙니다.");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
