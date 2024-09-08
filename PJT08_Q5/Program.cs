using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_Q5
{
    internal class Program
    {
        // 수 10개를 입력받은 뒤, 이를 42로 나눈 나머지를 구한다. 그 다음 서로 다른 값이 몇개있는지 출력하는 프로그램을 작성하시오.
        static int Counting(int[] ary, int value)
        {
            int count = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == value) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            
            int[] ary = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] rem = new int[ary.Length];
            for (int i = 0; i < ary.Length; i++)
            {
                rem[i] = ary[i]%42;
            }

            int count = 0;

            for (int i = 0; i< 42; i++)
            {
                if(Counting(rem, i) >0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
