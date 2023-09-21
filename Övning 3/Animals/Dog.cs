using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3.Animals
{
    internal class Dog : Animal
    {
        int paws;
        public string GetOwner()
        {
            string owner = "Pelle";
            return owner;
        }

        public override string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation + paws;
            return stats;
        }
        public override void DoSound()
        {
            Console.WriteLine("Woof Woof");
        }

        public int Paws
        {
            get { return paws; }
            set
            {
                paws = value;
            }
        }
        public Dog(int paws, string animalName, string color, double height, double weight, string primaryLocation) : base(animalName, color, height, weight, primaryLocation)
        {
            Paws = paws;
        }


    }
}
