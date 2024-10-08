﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT06_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guguLine = "";

            for (int i = 2; i < 10; i++)
            {
                guguLine = guguLine + ("  #" + i + "단# ");
            }
            Console.WriteLine(guguLine);

            for (int i = 2; i < 10; i++)
            {
                guguLine = "";
                for (int k = 2; k < 10; k++)
                {
                    guguLine = guguLine + String.Format(" {0}X{1}={2, 2:D} ", k, i, k * i);
                }
                Console.WriteLine(guguLine);
            }
        }
    }
}