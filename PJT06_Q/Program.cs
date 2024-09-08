using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("키를 입력하세요(단위: cm) : ");
                double h;
                while (!double.TryParse(Console.ReadLine(),out h))
                {
                    Console.Write("유효한 숫자를 입력하세요: ");
                }

                if (h > max)
                {
                    max = h;
                }
                if (h < min)
                {
                    min = h;
                }
                sum += h;
            }

            double average = sum / 5;
            Console.WriteLine($"평균 : {average}cm, 최대 : {max}cm, 최소 : {min}cm");  

        }
    }
}
