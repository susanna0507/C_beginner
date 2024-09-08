using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT11_Q2
{
    class  Pet
    {
        private int age;
        private string type;
        public static int count = 0;

        public Pet(string type, int age)
        {
            this.age = age;
            this.type = type;
        }

        public int getAge()
        {
            return this.age;
        }

        public string getType()
        {
            return this.type;
        }

        public static int getCount()
        {
            return count;
        }

        public void move()
        {
            Console.WriteLine("{0}가 움직입니다.", this.type);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet("강아지", 8);
            Pet.count++;
            Pet pet2 = new Pet("고양이", 13);
            Pet.count++;

            pet1.move();
            pet2.move();

            Console.WriteLine("{0}은 {1}개월입니다.", pet1.getType(), pet1.getAge());
            Console.WriteLine("{0}은 {1}개월입니다.", pet2.getType(), pet2.getAge());
            Console.WriteLine("현재 우리집 반려동물 수는 {0}마리입니다", Pet.getCount());
        }
    }
}
