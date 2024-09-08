using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_3
{
    class Car
    {
        private string color;
        private int speed;

        public void UpSpeed(int value)
        {
            speed = speed + value;
        }

        public void DownSpeed(int value)
        {
            speed = speed - value;
        }

        public string GetColor()
        {
            return color;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public string SetColor(string color)
        {
            return this.color = color;
        }
        public int SetSpeed(int speed)
        {
            return this.speed = speed;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.SetColor("빨강");
            myCar1.SetSpeed(0);


            myCar1.UpSpeed(30);
            Console.WriteLine("자동차1의 색상은 {0}이며, 현재 속도는 {1}km 입니다", myCar1.GetColor(), myCar1.GetSpeed());

        }
    }
}