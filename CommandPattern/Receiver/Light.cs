using System;

namespace CommandPattern.Receiver
{
    public class Light
    {
        bool lightStatus;
        public void On()
        {
            Console.WriteLine("Light Status: " + lightStatus);
            Console.WriteLine("Turning on light...");
            lightStatus = true;
            Console.WriteLine("Light Status: " + lightStatus);
        }

        public void Off()
        {
            Console.WriteLine("Light Status: " + lightStatus);
            Console.WriteLine("Turning off light...");
            lightStatus = false;
            Console.WriteLine("Light Status: " + lightStatus);
        }
    }
}
