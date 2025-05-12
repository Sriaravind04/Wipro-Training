using System;

interface IDeviceControl
    {
    void TurnOn();
    void TurnOff();

    }
class SmartTV : IDeviceControl {
    public void TurnOn() {
        Console.WriteLine("SmartTV is now ON");
    }
    public void TurnOff() { Console.WriteLine("SmartTV is now OFF"); }
}
class Speaker : IDeviceControl {
    public void TurnOn() { Console.WriteLine("speaker is now on"); }
    public void TurnOff() { Console.WriteLine("speaker is now off"); }
}

class Program
{
   static void Main() {
        IDeviceControl Tv = new SmartTV();
        IDeviceControl speaker = new Speaker();

        Tv.TurnOn();
        Tv.TurnOff();

        speaker.TurnOn();
        speaker.TurnOff();
    }
}