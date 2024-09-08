using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_Q7
{
    internal class Program
    {
        // 입력과 같이 9X9 격자판에 쓰여진 81개의 자연수 또는 0이 주어질 떄, 이들 중 최댓값을 찾고
        // 그 최댓값이 몇 행 몇 열에 위치한 수인지 구하는 프로그램을 작성하시오.

        // - 2차원 배열을 매개변수로 받아 최댓값을 반환하는 메소드
        // - 2차원 배열과 수를 받아 해당 수의 행과 열 위치를 배열로 저장해 반환하는 메소드
        static int Maximum(int[,] ary)
        {
            int max = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (max < ary[i, j]) max = ary[i, j];
                }
            }
            return max;
        }
        static int[] Position(int[,] ary, int value)
        {
            int[] pos = new int[2];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (ary[i, j] == value)
                    {
                        pos[0] = i + 1;
                        pos[1] = j + 1;
                    }
                }
            }
            return pos;
        }
        static void Main(string[] args)
        {
            int[,] ary = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < 9; j++)
                {
                    ary[i, j] = int.Parse(line[j]);
                }
            }

            int max = Maximum(ary);
            int[] pos = Position(ary, max);
            Console.WriteLine(max);
            Console.WriteLine(pos[0] + " " + pos[1]);
        }
    }
}
