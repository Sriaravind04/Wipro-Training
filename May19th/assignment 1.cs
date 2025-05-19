using System;

abstract class SmartDevice {
    public abstract void TurnOn();

    public void ShowStatus() {
        Console.WriteLine("Device status: Active");
    }
}
    interface IRemoteControl {
        public void IncreaseVolume();
        public void DecreaseVolume();
    }
    class SmartLight : SmartDevice, IRemoteControl {
        public override void TurnOn() {
            Console.WriteLine("Smart LIght Turned ON");
        }
        public void IncreaseVolume() {
            Console.WriteLine("Lights do not support volume Control");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("Lights do not support volume control");
        }
    }
    class SmartSpeaker : SmartDevice, IRemoteControl {
        public override void TurnOn() {
            Console.WriteLine("Smart speaker turned on");
        }
        public void IncreaseVolume() {
            Console.WriteLine("Volume Increased");
        }
        public void DecreaseVolume() {
            Console.WriteLine("Volume Decreased");
        }
    }
class Program {
    static void Main() {
        SmartLight light = new SmartLight();
        light.ShowStatus();
        light.TurnOn();
        light.IncreaseVolume();
        light.DecreaseVolume();

        SmartSpeaker speaker = new SmartSpeaker();  
        speaker.ShowStatus();
        speaker.TurnOn();
        speaker.IncreaseVolume();
        speaker.DecreaseVolume();

      
       
    }

}