using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PJT10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inStrAry;
            Console.Write("파일명 입력: ");

            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                inStrAry = File.ReadAllLines(filename);

                int count = 1;
                foreach (string line in inStrAry)
                {
                    Console.WriteLine(count + "/" + inStrAry.Length + "행 : " + line);
                    count++;
                }
            }
            else
            {
                Console.WriteLine(filename + "이 존재하지 않습니다");
            }
        }
    }
}
