using BridgePattern.Abstracts;
using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Remotes
{
    public class AdvanceRemote : Remote
    {
        int currentVolume;
        public AdvanceRemote(IDevice device) : base(device) { }

        public void Mute()
        {
            currentVolume = device.GetVolume();
            device.SetVolume(0);
        }

        public void UnMute()
        {
            device.SetVolume(currentVolume);
        }
    }
}
