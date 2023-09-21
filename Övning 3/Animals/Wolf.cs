using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Wolf : Animal
    {
        protected int numberOfClaws;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + numberOfClaws;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Ooooooo");
        }

        public int NumberOfClaws
        {
            get { return numberOfClaws; }
            set
            {
                numberOfClaws = value;
            }
        }
        public Wolf(int numberOfClaws, string animalName, string color, double height, double weight, string primaryLocation) : base(animalName, color, height, weight, primaryLocation)
        {
            NumberOfClaws = numberOfClaws;
        }
        

    }
}
