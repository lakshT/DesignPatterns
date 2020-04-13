using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Devices
{
    public class Radio : IDevice
    {
        int volume;
        bool isEnabled;
        public void Disable()
        {
            isEnabled = false;
            Console.WriteLine("Radio Disabled...");
        }

        public void Enable()
        {
            volume = 20;
            isEnabled = true;
            Console.WriteLine("Radio Enabled...");
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
