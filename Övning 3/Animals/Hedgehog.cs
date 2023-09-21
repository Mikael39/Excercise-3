using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Hedgehog : Animal
    {
        int tusks;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + tusks;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Weeeeeeee");
        }

        public int Tusks
        {
            get { return tusks; }
            set
            {
                tusks = value;
            }
        }
        public Hedgehog(int tusks, string animalName, string color, double height, double weight, string primaryLocation) : base(animalName, color, height, weight, primaryLocation)
        {
            Tusks = tusks;
        }


    }
}
