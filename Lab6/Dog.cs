using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Dog : Mammals
    {


        public Dog(int height, int width, bool MilkFeed) : base(height, width, MilkFeed)
        {
        }


        public override void MakeSound() {

            Console.WriteLine("Woof Woof");
        
        }

        public override void Eat()
        {
            Console.WriteLine("Dogs eats meat and made dog's food !");
        }


        public override void Introduce(int a, int b)
        {
            Console.WriteLine($"this dog height is {a} and it width {b}");
        }


    }
}
