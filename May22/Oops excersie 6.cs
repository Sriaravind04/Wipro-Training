using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();

        public void Feed()
        {
            Console.WriteLine("Feeding the animal...");
        }
    }

    class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Lion Roars!");
        }
    }

    class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Elephant Prrrrs!");
        }
    }

    class Monkey : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Monkey screams!");
        }
    }

    class Zoo
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void InvokeAllActions()
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Feed();
            }
        }
    }

    class Program18
    {
        static void Main()
        {
            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Lion { Name = "Lion", Age = 5 });
            zoo.AddAnimal(new Elephant { Name = "Elephant", Age = 10 });
            zoo.AddAnimal(new Monkey { Name = "Monkey", Age = 3 });

            zoo.InvokeAllActions();
        }
    }
    
}