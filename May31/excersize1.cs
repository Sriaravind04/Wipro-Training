using System;

class Vehicle { 
    public string Name { get; set; }
    public int RentPerDay { get; set; }
    public Vehicle(string name, int amount) { 
        Name = name;
        RentPerDay = amount;
    }
}
interface IRentable {
    void Rent();
}
class Car : Vehicle {
    public Car(string name, int amount) : base(name, amount) { }
    public void Rent()
    {
        Console.WriteLine("The name of the vehicle: " + Name);
        Console.WriteLine("The rent cost per day: " + RentPerDay + " rupees.");
    }
}
class Bike : Vehicle
{
    public Bike(string name, int amount) : base(name, amount) { }
    public void Rent()
    {
        Console.WriteLine("The name of the vehicle: " + Name);
        Console.WriteLine("the rent cost per day: " + RentPerDay + " rupees.");
    }
   
}
class Truck : Vehicle
{
    public Truck(string name, int amount) : base(name, amount) { }
    public void Rent()
    {
        Console.WriteLine("The name of the vehicle: " + Name);
        Console.WriteLine("The rent cost per day: " + RentPerDay + " rupees.");
    }
   
}
class Program
{
    public static void Main()
    {
        Car car = new Car("Toyota", 250);
        car.Rent();
        Console.WriteLine();

        Bike bike = new Bike("Yamaha", 150);
        bike.Rent();
        Console.WriteLine();

        Truck truck = new Truck("Volvo", 550);
        truck .Rent();
    }
}