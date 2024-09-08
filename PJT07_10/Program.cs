using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] ary = new int[3, 4];
            //int value = 1;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int k = 0; k < 4; k++)
            //    {
            //        ary[i, k] = value;
            //        value++;
            //    }
            //}
            //Console.WriteLine("ary[0,0]부터 ary[2,3]까지 출력");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int k = 0; k < 4; k++)
            //    {
            //        Console.Write(ary[i, k] + " "); 
            //    }
            //    Console.WriteLine();
            //}


            // 4행 5열짜리 정수를 저장하는 배열을 만들어보기. 단, 출력은 거꾸로

            // 행(row)의 수 입력:
            // 열(column)의 수 입력:

            int a;
            a = int.Parse(Console.ReadLine());

            int b;
            b = int.Parse(Console.ReadLine());

            int[,] ary = new int[a, b];
            int value = 1;

            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {

                    ary[i, k] = value;
                    value += 2;
                }
            }
            Console.WriteLine("ary[0,0]부터 ary[{0},{1}]까지 출력", a, b);

            for (int i = a-1; i >= 0; i--)
            {
                for (int k = b-1; k >=0; k--)
                {
                    Console.Write(ary[i, k] + " "); 
                }
                Console.WriteLine();
            }

        }
    }
}
