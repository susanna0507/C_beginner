using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_15
{
    internal class Program
    {
        static int Calc(int v1, char op, int v2, int v3)
        {
            int result;

            switch (op)
            {
                case '+': result = v1 + v2 + v3; break;
                case '-': result = v1 - v2 - v3; break;
                case '*': result = v1 * v2 * v3; break;
                case '/': result = v1 / v2 / v3; break;
                default: result = 0; break;
            }
            return result;
        }

        static void FormulaPrint(int v1, int v2, int v3, char op)
        {
            Console.WriteLine("{0} {1} {2} {1} {3}", v1, op, v2, v3);
            return;
        }
        static void Main(string[] args)
        {
            int res;
            char oper;
            int n1, n2, n3;

            Console.Write("첫번째 숫자를 입력 : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("연산자 (+, -, *, /) : ");
            oper = Console.ReadLine()[0];
            Console.Write("두번째 숫자를 입력 : ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("세번째 숫자를 입력 : ");
            n3 = int.Parse(Console.ReadLine()); 

            res = Calc(n1, oper, n2, n3);
            FormulaPrint(n1, n2, n3, oper);

            Console.WriteLine("계산 결과 : {0}", res);
        }
    }
}
