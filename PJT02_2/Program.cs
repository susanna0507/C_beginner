using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b; // 변수
            int result;

            string str;

            Console.Write("첫번째 계한할 값을 입력하세요. : ");
            str = Console.ReadLine();  // 키보드값 입력 받음(단, 문자열로만 받음)
            a = Convert.ToInt32(str);  // 문자열을 숫자로 변환

            Console.Write("두번째 계한할 값을 입력하세요. : ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            result = a + b;
            Console.WriteLine(a + "+" + b + "=" + result);
        }
    }
}
