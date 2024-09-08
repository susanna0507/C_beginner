using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=naverDB;Trusted_Connection=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            Console.WriteLine("SQL Server 연결 성공!!");

            cmd.CommandText = "SELECT * FROM userTable";
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("아이디\t이름\t\t이메일\t\t출생년도");
            Console.WriteLine("---------------------------------------");
            while (reader.Read()) 
            {
                Console.Write(reader.GetString(0) + "\t");
                Console.Write(reader.GetString(1) + "\t");
                Console.Write(reader.GetString(2) + "\t");
                Console.WriteLine(reader.GetInt32(3) + "\t");
            }
            reader.Close();

            conn.Close();
        }
    }
}
