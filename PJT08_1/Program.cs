using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "IT CookBook.C#";
            //int len;

            //len = str.Length;   

            //Console.WriteLine("문자열 : {0}", str);
            //Console.WriteLine("문자열 길이 : {0}", len);

            char[] cArray = { 'C', '#', ' ' };
            string str = "C# Programming";
            int len = str.Length;

            Console.WriteLine("문자열 " + str);
            Console.WriteLine("길이 " + len);
            Console.WriteLine(cArray[0] + " " + str[0]);

            // str문자열에서 m으로 된 문자를 n으로 변경
            for (int i = 0; i < len; i++)
            {
                if (str[i] =='m')
                {
                    Console.Write('n');
                }
                else
                {
                    Console.Write(str[i]);
                }
            }
        }
    }
}
