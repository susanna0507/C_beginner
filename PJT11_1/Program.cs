using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_1
{
    class Car
    {
        public string color;
        public int speed;

        public void UpSpeed(int value)
        {
            speed = speed + value;
        }

        public void DownSpeed(int value)
        {
            speed = speed - value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.color = "빨강";
            myCar1.speed = 0;

            Car myCar2 = new Car();
            myCar2.color = "파랑";
            myCar2.speed = 0;

            Car myCar3 = new Car();
            myCar3.color = "노랑";
            myCar3.speed = 0;

            myCar1.UpSpeed(30);
            Console.WriteLine("자동차1의 색상은{0}이며, 현재 속도는 {1}km 입니다", myCar1.color, myCar1.speed);

            myCar2.UpSpeed(60);
            Console.WriteLine("자동차1의 색상은{0}이며, 현재 속도는 {1}km 입니다", myCar2.color, myCar2.speed);

            myCar3.UpSpeed(0);
            Console.WriteLine("자동차1의 색상은{0}이며, 현재 속도는 {1}km 입니다", myCar3.color, myCar3.speed);
        }
    }
}
