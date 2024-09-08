using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int hap;

            Console.Write("1번째 숫자를 입력하세요 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("2번째 숫자를 입력하세요 : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("3번째 숫자를 입력하세요 : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("4번째 숫자를 입력하세요 : ");
            d = int.Parse(Console.ReadLine());

            hap = a + b + c + d;

            Console.WriteLine("합계 => {0}", hap);
        }
    }
}
