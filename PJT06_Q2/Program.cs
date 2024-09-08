using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;

            Console.Write("값을 입력하세요 : ");
            num = int.Parse(Console.ReadLine());

            for (i = 2; i < num; i++)
            {
                if (num % i==0)
                {
                    Console.WriteLine("{0}은 소수가 아닙니다", num);
                    break;
                }
                
            }

            if (i == num)
            {
                Console.WriteLine("{0}은 소수입니다", num);
            }
        }
    }
}
