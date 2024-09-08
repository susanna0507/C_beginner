using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT04_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "100", s2 = "100.123";
            Console.WriteLine(int.Parse(s1) + float.Parse(s2));

            int n1 = 100;
            float n2 = 100.123f;
            Console.WriteLine(n1.ToString() + n2.ToString());
        }
    }
}
