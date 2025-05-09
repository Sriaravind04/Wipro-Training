using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class program2
    {
        static void Main() { 
        //Creating an object of Dog class
        Dog d = new Dog();
        d.Name= "Buddy";
            d.Species = "canine";
            d.Breed = "Labrador";

            //Display animal details
            d.DisplayAnimal();

            //Display dog-specific details
            d.DisplayDog();
            }
    }
}
