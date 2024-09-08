using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "C#을 공부하는 중, C#은 재밌어요. C# 짱!";

            Console.WriteLine("문자열 ==>" + str);

            Console.Write("제일 처음 나오는 C# 위치 ==> ");
            Console.WriteLine(str.IndexOf("C#"));

            Console.Write("마지막에 나오는 C# 위치 ==> ");
            Console.WriteLine(str.LastIndexOf("d#"));  // 못찾으면 -1 

            string str1 = "C#을 공부 중... C#은 즐겁습니다. ^^";
            //string str2 = str1.Replace("C#", "씨샵");
            string str2 = str.Substring(0, 2);
            string str3 = str1.Substring(4);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
