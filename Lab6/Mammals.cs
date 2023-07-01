using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Mammals : Animal
    {
        public bool MilkFeed { get; set; }



        public Mammals(int height, int width,bool MilkFeed) : base(height, width)
        {
            MilkFeed = MilkFeed;
        }


        public override void Eat()
        {
            Console.WriteLine("this animal eats !");
        }

    }
}
