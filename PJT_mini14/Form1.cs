using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT_mini14
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;

        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CookC#\Students.accdb";
        public Form1()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            ConnectionOpen();

            string sql = "select * from StudentTable";
            comm = new OleDbCommand(sql, conn);
            
            ReadAndToListBox();
            ConnectionClose();
        }

        private void ConnectionOpen()
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
        }

        private void ReadAndToListBox()
        {
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SID"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"] + "\t";

                listBox1.Items.Add(x);
            }
            reader.Close();
        }
        
        private void ConnectionClose()
        {
            conn.Close();
            conn = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem == null)
                return;

            string[] s = lb.SelectedItem.ToString().Split('\t');
            txtID.Text = s[0];
            txtSId.Text = s[1];
            txtSName.Text = s[2];
            txtPhone.Text = s[3];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtSName.Text == "" || txtPhone.Text == "" || txtSId.Text == "")
                return;

            ConnectionOpen();

            string sql = string.Format("insert into " + "StudentTable(SId, SName, Phone) VALUES({0},'{1}','{2}')",
                txtSId.Text, txtSName.Text, txtPhone.Text);

            comm = new OleDbCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("삽입 성공!");

            ConnectionClose();
            listBox1.Items.Clear();
            DisplayStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSName.Text == "" && txtPhone.Text == "" && txtSId.Text == "")
                return;

            ConnectionOpen();

            string sql = "";
            if (txtSId.Text != "")
                sql = string.Format("SELECT * FROM StudentTable WHERE SID={0}", txtSId.Text);
            if (txtSName.Text != "")
                sql = string.Format("SELECT * FROM StudentTable WHERE SName={0}", txtSName.Text);
            if (txtPhone.Text != "")
                sql = string.Format("SELECT * FROM StudentTable WHERE Phone={0}", txtPhone.Text);

            listBox1.Items.Clear();
            comm = new OleDbCommand(sql, conn);
            ReadAndToListBox();
            ConnectionClose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConnectionOpen();

            string sql = string.Format("UPDATE StudentTable SET SID={0}, SName='{1}', Phone='{2}' WHERE ID={3}",
                txtSId.Text, txtSName.Text, txtPhone.Text, txtID.Text);

            comm = new OleDbCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("수정 성공!");

            ConnectionClose();
            listBox1.Items.Clear() ;
            DisplayStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ConnectionOpen();

            string sql = string.Format("DELETE FROM StudentTable WHERE ID={0}", txtID.Text);

            comm = new OleDbCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("삭제 성공!");

            ConnectionClose();
            listBox1.Items.Clear();
            DisplayStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSId.Text = "";
            txtSName.Text = "";
            txtPhone.Text = "";
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayStudents();
        }
    }
}
