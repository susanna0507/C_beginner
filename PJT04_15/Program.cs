using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT04_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine((n >>1) + "," + ( n>>2) + "," + (n>>3) + "," + (n>>4));
        }
    }
}
