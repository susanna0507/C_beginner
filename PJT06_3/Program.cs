using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("안녕하세요?");
                Console.WriteLine("##또 안녕하세요?##");
            }

            Console.WriteLine();

            for (i = 0; i < 3; i++)
                Console.WriteLine("안녕하세요?");
                Console.WriteLine("##또 안녕하세요?##");
            
        }
    }
}
