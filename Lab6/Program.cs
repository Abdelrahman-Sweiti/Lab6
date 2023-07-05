

namespace Lab6
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog(12,12);
            Animal animal2 = new Cow(12, 12);
            Animal animal3 = new Cat(12, 12);
            Animal animal4 = new Elephant(12, 12);
            Animal animal5 = new Giraffe(12, 12);


            animal.MakeSound(); 
            animal.Eat();
            animal.Introduce(11,11);

            animal2.MakeSound();
            animal2.Eat();
            animal2.Introduce(11, 11);

            animal3.MakeSound();
            animal3.Eat();
            animal3.Introduce(12, 12);

            animal4.MakeSound();
            animal4.Eat();
            animal4.Introduce(13, 13);

            animal5.MakeSound();
            animal5.Eat();
            animal5.Introduce(14, 14);

        }
    }
}