using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=naverDB;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            try
            {
                cmd.CommandText = "DROP TABLE userTable;";
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { }

            cmd.CommandText = "CREATE TABLE userTable(id CHAR(4), userName CHAR(15), email CHAR(15), birthYear INT)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO userTable VALUES('john', 'John Bann', 'john@naver.com', 1990);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO userTable VALUES('kim', 'Kim Chi', 'kim@daum.net', 1992);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO userTable VALUES('lee', 'Lee Pal', 'lee@paran.com', 1988);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO userTable VALUES('park', 'Park Su', 'park@gmail.com', 1980);";
            cmd.ExecuteNonQuery();

            Console.WriteLine("SQL Server 연결 성공!!");

            string data1, data2, data3, data4, sql;
            while (true)
            {
                Console.Write("사용자 ID ==> ");
                data1 = Console.ReadLine();
                if (data1.Length == 0) break;

                Console.Write("사용자 이름 ==> ");
                data2 = Console.ReadLine();
                Console.Write("사용자 이메일 ==> ");
                data3 = Console.ReadLine();
                Console.Write("사용자 출생연도 ==> ");
                data4 = Console.ReadLine();

                sql = "INSERT INTO userTable VALUES('" + data1 + "','" + data2 + "','" + data3
                    + "'," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            conn.Close();

        }
    }
}
