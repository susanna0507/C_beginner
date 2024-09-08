using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT05_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 200;

            if (a < 100)
            {
                Console.WriteLine("100보다 작군요");
                Console.WriteLine("거짓이므로 이 문장은 안보이겠죠?");
            }

            Console.WriteLine("프로그램 끝!");
        }
    }
}
