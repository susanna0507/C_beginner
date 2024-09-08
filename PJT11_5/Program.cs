using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_5
{
    class Car
    {
        private int speed = 0; //필드

        public int Speed // 속성
        {
            get { return speed; }
            set { speed = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.Speed = 100; 
            Console.WriteLine("차량속도 ==> {0}", myCar1.Speed);
        }
    }
}
