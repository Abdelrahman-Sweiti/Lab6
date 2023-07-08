using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Dog : Mammals
    {
        public override bool MilkFeed => true;

        public override string name => "Dog";

        public Dog(int height, int width) : base(height, width)
        {
        }


        public override void IsDangerous()
        {
            Console.WriteLine("some Dogs are dangerous and some are not , its better to have caution when dealing with them ");
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

        public override void Walk()
        {
            Console.WriteLine("The dog is walking.");
        }

        public override void Swim()
        {
            Console.WriteLine("The dog is swimming.");
        }
    }
}
