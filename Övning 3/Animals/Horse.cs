using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Horse : Animal
    {
        int hoofs;

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + hoofs;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Ihihiiihii");
        }

     
        public int Hoofs
        {
            get { return hoofs; }
            set
            {
                hoofs = value;
            }
        }
        public Horse(int hoofs, string animalName, string color, double height, double weight, string primaryLocation) : base(animalName, color, height, weight, primaryLocation)
        {
            Hoofs = hoofs;
        }


    }
}
