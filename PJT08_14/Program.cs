using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_14
{
    internal class Program
    {
        static int Plus(int v1, int v2 )
        {
            int result;
            result = v1 +v2;
            return result;
        }

        static void Main(string[] args)
        {
            int hap;
            hap = Plus(100, 200);
            Console.WriteLine("100과 200의 Plus() 메서도 결과는 : {0}", hap);
        }

        
    }
}
