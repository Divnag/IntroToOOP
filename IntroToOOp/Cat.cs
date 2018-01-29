using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOp
{
    class Cat
    {
        //I need Staes
        //fields
        private string hairLength;
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

//properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        //constructors( Method)
        public Cat()
        {
            //I need Behaviour
            //default constructors
            //takes no parameters
        }

        public Cat(string name, int age, string furColor)
        {
            //this refer to class.
            //name=catName
            this.name = name;
            this.age = age;
            this.furColor = furColor;

        }

        public Cat(int age, bool isHungry)
        {
            //this refer to class.
            //name=catName
            this.age = age;
            this.isHungry = isHungry;
            

        }

        //Method
        public void Eat()
    {
            //if(IsHungry)means its true
        if (isHungry)
        {
            isHungry = false;
        }

        Console.WriteLine("Is the cat hungry? " + isHungry);
    }


        public void Meow()
        {
            // "\a " makes bell sound
            Console.WriteLine("\a");
        }
        public string HairBall()
        {
            if(hairLength=="too long")
            {
                return (this.name + " has hairball");

            }
            else
            {
                return (this.name + " is nicely groomed");
            }
        }

}
}
