using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_7
{
    class Car
    {
        private string color;
        private int speed;

        public Car(string color, int speed)
        {
            this.color = color;
            this.speed = speed;
        }

        public string GetColor()
        {
            return color;
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car("빨강", 0);
            Car myCar2 = new Car("파랑", 30);

            Console.WriteLine("자동차1의 색상은 {0}이며, 현재 속도는 {1}km입니다.", myCar1.GetColor(), myCar1.GetSpeed());
            Console.WriteLine("자동차2의 색상은 {0}이며, 현재 속도는 {1}km입니다.", myCar2.GetColor(), myCar2.GetSpeed());
        }
    }
}
