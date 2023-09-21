using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Övning_3.Animals
{
    internal abstract class Animal
    {

        //Här stoppar vi in 14
        protected string animalName;
        protected double weight;
        protected double height;
        protected string color;
        protected string primaryLocation;

        public abstract void DoSound();

        public virtual string Stats()
        {
            string stats = animalName + weight + height + color + primaryLocation;
            return stats;
        }

        public string AnimalName
        {
            get { return animalName; }
            set
            {
                animalName = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
        public string PrimaryLocation
        {
            get { return primaryLocation; }
            set
            {
                primaryLocation = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }

        // vi lägger in en ny getset för 14 här

        //Inuti konstruktorn lägger vi till 14 

        public Animal(string animalName, string color, double height, double weight, string primaryLocation)
        {
            AnimalName = animalName;
            Color = color;
            PrimaryLocation = primaryLocation;
            Height = height;
            Weight = weight;
        }
    }
}
