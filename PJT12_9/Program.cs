using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT12_9
{
    abstract class Car
    {
        int speed = 0;

        public void UpSpeed(int speed)
        {
            this.speed = speed;
        }

        public abstract void Work();
    }

    class  Sedan : Car 
    {
        public override void Work()
    {
        Console.WriteLine("승용차가 사람을 태우고 있습니다");
    }
    }

    class Truck : Car
    {
        public override void Work()
        {
            Console.WriteLine("트럭이 짐을 싣고 있습니다");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();
            sedan1.Work();

            Truck truck1 = new Truck();
            truck1.Work();

            truck1.UpSpeed(200);
        }
    }
}
