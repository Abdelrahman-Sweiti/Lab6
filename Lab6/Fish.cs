using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Fish : Animal
    {
        public Fish(int height, int width) : base(height, width)
        {
        }
        public override void Swim()
        {
            Console.WriteLine("The fish is swimming.");
        }

        public override void Walk()
        {
            Console.WriteLine("Fishs dont talk , they swim !");
        }
    }
}
