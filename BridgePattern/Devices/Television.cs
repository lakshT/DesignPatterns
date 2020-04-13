using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Devices
{
    public class Television : IDevice
    {
        int volume;
        bool isEnabled;
        public void Disable()
        {
            isEnabled = false;
            Console.WriteLine("TV Disabled...");
        }

        public void Enable()
        {
            volume = 70;
            isEnabled = true;
            Console.WriteLine("TV Enabled...");
        }

        public int GetVolume()
        {
            return volume;
        }

        public bool IsEnabled()
        {
            return isEnabled;
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
        }
    }
}
