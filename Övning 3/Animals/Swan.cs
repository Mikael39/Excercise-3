using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Swan : Bird
    {
        int numberOfUgglyDucklings;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + numberOfUgglyDucklings;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("SSshssss");
        }

        public int NumberOfUgglyDucklings
        {
            get { return numberOfUgglyDucklings; }
            set
            {
                numberOfUgglyDucklings = value;
            }
        }
        public Swan(int numberOfUgglyDucklings, int numberOfFeathers, string animalName, string color, double height, double weight, string primaryLocation) : base(numberOfFeathers, animalName, color, height, weight, primaryLocation)
        {
            NumberOfUgglyDucklings = numberOfUgglyDucklings;
        }

    }
}
