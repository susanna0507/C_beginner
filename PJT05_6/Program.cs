using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT05_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("값을 입력하세요 : ");
            a = int.Parse(Console.ReadLine());

            if ((a % 3 == 0) || (a % 5 == 0)) 
            {
                Console.WriteLine("3의 배수 또는 5의 배수를 입력했군요");
            }
            else
            {
                Console.WriteLine("3의 배수 또는 5의 배수가 아닙니다.");
            }
        }
    }
}
