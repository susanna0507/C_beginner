using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hap = 0;
            int i;

            i = 1;
            while (i <= 10)
            {
                hap = hap + i;
                i++;
            }

            Console.WriteLine("1에서 10까지의 합: {0}", hap);
        }
    }
}
