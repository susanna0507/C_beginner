using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = { 100, 200, 300, 400 };
            int[] bb = new int[] { 100, 200, 300 };
            int[] cc;
            cc = new int[] { 100, 200};
            int[] dd = new int[1];
            dd[0] = 100;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("aa[{0}] ==> {1}\t", i, aa[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("bb[{0}] ==> {1}\t", i, bb[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.Write("cc[{0}] ==> {1}\t", i, cc[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 1; i++)
            {
                Console.Write("dd[{0}] ==> {1}\t", i, dd[i]);
            }

            Console.WriteLine();

        }
    }
}
