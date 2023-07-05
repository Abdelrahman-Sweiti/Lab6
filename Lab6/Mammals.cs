using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Mammals : Animal
    {
        public abstract bool MilkFeed { get;  }
        public abstract string name { get; }


        public Mammals(int height, int width) : base(height, width)
        {
            
        }

        public abstract void IsDangerous() ;


        public override void Eat()
        {
            Console.WriteLine("this animal eats !");
        }

    }
}
