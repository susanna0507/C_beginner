using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_12
{
    internal class Program
    {
        static void CoffeeMachine(int button) // 메소드를 사용하는 이유 : 반복되는 코드를 줄이기 => 모듈화
        {
            Console.WriteLine();
            Console.WriteLine("# 1.(자동으로) 뜨거운 물을 준비한다");
            Console.WriteLine("# 2.(자동으로) 종이컵을 준비한다");

            switch (button)
            {
                case 1: 
                    Console.WriteLine("# 3.(자동으로) 보통 커피를 준비한다");
                    break;
                case 2: 
                    Console.WriteLine("# 3.(자동으로) 설탕 커피를 준비한다");
                    break;
                case 3: 
                    Console.WriteLine("# 3.(자동으로) 블랙 커피를 준비한다");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
            return;
        }


        static void Main(string[] args)
        {
            string[] names = { "A", "C#", "JAVA" };
            int coffee;

            foreach (string i in names)
            {

                Console.Write("{0}님 어떤 커피 드릴까요? (1:보통, 2:설탕, 3:블랙)", i);
                coffee = int.Parse(Console.ReadLine());

                CoffeeMachine(coffee);

                Console.WriteLine("{0}님 커피 여기 있습니다", i);

            }
        }
    }
}
