using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT03_Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inStr = "";

            Console.Write("문자열을 입력 : ");
            inStr = Console.ReadLine();

            for (int i = inStr.Length - 1; i >= 0; i--)
            // for (int i = 0; i < inStr.Length; i++)
            {
                if(i%2 ==0)
                    Console.Write("*");
                else
                    Console.Write(inStr[i]);
            }

            Console.WriteLine();
        }
    }
}
