using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 배열의 크기 입력 :
            // 힌트 : 배열의 크기 지정에 변수를 넣을 수 있음
            int size = int.Parse(Console.ReadLine());

            int[] aa = new int[size];

            int hap = 0;


            //for (int i = 0; i <= size - 1; i++)
            //{
            //    Console.WriteLine("{0}번째 숫자를 입력하세요 : ", i + 1);
            //    aa[i] = int.Parse(Console.ReadLine()); 
            //}


            // hap = aa[0] +aa[1] + aa[2] + aa[3] ;
            //for (int i = 0; i < size; i++)
            //{
            //    hap += aa[i];
            //}

            // for 문을 while 문으로
            int i = 0;

            while (i <= size - 1)
            {
                Console.WriteLine("{0}번째 숫자를 입력하세요 : ", i + 1);
                aa[i] = int.Parse(Console.ReadLine());
                i++;
            }

            while (i < size )
            {
                hap += aa[i];
                i++;
            };
            

            Console.WriteLine("합계 => {0}", hap);
        }
    }
}
