using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT03_13
{
    internal class Program
    {
        static void Main(string[] args) // 값 대입
        {
            bool boolVar = true;
            int intVar = 0;
            float floatVar = 0.0f;
            char charVar = ' '; 
            string strVar = "";

            boolVar = false;
            intVar = 100;
            floatVar = 123.45f;
            charVar = 'A';
            strVar = "안녕?";

            Console.WriteLine(boolVar.GetType());
            Console.WriteLine(intVar.GetType());
            Console.WriteLine(floatVar.GetType());
            Console.WriteLine(charVar.GetType());
            Console.WriteLine(strVar.GetType());
        }
    }
}
