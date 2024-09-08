﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PJT_mini13_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;" + 
            "AttachDbFilename=D:\\CookC#\\PJT_mini13(WPF)\\Login.mdf;Integrated Security=TrueData Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CookC#\\PJT_mini13(WPF)\\Login.mdf;Integrated Security=TrueData Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CookC#\\PJT_mini13(WPF)\\Login.mdf;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = string.Format("SELECT COUNT(*) FROM LoginTable " +
                    "WHERE UserName='{0}' AND Password='{1}'",
                    txtUserName.Text, txtPassword.Password);
                SqlCommand comm = new SqlCommand(sql, conn);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("Login 성공");
                }
                else
                {
                    MessageBox.Show("Login 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}