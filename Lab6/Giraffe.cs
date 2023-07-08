using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Giraffe : Mammals
    {
        public override bool MilkFeed => true;

        public override string name => "Giraffe";

        public Giraffe(int height, int width) : base(height, width)
        {
        }


        public override void IsDangerous()
        {
            Console.WriteLine("Elephants are not dangerous in general but sometimes go berserk if you try to attack them or steal their babies ");
        }


        public override void MakeSound()
        {

            Console.WriteLine("Giraffes dont have a sound");

        }

        public override void Eat()
        {
            Console.WriteLine("Giraffes eats green grass fruits and vegtables");
        }


        public override void Introduce(int a, int b)
        {
            Console.WriteLine($"this Giraffe height is {a} and it width {b}");
        }

        public override void Swim()
        {
            Console.WriteLine("The Giraffes cant swim");
        }

        public override void Walk()
        {
            Console.WriteLine("the Giraffe is walking");
        }


    }
}
