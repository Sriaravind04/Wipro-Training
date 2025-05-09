using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Shape
    {
        public virtual void Draw() {
            Console.WriteLine("Drawing a shape");
        }
    }
    class Circle : Shape {
        public override void Draw() {
            Console.WriteLine("Drawing a circle");
        }
    }
}