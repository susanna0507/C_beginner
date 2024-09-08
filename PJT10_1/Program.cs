using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PJT09_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader inFp; // 입력파일
            string inStr;  // 읽어올 문자열

            inFp = new StreamReader("C:\\Users\\Administrator\\Desktop\\data1.txt");

            // 파일 내용이 3줄이기 때문에 3번 ReadLine함
            /*inStr = inFp.ReadLine();
            Console.WriteLine(inStr);

            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);

            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);
            */
            int count = 1;
            while (true)
            {
                
                inStr = inFp.ReadLine();
                if(inStr == null) break;
                Console.WriteLine(count + ":" + inStr);    
                count++;
            }


            inFp.Close();
        }
    }
}
