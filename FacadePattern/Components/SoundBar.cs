using System;

namespace FacadePattern.Components
{
    public class SoundBar
    {
        public void TurnOn()
        {
            Console.WriteLine("Soundbar turned on.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Soundbar volume set to: " + volume);
        }

        public void TurnOff()
        {
            Console.WriteLine("Soundbar turned off.");
        }
    }
}
