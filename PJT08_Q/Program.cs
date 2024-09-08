using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 길이 카운트와 거꾸로 출력
            /*
            string str;

            Console.Write("문자열 입력 ==>");
            str = Console.ReadLine();

            int lower = 0, upper = 0, digit = 0, korean = 0, etc = 0;
            foreach (char c in str)
            {
                if (Char.IsLower(c)) lower++;
                else if (Char.IsUpper(c)) upper++;
                else if (Char.IsDigit(c)) digit++;
                else if ('가' <= c && c <= '힣') korean++;
                else etc++;
                    
            }
            Console.WriteLine("소문자:{0}, 대문자:{1}, 숫자:{2}, 한글:{3}, 기타:{4}", lower, upper, digit, korean, etc);

            Console.Write("거꾸로 출력 ==> ");
            for (int i = str.Length - 1; i >=  0; i--)
            {
                Console.Write(str[i]);
            }
            */


            // 문자열 입력 ==> ~~~~~~~~~~(영어 대소문자만 입력받는다고 가정)
            // 대소문자에 관계 없이 문자별로 몇 개 나왔나 카운팅 -> 그래프로 표현
            // Hello C# Pro -> a 0 b 0 c 1 ...e 1 h 1.... // 전부 대문자 또는 소문자로 바꿔버리면 쉽게 처리 가능

            

            Console.Write("문자열 입력 ==>");
            string str = Console.ReadLine();
            string str2 = str.ToLower();

            int[] count = new int[26];

            foreach (char c in str2)
            {
                if (char.IsLower(c))
                {
                    count[c - 97]++;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)(i + 97) + " ");
                for (int j = 0; j < count[i]; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

        }
    }
}
