using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            while (true)
            {
                Console.Write("값1 입력 : ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("값2 입력 : ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            }
        }
    }
}
