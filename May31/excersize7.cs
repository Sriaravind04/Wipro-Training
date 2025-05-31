using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    class Calculator
    {
        // Add method overloads
        public int Add(int a, int b) => a + b;
        public float Add(float a, float b) => a + b;
        public double Add(double a, double b) => a + b;

        // Subtract method overloads
        public int Subtract(int a, int b) => a - b;
        public float Subtract(float a, float b) => a - b;
        public double Subtract(double a, double b) => a - b;

        // Multiply method overloads
        public int Multiply(int a, int b) => a * b;
        public float Multiply(float a, float b) => a * b;
        public double Multiply(double a, double b) => a * b;
    }

    class Program7
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Choose operation: Add, Subtract, Multiply");
            string operation = Console.ReadLine().ToLower();

            Console.WriteLine("Choose data type: int, float, double");
            string dataType = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            if (dataType == "int")
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);

                if (operation == "add")
                    Console.WriteLine($"Result: {calculator.Add(num1, num2)}");
                else if (operation == "subtract")
                    Console.WriteLine($"Result: {calculator.Subtract(num1, num2)}");
                else if (operation == "multiply")
                    Console.WriteLine($"Result: {calculator.Multiply(num1, num2)}");
            }
            else if (dataType == "float")
            {
                float num1 = float.Parse(input1);
                float num2 = float.Parse(input2);

                if (operation == "add")
                    Console.WriteLine($"Result: {calculator.Add(num1, num2)}");
                else if (operation == "subtract")
                    Console.WriteLine($"Result: {calculator.Subtract(num1, num2)}");
                else if (operation == "multiply")
                    Console.WriteLine($"Result: {calculator.Multiply(num1, num2)}");
            }
            else if (dataType == "double")
            {
                double num1 = double.Parse(input1);
                double num2 = double.Parse(input2);

                if (operation == "add")
                    Console.WriteLine($"Result: {calculator.Add(num1, num2)}");
                else if (operation == "subtract")
                    Console.WriteLine($"Result: {calculator.Subtract(num1, num2)}");
                else if (operation == "multiply")
                    Console.WriteLine($"Result: {calculator.Multiply(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Invalid data type selected!");
            }
        }
    }

}
