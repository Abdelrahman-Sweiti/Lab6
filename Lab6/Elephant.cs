using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Elephant : Mammals
    {
        public override bool MilkFeed => true;

        public override string name => "Elephant";

        public Elephant(int height, int width) : base(height, width)
        {
        }


        public override void IsDangerous()
        {
            Console.WriteLine("Elephants are not dangerous in general but sometimes go berserk if you try to attack them or steal their babies ");
        }


        public override void MakeSound()
        {

            Console.WriteLine("Elephant's Sounds");

        }

        public override void Eat()
        {
            Console.WriteLine("Elephants eats green grass fruits and vegtables");
        }


        public override void Introduce(int a, int b)
        {
            Console.WriteLine($"this Elephant height is {a} and it width {b}");
        }


    }
}
