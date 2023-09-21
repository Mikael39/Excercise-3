using Övning_3.Animals;
using System;
using System.Buffers;
using System.Security.Cryptography;
using static Övning_3.UserError;

namespace Övning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonHandler();                  
            var errorList = new List<UserError>();
            var animalList = new List<Animal>();
            var doggyList = new List<Dog>();
           // för att kunna spara personer och animals tillsammans i en lista måste det vara en Interface lista alt en arraylista, alt objectlista. För att kunna skapa listan
           //måste det vara ur en minsta gemensama nämnare. Om en person ocn en animal delar kontrakt via interface går det att göra en lista baserat på interfacet.

            var n1 = new NumericInputError();
            var n2 = new TextInputError();
            var n3 = new VoidUserError();
            var n4 = new OverFlowError();
            var n5 = new ValueOutOfBoundsError();

            var a1 = new Bird(1000, "Fågel Peppe", "gul", 42, 2.35, "Asien");
            var a2 = new Wolf(20, "Vargen Nisse", "Grå", 90, 75, "Nordamerika");
            var a4 = new Pelican(42, 1200, "Pelikanen Urban", "Vit", 75, 9, "Västindien");
            var a3 = new Wolfman(30, 10, "Dimitris", "Blek", 185, 80, "Stockholm");
            var a5 = new Horse(4, "Hästen Hoppla", "Brun", 150, 500, "Europa");
            var a6 = new Dog(4, "Hunden Bobbo", "Grå", 90, 75, "Nordamerika");


                animalList.Add(a1);
                animalList.Add(a2);
                animalList.Add(a3);
                animalList.Add(a4);
                animalList.Add(a6); 
              //  doggyList Add(a5); en häst != hund, och en häst ärver inte från hund utan från animal

            foreach (var animal in animalList)
            {
                if (animal is Iperson castedToIperson)
                {
                    castedToIperson.Talk();
                }
                else
                animal.DoSound();
            }

            foreach (var animal in animalList)
            { 
                Console.WriteLine(animal.Stats()) 
            }
            
            
            foreach (var animal in animalList)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                 //   Console.WriteLine(animal.GetOwner());  16+17 Inte med normal access
                }
            }

            // Om vi type castar till dog kan vi komma åt metoden  16+17
            foreach (var animal in animalList)
                if (animal is Dog castedToDog)
                {
                    string value = castedToDog.GetOwner();
                    Console.WriteLine(value);
                }


            errorList.Add(n1);
            errorList.Add(n2); 
            errorList.Add(n3); 
            errorList.Add(n4);
            errorList.Add(n5);

            foreach (var error in errorList)
            {
                Console.WriteLine(error.UEMessage());
            }
            

            

            try
            {
                Person nisse = person.CreatePerson(5, "nissesses", "Svensson", 178, 90);
                Person nisse2 = person.CreatePerson(3, "sven", "olsson", 178, 90);
                person.SetAge(nisse, 5);
                person.SetAge(nisse2, 4);
                person.SetHeight(nisse2, 156);

                Console.WriteLine($"{nisse.Age} {nisse.Fname} {nisse.Lname}  {nisse.Weight} {nisse.Height}");
            }
            catch (ArgumentException ex) 
            {
            Console.Write(ex.Message);
                Console.ReadLine();
            }
            
            
            

        }



    }
    }