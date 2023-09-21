using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    public class Person
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;
       
        public int Age
        {
            get { return age; }


            set 
                {
                if (value < 1)
                    throw new ArgumentException("Ålder måste vara större än 0");
                else
                    age = value;
            }

        }



        public string Fname
        {
            get { return fname; }
            set
            {
                if (value.Equals(0) || value.Length < 3 || value.Length > 10)

                throw new ArgumentException("Förnamn måste vara minst två bokstäver och max 10 bokstäver");
                else
                fname = value;
            }
        }
        public string Lname
        {
            get { return lname; }
            set
            {
                if (value.Equals(0) || value.Length < 4 || value.Length > 10)

                    throw new ArgumentException("Efternamn måste vara minst två bokstäver och max 10 bokstäver");
                    else
                    lname = value;
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

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
        }



    }

}
