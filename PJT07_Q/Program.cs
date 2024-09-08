using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] aa = new int[100];

            //for (int i = 0; i < 100; i++)
            //{
            //    aa[i] = i * 2;
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(aa[i] + " ");
            //}
            //Console.WriteLine();

            //int[] bb = new int[100];
            //for (int i = 0; i < 100; i++)
            //{
            //    bb[i] = aa[99 - i];
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(bb[i] + " ");
            //}
            //Console.WriteLine();



            // aa 배열에 50개 -> 0,3,6,9, .......,147
            // bb 베열에 aa 배열에 저장한 값을 2칸씩 옮기기
            // bb 배열에 저장되는 값은 6, 9, ...., 147, 0, 3
            int move = int.Parse(Console.ReadLine());

            int[] aa = new int[50];

            for (int i = 0; i < 50; i++)
            {
                aa[i] = i * 3;
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(aa[i] + " ");
            }
            Console.WriteLine();

            int[] bb = new int[50];
            for (int i = 0; i < 50; i++)
            {
                if ( i < 50 - move)
                {
                    bb[i] = aa[move + i];
                }
                else
                {
                    bb[i] = aa[i - 50 + move];
                }
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(bb[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
