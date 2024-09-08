using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT05_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;

            Random rnd = new Random();

            for (int i = 0; i < 5; i++) 
            {
                score = rnd.Next(0, 100);
                Console.Write("취득점수: " + score + " ==>");

                if (score >= 90)
                    Console.WriteLine("A");
                else
                    if (score >= 80)
                        Console.WriteLine("B");
                    else
                        if (score >= 70)
                            Console.WriteLine("C");
                        else
                            if (score >= 60)
                                Console.WriteLine("D");
                            else
                                Console.WriteLine("F");

            }

        }
    }
}
