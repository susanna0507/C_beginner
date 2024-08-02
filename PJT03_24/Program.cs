using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT03_24  // 문자열 데이터형
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "IT CookBook~";
            string str2 = "C# 비기너";
            string str3 = str1 + str2;

            Console.WriteLine(str3);
            Console.WriteLine(str2.Length);
            Console.WriteLine(str2[0]);
            Console.WriteLine(str2[0].GetType());
            Console.WriteLine(str2[str2.Length - 1]);
        }
    }
}
