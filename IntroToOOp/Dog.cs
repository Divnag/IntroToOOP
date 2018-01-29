using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOp
{
    class Dog
    {

        private string hairLength;
        private int height;
        private string runningSpeed;
        private int weight;

        public String HairLength
        {
            get { return this.hairLength; }
                set{ this.hairLength=value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Dog()
        {

        }

        public Dog(string hairLength,int height,string runningSpeed)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
        }

        public void Run()
        {
            runningSpeed = " is slow";
            Console.WriteLine("running speed"+runningSpeed);
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            
            
                weight--;
            
            
        }

        public void cuddle()
        {
            Console.WriteLine("I am Happy");
        }
    }
}
