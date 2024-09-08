using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter outFp;
            string outStr;
            string fName;

            outFp = new StreamWriter("C:\\Users\\Administrator\\Desktop\\data2.txt");

            while (true)
            {
                Console.Write("내용 입력 : ");
                outStr = Console.ReadLine();

                if (outStr!= "")
                {
                    outFp.WriteLine(outStr);
                }
                else
                {
                    break;
                }

                outFp.Close();
                Console.WriteLine("---정상적으로 파일에 써짐");
            }
        }
    }
}
