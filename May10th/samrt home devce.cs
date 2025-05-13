using System;

class SmartDevice
{
    public string DeviceName;
    public bool PowerStatus;

    public void TogglePower()
    {
        PowerStatus = !PowerStatus;
        Console.WriteLine(DeviceName + " is " + (PowerStatus ? "ON" : "OFF"));
    }
}

class SmartLight : SmartDevice
{
    public int Brightness;

    public void SetBrightness(int b)
    {
        Brightness = b;
        Console.WriteLine("Brightness set to " + Brightness);
    }
}

class SmartThermostat : SmartDevice
{
    public double Temperature;

    public void SetTemperature(double t)
    {
        Temperature = t;
        Console.WriteLine("Temperature set to " + Temperature);
    }
}

class Program
{
    static void Main()
    {
        SmartLight light = new SmartLight();
        light.DeviceName = "Light";
        light.TogglePower();
        light.SetBrightness(80);

        SmartThermostat thermo = new SmartThermostat();
        thermo.DeviceName = "Thermostat";
        thermo.TogglePower();
        thermo.SetTemperature(23.5);
    }
}