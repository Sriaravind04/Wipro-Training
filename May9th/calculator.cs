using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculator
    {
        public int Add(int a, int b)
        { 
            return a + b;
        }
        public double Add(double a, double b) {
            return a + b;
        }

        public int Add(int a,int b,int c) { return a + b + c; }


        public int sub(int a, int b) { return a - b; }
        public int sub(int a, int b, int c) { return a - b - c; }
        public double sub(double a, double b) { return a - b; }
        public double sub(double a, double b , double c) { return a - b + c; }

        public int mul(int a, int b) { return a * b; }

        public double mul(double a, double b , double c) { return a * b * c; }

        public double mul(double a,double b) { return a * b; }
    }
}