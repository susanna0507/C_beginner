using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_05
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

            while (true)
            {
                Console.WriteLine("userTable 모드 선택");
                Console.WriteLine("(1) 추가 (2) 조회 (3) 갱신 (4) 삭제");
                Console.Write("입력 >>> ");

                int mode = int.Parse(Console.ReadLine());
                if (mode == 1)
                {
                    String data1, data2, data3, data4, sql;
                    Console.Write("아이디 입력 >>> ");
                    data1 = Console.ReadLine();
                    Console.Write("이름 입력 >>> ");
                    data2 = Console.ReadLine();
                    Console.Write("이메일 입력 >>> ");
                    data3 = Console.ReadLine();
                    Console.Write("출생연도 입력 >>> ");
                    data4 = Console.ReadLine();
                    if (data1.Length > 4 || data2.Length > 15 || data3.Length > 15)
                    {
                        Console.WriteLine("데이터 형식이 올바르지 않습니다.");
                        continue;
                    }
                    sql = "INSERT INTO userTable VALUES ('" + data1 + "','" + data2 +
                        "','" + data3 + "'," + data4 + ");";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                else if (mode == 2)
                {
                    string data1, data2, sql;
                    Console.Write("조회할 아이디를 입력하세요 >>> ");
                    data1 = Console.ReadLine();
                    Console.Write("조회할 정보를 입력하세요 >>> ");
                    data2 = Console.ReadLine();
                    if (data2.Equals("userName") || data2.Equals("email") || data2.Equals("birthYear"))
                    {
                        sql = "SELECT " + data2 + " FROM userTable WHERE id='" + data1 + "';";
                        cmd.CommandText = sql;
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (data2.Equals("userName"))
                            Console.WriteLine("{0}의 {1}은 {2}입니다."
                                , data1, data2, reader.GetString(0));
                        if (data2.Equals("email"))
                            Console.WriteLine("{0}의 {1}은 {2}입니다."
                                , data1, data2, reader.GetString(0));
                        if (data2.Equals("birthYear"))
                            Console.WriteLine("{0}의 {1}은 {2}입니다."
                                , data1, data2, reader.GetInt32(0));
                        reader.Close();
                    }
                    else
                    {
                        Console.WriteLine("데이터 형식이 올바르지 않습니다.");
                        continue;
                    }
                }
                else if (mode == 3)
                {
                    string data1, data2, data3, sql;
                    Console.Write("갱신할 아이디를 입력하세요 >>> ");
                    data1 = Console.ReadLine();
                    Console.Write("갱신할 정보를 입력하세요 >>> ");
                    data2 = Console.ReadLine();
                    Console.Write("갱신할 값을 입력하세요 >>> ");
                    data3 = Console.ReadLine();

                    if (data2.Equals("birthYear"))
                        sql = "UPDATE userTable SET " + data2 + "=" + data3 + " WHERE id='"
                        + data1 + "';";
                    else
                        sql = "UPDATE userTable SET " + data2 + "='" + data3 + "' WHERE id='"
                            + data1 + "';";

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();


        }
    }
}
