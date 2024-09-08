using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_17
{
    internal class Program
    {
        /*
        static int[] DrawDice()
        {
            Random rnd = new Random();
            int[] diceAry = new int[rnd.Next(5, 11)];

            for (int i = 0; i < diceAry.Length; i++)
            {
                diceAry[i] = rnd.Next(1, 7);
            }
            return diceAry;
        }
        static void Main(string[] args)
        {
            int[] ary;
            ary = DrawDice();

            Console.Write("{0}회 던졌음 => ", ary.Length);
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }
            Console.WriteLine();
        }
        */

        // 랜덤 3개 같은 숫자
        static int[] DrawDice()
        {
            Random rnd = new Random();
            int[] diceAry = new int[rnd.Next(5, 11)];

            for (int i = 0; i < 3; i++)
            {
                diceAry[i] = rnd.Next(1, 7);
            }
            return diceAry;
        }

        static bool CheckDice(int[] diceAry)
        {
            return diceAry[0] == diceAry[1] && diceAry[1] == diceAry[2];
        }

        static void Main(string[] args)
        {
            int[] ary = DrawDice();
            int count = 1;

            while (true)
            {
                Console.WriteLine("{0}회차 ==> {1} {2} {3}", count, ary[0], ary[1], ary[2]);
                if (CheckDice(ary))
                {
                    Console.WriteLine("종료!");
                    break;
                }
                ary = DrawDice();
                count++;
            }
        }
    }
}
