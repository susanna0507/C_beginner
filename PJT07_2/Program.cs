using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[4];
            int hap;

            Console.Write("1번째 숫자를 입력하세요 : ");
            aa[0] = int.Parse(Console.ReadLine());
            Console.Write("2번째 숫자를 입력하세요 : ");
            aa[1] = int.Parse(Console.ReadLine());
            Console.Write("3번째 숫자를 입력하세요 : ");
            aa[2] = int.Parse(Console.ReadLine());
            Console.Write("4번째 숫자를 입력하세요 : ");
            aa[3] = int.Parse(Console.ReadLine());

            hap = aa[0] + aa[1] + aa[2] + aa[3];

            Console.WriteLine("합계  => {0}", hap);

        }
    }
}
