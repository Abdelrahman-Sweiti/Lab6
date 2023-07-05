using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Cow : Mammals
    {
        public override bool MilkFeed => true;

        public override string name => "Cow";

        public Cow(int height, int width ) : base(height, width)
        {
        }

        

        public override void MakeSound()
        {
            Console.WriteLine("Moo Moo");
        }


        public override void Eat()
        {
            Console.WriteLine("Cows eats grass and Vegtables ");
        }

        public override void IsDangerous()
        {
            Console.WriteLine("Cows are not dangerous , they are friendly ");        }

        public override void Introduce(int a, int b)
        {
            Console.WriteLine($"this Cow height is {a} and it width {b}");
        }

    }
}
