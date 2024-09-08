using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT05_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                score = rand.Next(0, 100);
                Console.Write("취득점수" + score + "==>");

                switch (score / 10)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("A");
                        break;
                    case 8:
                        Console.WriteLine("B");
                        break;
                    case 7:
                        Console.WriteLine("C");
                        break;
                    case 6:
                        Console.WriteLine("D");
                        break;
                    default:
                        Console.WriteLine("F");
                        break;


                }
            }
        }
    }
}
