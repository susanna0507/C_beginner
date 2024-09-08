using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char[] parking = new char[5];
            //int top = 0;
            //char outCar;


            //parking[top] = 'A';
            //Console.WriteLine("push: " + parking[top]);
            //top++; // push 과정

            //parking[top] = 'B';
            //Console.WriteLine("push: " + parking[top]);
            //top++;

            //parking[top] = 'C';
            //Console.WriteLine("push: " + parking[top]);
            //top++;

            //top --;
            //outCar = parking[top];
            //Console.WriteLine("pop" + outCar); // pop 과정

            //top--;
            //outCar = parking[top];
            //Console.WriteLine("pop" + outCar);

            //top--;
            //outCar = parking[top];
            //Console.WriteLine("pop" + outCar);



            // 무한루프(while true) 상태에서 push(0) 또는 pop(1)을 입력받음
            // 모드 입력 : 0 (push모드) 1(pop 모드)
            // push 모드 -> 숫자를 입력받음(이 숫자를 스택에 push)
            // pop 모드 -> pop 되는 숫자값을 출력
            // view 모드 -> stack 베열에 있는 모든 값을 출력 (foreach 반복문 사용)
            int[] stack = new int[5];
            int top = 0;
            int outNumber;
            
            while (true)
            {
                Console.Write("모드입력 : ");
                int mode = int.Parse(Console.ReadLine());

                if (mode == 0) // push -> 배열의 크기보다 넘어서는 경우 -> top이 배열의 크기일 때
                {
                    // push에서 stack의 길이에 제한을 받지 않고 계속 배열의 크기를 늘린다
                    if (top == stack.Length)
                    {
                        //Console.WriteLine("공간이 부족합니다!");
                        //continue;
                        Array.Resize(ref stack, stack.Length + 1);
                    }
                    Console.Write("push 할 값 입력: ");
                    int value = int.Parse(Console.ReadLine());
                    stack[top] = value;
                    top++;
                }

                else if(mode == 1)  // pop -> top이 0일 때 pop이 되는 경우
                {
                    if (top ==0)
                    {
                        Console.WriteLine("pop을 할 값이 없습니다");
                        continue;
                    }
                    top--;
                    outNumber = stack[top];
                    Console.WriteLine("pop : " +outNumber);
                }
                else // view 모드
                {
                    for (int i = 0; i < top; i++)
                    {
                        Console.Write(stack[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
