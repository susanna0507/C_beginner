using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, C#, Programming";
            string[] str2 = str1.Split(',', 2);

            foreach (string i in str2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
