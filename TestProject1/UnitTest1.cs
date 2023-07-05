using Lab6;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckDogIntroduction()
        {
            Animal animal = new Dog(12, 12);
            int height = 11;
            int width = 11;

            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); 
                animal.Introduce(height, width);
                string output = sw.ToString().Trim();

               
                Assert.Equal("this dog height is 11 and it width 11", output);
            }
        }


        [Fact]
        public void CheckCatIntroduction()
        {
            Animal animal = new Cat(12, 12);
            int height = 11;
            int width = 11;


            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                animal.Introduce(height, width);
                string output = sw.ToString().Trim();


                Assert.Equal("this Cat height is 11 and it width 11", output);
            }
        }

        [Fact]
        public void CheckCowIntroduction()
        {
            Animal animal = new Cow(12, 12);
            int height = 11;
            int width = 11;


            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                animal.Introduce(height, width);
                string output = sw.ToString().Trim();


                Assert.Equal("this Cow height is 11 and it width 11", output);
            }
        }

        [Fact]
        public void CheckElephantIntroduction()
        {
            Animal animal = new Elephant(12, 12);
            int height = 11;
            int width = 11;


            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                animal.Introduce(height, width);
                string output = sw.ToString().Trim();


                Assert.Equal("this Elephant height is 11 and it width 11", output);
            }
        }


        [Fact]
        public void CheckGiraffeIntroduction()
        {
            Animal animal = new Giraffe(12, 12);
            int height = 11;
            int width = 11;


            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                animal.Introduce(height, width);
                string output = sw.ToString().Trim();


                Assert.Equal("this Giraffe height is 11 and it width 11", output);
            }
        }



    }







}