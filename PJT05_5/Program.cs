using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT05_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            if (a < 100)
            {
                Console.WriteLine("100보다 작군요.");
                Console.WriteLine("참이면 이 문장도 보이겠죠?");
            }

            else
            {
                Console.WriteLine("100보다 크군요.");
                Console.WriteLine("거짓이면 이 문장도 보이겠죠?");
            }
            Console.WriteLine("프로그램 끝!");
        }
    }
}
