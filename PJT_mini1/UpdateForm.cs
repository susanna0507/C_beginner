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
    public partial class UpdateForm : Form
    {
        string memberID; // 아이디의 전역 변수

        public UpdateForm(string paraID)
        {
            InitializeComponent();
            memberID = paraID;
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CookDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT*FROM member WHERE id = '"+memberID+"'";
            reader = cmd.ExecuteReader();

            if (!reader.Read()) //전달받은 회원 아이디가 없다면
            {
                reader.Close();
                MessageBox.Show("아이디(" + memberID + ")는 회원이 아닙니다.");
                this.Close();
            }
            else
            {
                string data1, data2, data3, data4;
                data1 = reader.GetString(0).Trim();
                data2 = reader.GetString(1).Trim();
                data3 = reader.GetString(2).Trim();
                data4 = reader.GetInt32(3).ToString();

                tb_id.Text = data1;
                tb_name.Text = data2;
                tb_email.Text = data3;
                tb_birth.Text = data4;
                reader.Close();
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string data1, data2, data3, data4, sql;

            data1 = tb_id.Text;
            data2 = tb_name.Text;
            data3 = tb_email.Text;
            data4 = tb_birth.Text;

            sql = "UPDATE member SET name = '" + data2 + "', email = '" + data3 + "',birth =" + data4;
            sql += "WHERE id ='" + data1 + "'";
            cmd.CommandText = sql;  
            cmd.ExecuteNonQuery();

            MessageBox.Show("아이디(" + memberID + ")가 잘 수정되었습니다. 창이 닫힙니다.");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
