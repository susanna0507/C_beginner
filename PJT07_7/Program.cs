using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 입력할 때는 인덱스 방식
            // 출력할 때는 foreach 방식
            //int[] aa = { 10, 20, 30 };

            //Console.WriteLine("현 배열 크기 => {0}", aa.Length);
            //Console.Write("현 배열 내용 =>");
            ////for (int i = 0; i < aa.Length; i++)
            ////    Console.Write("{0, 3:D}", aa[i]);
            //Console.WriteLine();

            //Array.Resize(ref aa, 5);

            //Console.WriteLine("새 배열 크기 => {0}", aa.Length);
            //Console.Write("새 배열 내용 =>");
            ////for (int i = 0; i < aa.Length; i++)
            ////    Console.Write("{0, 3:D}", aa[i]);
            //Console.WriteLine();



            int[] aa = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++) 
                Console.WriteLine(aa[i]);

            foreach (int i in aa)
                Console.WriteLine(i);

            double[] bb = { 1, 2, 3, 4 };
            foreach (double i in bb)
            {
                Console.WriteLine(i);
            }
            {
                
            }
        }
    }
}
