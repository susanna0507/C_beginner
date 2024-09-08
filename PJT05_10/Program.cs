using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT05_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("1~4 중에 선택하세요 : ");
            a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1: 
                    Console.WriteLine("1을 선택했다");
                    break;

                case 2: 
                    Console.WriteLine("2을 선택했다");
                    break;

                case 3: 
                    Console.WriteLine("3을 선택했다");
                    break;

                case 4:
                    Console.WriteLine("4을 선택했다");
                    break;

                default: 
                    Console.WriteLine("이상한 것을 선택했다");
                    break;
            }

        }
    }
}
