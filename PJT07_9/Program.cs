using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ary = new int[3, 4];

            ary[0, 0] = 1; ary[0, 1] = 2;ary[0,2] = 3; ary[0,3] = 4;
            ary[1, 0] = 5; ary[1, 1] = 6; ary[1, 2] = 7; ary[1, 3] = 8;
            ary[2, 0] = 9; ary[2, 1] = 10; ary[2, 2] = 11; ary[2, 3] = 12;

            Console.WriteLine("ary[0,0]부터 ary[2,3]까지 출력");

            Console.WriteLine("{0, 3:D}{1, 3:D}{2, 3:D}{3, 3:D}", ary[0,0], ary[0, 1], ary[0, 2], ary[0, 2]);
            Console.WriteLine("{0, 3:D}{1, 3:D}{2, 3:D}{3, 3:D}", ary[1, 0], ary[1, 1], ary[1, 2], ary[1, 2]);
            Console.WriteLine("{0, 3:D}{1, 3:D}{2, 3:D}{3, 3:D}", ary[2, 0], ary[2, 1], ary[2, 2], ary[2, 3]);
        }
    }
}
