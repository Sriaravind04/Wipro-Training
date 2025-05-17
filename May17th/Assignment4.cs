using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Animal {
        public abstract void MakeSound();
        public void Eat() {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Barks");
        }
    }
    class Cat : Animal {
        public override void MakeSound() {
            Console.WriteLine("Meows");
        }
    }

    internal class Program3
    {
        static void Main() {
            Dog d = new Dog();
            d.Eat();
            d.MakeSound();

            Cat c = new Cat();
            c.Eat();
            c.MakeSound();
        }
    }
}