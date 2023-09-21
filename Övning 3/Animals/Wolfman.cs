using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Wolfman : Wolf, Iperson
    {
        int numberOfKills;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + numberOfClaws + numberOfKills;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Ooooooo");
        }

        public void Talk()
        {
            Console.WriteLine("Time to die!!");
        }

        public int NumberOfKills

        {
            get {
                return numberOfKills;
                ;
            }
            set
            {
                numberOfKills = value;
            }
        }
        public Wolfman(int numberOfKills, int numberOfClaws, string animalName, string color, double height, double weight, string primaryLocation) : base(numberOfClaws, animalName, color, height, weight, primaryLocation)
        {
            NumberOfKills = numberOfKills;
        }


    }
}
