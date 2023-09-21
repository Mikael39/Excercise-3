using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Bird : Animal
    {
        //Här stoppar vi in 13
        int numberOfFeathers;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + numberOfFeathers;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Chirp Chirp");
        }

        public int NumberOfFeathers
        {
            get { return numberOfFeathers; }
            set
            {
                numberOfFeathers = value;
            }
        }

        // vi lägger in en ny getset för  13 här

        //Inuti konstruktorn lägger vi till 13
        public Bird(int numberOfFeathers, string animalName, string color, double height, double weight, string primaryLocation) : base(animalName, color, height, weight, primaryLocation)
        {
           NumberOfFeathers = numberOfFeathers;
        }
    
    }
}
