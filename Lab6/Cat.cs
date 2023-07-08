using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Cat : Mammals
    {
        public override bool MilkFeed => true;

        public override string name => "Cat";

        public Cat(int height, int width) : base(height, width)
        {
        }


        public override void IsDangerous()
        {
            Console.WriteLine("some Cats are dangerous and some are not , its better to have caution when dealing with them ");
        }


        public override void MakeSound()
        {

            Console.WriteLine("Meow Meow");

        }

        public override void Eat()
        {
            Console.WriteLine("Cats mainly eat meat but also can eat other things such as tuna or made cat food");
        }


        public override void Introduce(int a, int b)
        {
            Console.WriteLine($"this Cat height is {a} and it width {b}");
        }


        public override void Swim()
        {
            Console.WriteLine("Cat is swimming");
        }

        public override void Walk()
        {
            Console.WriteLine("Cat is walking");
        }

    }
}
