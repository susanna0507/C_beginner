using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "  한글 ABCD efgh $#@!  ";
            string str2 = str.Replace(" ", "");
            Console.WriteLine("띄어쓰기 제거 ==> {" + str2 + "]");

            Console.WriteLine("원본 문자열 ==> [" + str + "]");
            Console.WriteLine("대문자로 ==> [" + str.ToUpper() + "]");
            Console.WriteLine("소문자로 ==> [" + str.ToLower() + "]");
            Console.WriteLine("공백제거 ==> [" + str.Trim() + "]");
        }
    }
}
