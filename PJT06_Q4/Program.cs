using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hap = 0;
            int num1, num2, num3;

            Console.Write("시작 값 입력 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("끝 값 입력 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("증가 값 입력 : ");
            num3 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i+=num3)
            {
                hap += i;
            }

            Console.WriteLine("{0}부터 {1}까지 {2}씩 증가한 합 : {3}", num1, num2, num3, hap);
        }
    }
}
