using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_Q3
{
    internal class Program
    {
        static int Minimum(int[] ary)
        {
            int min = ary[0];
            for (int i = 1; i < ary.Length; i++)
            {
                if (min > ary[i]) min = ary[i];
            }
            return min;
        }
        static int Maximum(int[] ary)
        {
            int max = ary[0];
            for (int i = 1; i < ary.Length; i++)
            {
                if (max < ary[i]) max = ary[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] ary = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(Minimum(ary) + " " + Maximum(ary));
        }
    }
}
