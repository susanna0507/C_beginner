using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_18
{
    internal class Program
    {

        static void Func1(int a)
        {
            a = a + 1;
            Console.WriteLine("Func1의 a는" + a);
        }

        static void Func2(ref int a)
        {
            a = a + 1;
            Console.WriteLine("Func2의 a는" + a);
        }

        static void Swap1(int p, int q)
        {
            int temp = p;
            p = q;
            q = temp;
            Console.WriteLine("Swap1 p = " + p + " q = " + q);
        }

        static void Swap2(ref int p, ref int q)
        {
            int temp = p;
            p = q;
            q = temp;
            Console.WriteLine("Swap2 p = " + p + " q = " + q);
        }

        static void Add1(int[] ary)  // ary는 reference 역할을 함
        {
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = ary[i] + 1;
            }
            Console.Write("Add1 ");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 10;  // Main::a = 10
            Func1(a);  // 매개변수로 값을 넘기는 경우
                        // Call By Value 값에 의한 호출
            Console.WriteLine("Main의 a는 " + a);  // 10
            Func2(ref a);  // ref -> reference(참조)  -> Call By Reference
                            // 매개변수로 참조(=메모리 주소)를 넘기는 경우
            Console.WriteLine("Main의 a는" + a); //Main이 바껴서 11임

            int p = 10, q = 20;
            int temp = p;
            p = q;
            q = temp;
            Console.WriteLine("Main p = " + p + " q = " + q);
            // 1) Call By Value를 이용한 교환 -> 교환이 안됨
            Swap1(p, q);
            Console.WriteLine("Swap1 p = " + p + " q = " + q);
            // 2) Call By Reference를 이용한 교환 -> 교환이 됨
            Swap2(ref p, ref q);
            Console.WriteLine("Swap2 p = " + p + " q = " + q);

            int[] ary = { 10, 20, 30, };
            Console.Write("Main");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }
            Console.WriteLine();

            Add1(ary);

            Console.Write("Main");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
