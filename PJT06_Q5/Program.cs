using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dan = 0;
            

            Console.Write("몇 단? ");
            dan = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan * i);
            }

            

        }
    }
}
