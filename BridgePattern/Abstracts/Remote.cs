using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Abstracts
{
    public abstract class Remote
    {
        protected IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        public void VolumeUp(int volume)
        {
            device.SetVolume(device.GetVolume() + volume);
        }

        public void VolumeDown(int volume)
        {
            device.SetVolume(device.GetVolume() - volume);
        }

        public int GetDeviceVolume()
        {
            return device.GetVolume();
        }
    }
}
