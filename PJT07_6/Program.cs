using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT07_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = {10, 20, 30, 40, 50};
            int count, size;

            count = aa.Length;
            size = count * sizeof(int);

            Console.WriteLine("배열 aa[]의 요소의 개수는 {0}개 입니다.", count);
            Console.WriteLine("배열 aa[]의 요소의 전체 크기는 {0}바이트 입니다.", size);
        }
    }
}
