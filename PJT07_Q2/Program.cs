using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[0];

            while (true)
            {
                Console.Write("숫자를 입력하세요(0은 종료) : ");
                int num = int.Parse(Console.ReadLine());
                if(num == 0) break;

                Array.Resize(ref a, a.Length + 1);
                a[a.Length - 1] = num;
            }

            int hap = 0;
            foreach (int data  in a)
            {
                hap += data;
            }

            double avg = (double)hap / a.Length;

            Console.WriteLine("합계 ==> {0}", hap);
            Console.WriteLine("평균 ==> {0}", avg);


        }
    }
}
