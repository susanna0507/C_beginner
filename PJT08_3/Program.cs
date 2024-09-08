using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("문자열 입력 ==> ");
            str = Console.ReadLine();

            Console.Write("출력 문자열 ==> ");

            if (!str.StartsWith("("))
                Console.Write("(");

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("{0}", str[i]);
            }

            if (!str.EndsWith(")"))
                Console.Write(")");
            Console.WriteLine();
        }
    }
}
