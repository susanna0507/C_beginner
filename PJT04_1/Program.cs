using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int v1 = 5, v2 = 3;

            num = v1 + v2;
            Console.WriteLine("{0:D} + {1:D} = {2:D}", v1, v2, num);

            num = v1 - v2;
            Console.WriteLine("{0:D} - {1:D} = {2:D}", v1, v2, num);

            num = v1 * v2;
            Console.WriteLine("{0:D} * {1:D} = {2:D}", v1, v2, num);

            num = v1 / v2;
            Console.WriteLine("{0:D} / {1:D} = {2:D}", v1, v2, num);

            num = v1 % v2;
            Console.WriteLine("{0:D} % {1:D} = {2:D}", v1, v2, num);

        }
    }
}
