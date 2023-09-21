using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Övning_3
{
    public class PersonHandler
    {
        
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
            
        }
        public void ChangeFirstName(Person pers, string fname)
        {
            pers.Fname = fname;
        }

        public void ChangeLastName(Person pers, string lname)
        {
            pers.Lname = lname;
        }


        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person output = new Person(age, fname, lname, height, weight);
            
            return output;
        }

        







    }
}
