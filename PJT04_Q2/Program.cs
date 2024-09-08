using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT04_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("연도를 입력하세요 : ");
            year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || year % 400 == 0)
            {
                Console.WriteLine("{0}년은 윤년입니다", year);
            }
            else
            {
                Console.WriteLine("{0}년은 평년입니다", year);
            }
        }
    }
}
