using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_02
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

            try
            {
                cmd.CommandText = "DROP TABLE productTable;";
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { }

            cmd.CommandText = "CREATE TABLE productTable(pCode CHAR(15), pName CHAR(15), price INT,  amount INT)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO productTable VALUES('p001', '노트북', 110, 5);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO productTable VALUES('p002', '마우스', 3, 22);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO productTable VALUES('p003', '키보드', 2, 11);";
            cmd.ExecuteNonQuery();

            Console.WriteLine("SQL Server 연결 성공!!");

            string data1, data2, data3, data4, sql;
            while (true)
            {
                Console.Write("제품코드 ==> ");
                data1 = Console.ReadLine();
                if (data1.Length == 0) break;

                Console.Write("제품명 ==> ");
                data2 = Console.ReadLine();
                Console.Write("가격 ==> ");
                data3 = Console.ReadLine();
                Console.Write("재고수량 ==> ");
                data4 = Console.ReadLine();

                sql = "INSERT INTO productTable VALUES('" + data1 + "','" + data2 + "','" + data3
                    + "'," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
