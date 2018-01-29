using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of cat class
            Cat firstCat = new Cat();
            firstCat.Name = "Mr.Fuzzzy";
            Cat secondCat = new Cat("Midnight",14,"black");
            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);
            //calling Eat method on firstCat object
            firstCat.Eat();
            secondCat.Meow();
            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";
            Console.WriteLine(firstCat.HairBall());
            Console.WriteLine(secondCat.HairBall());
            Cat thirdCat = new Cat( 14, true);

            Dog firstDog = new Dog();
            firstDog.HairLength = "short";
            firstDog.Weight = 20;
            Console.WriteLine(firstDog.HairLength);
            firstDog.Run();
            firstDog.Potty();
            Console.WriteLine(firstDog.Weight);
            firstDog.cuddle();
        }
    }
}
