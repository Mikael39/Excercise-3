using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Pelican : Bird
    {
        int sizeOfBeak;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + sizeOfBeak;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Pelicansounds");
        }

        public int SizeOfBeak
        {
            get { return sizeOfBeak; }
            set
            {
                sizeOfBeak = value;
            }
        }
        public Pelican(int sizeOfBeak, int numberOfFeathers, string animalName, string color, double height, double weight, string primaryLocation) : base(numberOfFeathers, animalName, color, height, weight, primaryLocation)
        {
            SizeOfBeak = sizeOfBeak;
        }

    }
}
