using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_Q4
{
    internal class Program
    {
        static int Counting(int[] ary, int value)
        {
            int count = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == value) count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            // 총 N개의 정수가 주어졌을 때, 정수 v가 몇개인지 구하는 프로그램을 작성하시오.
            int N = int.Parse(Console.ReadLine());
            int[] ary = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v = int.Parse(Console.ReadLine());
           
            Console.WriteLine(Counting(ary, v));
        }
    }
}
