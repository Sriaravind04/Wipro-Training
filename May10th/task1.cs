using System;


class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Operating Appliance");
    }
}
class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing clothes");
    }
} 
class Program
{
    static void Main()
    {
        Appliance a = new Appliance();
        a.Operate();
        WashingMachine wm = new WashingMachine();
        wm.Operate();
        Appliance refMachine = new WashingMachine();
        refMachine.Operate();
    }
}