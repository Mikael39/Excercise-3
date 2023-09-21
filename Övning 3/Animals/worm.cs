using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Worm : Animal
    {
        int amountOfSlime;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + amountOfSlime;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Maskljud vad det nu är");
        }

        public int AmountOfSlime
        {
            get { return amountOfSlime; }
            set
            {
                amountOfSlime = value;
            }
        }
        public Worm(int amountOfSlime, string animalName, string color, double height, double weight, string primaryLocation) : base(animalName, color, height, weight, primaryLocation)
        {
            AmountOfSlime = amountOfSlime;
        }


    }
}
