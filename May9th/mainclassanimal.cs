using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Animal
    {
        public string Name;
        public string Species;

        //Method to display animal details

        public void DisplayAnimal()
        { 
            Console.WriteLine($"Animal Name: {Name}");
            Console.WriteLine($"Species: {Species}");
        }
    }

    //Dervied class inheriting from animal
    class Dog : Animal {
        public string Breed;

        //Method to display dog details
        public void DisplayDog()
        { 
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}