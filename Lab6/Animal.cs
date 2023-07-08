using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
  public abstract   class Animal : IWalkable, ISwimmable
    {
        public Animal(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Introduce(int a,int b) { }

        public virtual void MakeSound() { }
        public virtual void Eat() { }
         public void Sleep() {

            Console.WriteLine("this Animal do sleep !");
        }

        public abstract void Walk();
        public abstract void Swim();
    }
}
