using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Flamingo : Bird
    {
        int lengthOfNeck;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + lengthOfNeck;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Flamingosound");
        }

        public int LengthOfNeck
        {
            get { return lengthOfNeck; }
            set
            {
                lengthOfNeck = value;
            }
        }
        public Flamingo(int lengthOfNeck, int numberOfFeathers, string animalName, string color, double height, double weight, string primaryLocation) : base(numberOfFeathers, animalName, color, height, weight, primaryLocation)
        {
            LengthOfNeck = lengthOfNeck;
        }

    }
}
