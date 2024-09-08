using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_Q6
{
    internal class Program
    {
        // 바구니의 순서를 어떻게 바꿀지 주어졌을 때, M번 바구니의 순서를 역순으로 만든 다음,
        // 바구니에 적혀있는 번호를 가장 왼쪽 바구니부터 출려하는 프로그램을 작성하시오

        // 배열, 시작위치, 끝위치를 매개변수로 받는 바구니 순서를 뒤집는 Flip메소드 만들기
        static void Flip(int[] basket, int start, int end)
        {
            // start = 1, end = 4
            // 1 <-> 4, 2 <-> 3 

            // start = 2, end = 4
            // 2 <-> 4, 3 <-> 3
            for (int i = start; i <= (start + end) / 2; i++)
            {
                int temp = basket[i];
                basket[i] = basket[end - i + start];
                basket[end - i + start] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0]; // 바구니의 개수
            int m = input[1]; // 뒤집는 횟수

            int[] basket = new int[n + 1]; // 0 1 2 3 4 5
            for (int i = 1; i <= n; i++)
            {
                basket[i] = i;
            }
            for (int i = 0; i < m; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int start = input[0];
                int end = input[1];
                Flip(basket, start, end);
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(basket[i] + " ");
            }
        }
    }
}
