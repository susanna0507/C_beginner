using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C# Prigramming";
            string str2 = "C# IT CookBook";
            string str3 = "C# Programming";

            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str2.CompareTo(str1));
            Console.WriteLine(str1.CompareTo(str3));
        }
    }
}
