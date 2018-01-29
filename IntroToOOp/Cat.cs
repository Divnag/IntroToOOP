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

        public Cat()
        {
            //I need Behaviour
            //default constructors
            //takes no parameters
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;

        }


    
    public void Eat()
    {
        if (isHungry)
        {
            isHungry = false;
        }

        Console.WriteLine("Is the cat hungry? " + isHungry);
    }

}
}
