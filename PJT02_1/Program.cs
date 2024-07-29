using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int result;

            a = 100;
            b = 50;

            result = a + b;
            Console.WriteLine(a + "+" + b + "=" + result); // 100+50=150
            result = a - b;
            Console.WriteLine(a + "-" + b + "=" + result); // 100-50=50
            result = a * b;
            Console.WriteLine(a + "*" + b + "=" + result); // 100*50=5000
            result = a / b;
            Console.WriteLine(a + "/" + b + "=" + result); // 100/50=2
        }
    }
}
