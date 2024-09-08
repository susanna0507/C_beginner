using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_16
{
    internal class Program
    {
        static int a = 100;
        static void Func1()
        {
            int a = 200;
            Console.WriteLine("Func1()에서 a의 값=> {0}", a);
        }

        static void Func2() 
        {
            a++;
            Console.WriteLine("Func2()에서 a의 값=> {0}", a);
        }


        static void Func3()
        {
            int a=400;
            Console.WriteLine("Func3()에서 a의 값=> {0}", a);
            a++;
        }

        static void Main(string[] args)
        {
            Func1();
            Func2();
            Func3();
            Func3();
            Console.WriteLine("Main()에서 a의 값=> {0}", a);
        }
    }
}
