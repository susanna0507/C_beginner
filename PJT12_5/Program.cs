using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT12_5
{
    class Car
    {
        protected string color;
        public int speed;
    }

    class Sedan : Car
    {
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return color;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();

            sedan1.SetSpeed(188);
            sedan1.SetColor("빨강");
            Console.WriteLine("승용차 속도 ==> {0}", sedan1.speed);
            // Console.WriteLine("승용차 속도 ==> {0}", sedan1.color);
            Console.WriteLine("승용차 색상 ==> {0}", sedan1.GetColor());
        }
    }
}
