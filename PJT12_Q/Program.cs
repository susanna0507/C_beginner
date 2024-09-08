using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT12_Q
{
    interface Mammal
    {
        void baby();
    }
    interface Fish
    {
        void move();
    }

    class Whale : Mammal, Fish
    {
        public void baby()
        {
            Console.WriteLine("고래는 새끼를 낳습니다");
        }
        public void move()
        {
            Console.WriteLine("물고기는 헤엄치며 움직입니다");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Whale whale1 = new Whale();
            whale1.move();
            whale1.baby();
        }
    }
}
