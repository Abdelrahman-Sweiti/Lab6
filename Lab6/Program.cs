

namespace Lab6
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog(12,12,true);
            Animal animal2 = new Cow(12, 12, true);


            animal.MakeSound(); 
            animal.Eat();
            animal.Introduce(11,11);
            animal2.MakeSound();
            animal2.Eat();
        }
    }
}