using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_8
{
    class Car
    {
        private int speed;  // 인스턴스 변수
        public static int count = 0; // 클래스 변수

        public Car() 
        {
            count++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("인스턴스 생성 전의 count ==> {0}.", Car.count);

            Car myCar1 = new Car();
            Console.WriteLine("인스턴스 생성 전의 count ==> {0}.", Car.count);

            Car myCar2 = new Car();
            Console.WriteLine("인스턴스 생성 전의 count ==> {0}.", Car.count);
        }
    }
}

