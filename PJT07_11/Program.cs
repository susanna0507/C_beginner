using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] a = new int[3, 4];
            //int value = 1;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        a[i, j] = value;
            //        value++;
            //    }
            //}

            //int[,,] b = new int[2, 3, 4];
            //int value1 = 1;

            //for (int k = 0; k < 2; k++)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write(b[k, i, j] + "");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            // 5개 아파트, 10층, 한 층에는 6개의 호실
            // 무한루프를 통해서 입주자가 원하는 동 층 호를 입력 받음
            // 만약, 해당 호실이 비어있다면 입주
            // 비어있지 않은 경우, 입주 X
            // 동 층 호 입력 : 3 5 1
            // 입주완료되었습니다
            // 동 층 호 입력 : 3 5 1
            // 입주실패되었습니다

            int[,,] apt = new int[5, 10, 6];
            while (true)
            {
                Console.Write("동 층 호 입력 :");
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = input[0] - 1; // 동
                int b = input[1] - 1; // 층
                int c = input[2] - 1; // 호

                if (apt[a, b, c] == 0)
                {
                    Console.WriteLine("입주완료되었습니다.");
                    apt[a, b, c] = 1;
                }
                else
                {
                    Console.WriteLine("입주실패하였습니다");
                }
            }


        }
    }
}
