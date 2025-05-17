using System;

interface IMaintenance
{ 
    public void Service();
    public void Repair();

}
class CarMaintenance : IMaintenance
{
    public void Service() {
        Console.WriteLine("Car is being serviced");
    }

    public void Repair() {
        Console.WriteLine("Car is being repaired");
    }
}
class BikeMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being serviced");
    }
    public void Repair() {
        Console.WriteLine("Bike is being repaired");
    }
}
class Program {
    static void Main() { 
        CarMaintenance car = new CarMaintenance();
        car.Service();
        car.Repair();

        BikeMaintenance bike = new BikeMaintenance();
        bike.Service();
        bike.Repair();
    }
}