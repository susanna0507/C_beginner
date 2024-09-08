using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT12_12
{
    interface ICar
    {
        void Run();
    }
    interface ICannon
    {
        void Fire();
    }

    class Tank : ICar, ICannon
    {
        public void Run()
        {
            Console.WriteLine("탱크가 앞으로 쿨러갑니다");
        }
        public void Fire()
        {
            Console.WriteLine("탱크에서 대포를 발사합니다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank tank1 = new Tank();
            tank1.Run();
            tank1.Fire();
        }
    }
}
