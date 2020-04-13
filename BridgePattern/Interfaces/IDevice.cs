using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Interfaces
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
    }
}
