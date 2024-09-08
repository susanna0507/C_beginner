using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, k;

            i = 0;
            while (i < 9)
            {
                if (i < 5)
                {
                    k = 0;
                    while (k < 4 - i)
                    {
                        Console.Write("  ");
                        k += 1;
                    }
                    k = 0;
                    while (k < i * 2 + 1)
                    {
                        Console.Write('\u2605');
                        k += 1;
                    }
                }
                else
                {
                    k = 0;
                    while (k < i - 4)
                    {
                        Console.Write("  ");
                        k += 1;
                    }
                    k = 0;
                    while (k < (9 - i) * 2 - 1)
                    {
                        Console.Write('\u2605');
                        k += 1;
                    }
                }
                Console.WriteLine();
                i += 1;
            }
        }
    }
}
