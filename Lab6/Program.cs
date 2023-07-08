

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
            Fish Fish1 = new Fish(12, 12);  

            animal.MakeSound(); 
            animal.Eat();
            animal.Introduce(11,11);
            animal.Walk();
            animal.Swim();

            animal2.MakeSound();
            animal2.Eat();
            animal2.Introduce(11, 11);
            animal2.Walk();
            animal2.Swim();

            animal3.MakeSound();
            animal3.Eat();
            animal3.Introduce(12, 12);
            animal3.Walk();
            animal3.Swim();

            animal4.MakeSound();
            animal4.Eat();
            animal4.Introduce(13, 13);
            animal4.Walk();
            animal4.Swim();

            animal5.MakeSound();
            animal5.Eat();
            animal5.Introduce(14, 14);
            animal5.Walk();
            animal5 .Swim();

            Fish1.Swim();

        }
    }
}