using System;

namespace c_sharp_interface
{
    public interface IRemote
    {
        int MaxVolume { get; }
        string Device { get; }

        event Action<string> OnVolumeChange;

        void AdjustVolume();
        void PowerOn();
        void PowerOff();

        void CommonFunction();
    }
}
