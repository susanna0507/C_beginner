using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            bool numYN = true;

            Console.WriteLine("문자열 입력 ==>");
            str = Console.ReadLine();

            Console.Write(str + " --> ");
            foreach (char c in str )
            {
                if(!Char.IsDigit(c))
                    numYN = false;
            }
            if( !numYN )
                Console.WriteLine("숫자가 아닙니다.");
            else
                Console.WriteLine("숫자입니다.");

            // IsDigit -> 숫자
            // IsUpprt -> 대문자
            // IsLower -> 소문자
            // IsLetter -> 문자
            // IsLetterOrDigit -> 문자 또는 숫자 
        }
    }
}
