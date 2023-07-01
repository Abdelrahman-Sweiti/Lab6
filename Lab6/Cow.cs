using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Cow : Mammals
    {


        public Cow(int height, int width, bool MilkFeed) : base(height, width, MilkFeed)
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



    }
}
