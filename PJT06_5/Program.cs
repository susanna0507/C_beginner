using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hap = 0;

            for (int i = 0; i < 11; i++)
            {
                hap += i;
            }

            Console.WriteLine("1부터 10까지의 합 : {0}", hap);
        }
    }
}
