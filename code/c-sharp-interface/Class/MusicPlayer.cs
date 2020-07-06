using System;

namespace c_sharp_interface
{
    internal class MusicPlayer : IRemote, ITuner
    {
        public int MaxVolume => 100;
        public string Device { get; }

        public virtual event Action<string> OnVolumeChange = (message) => Console.WriteLine(message);

        public MusicPlayer(string device)
        {
            Device = device;
        }

        public virtual void AdjustVolume()
        {
            Console.WriteLine("=> You can adjust volume using voice commands.");
            OnVolumeChange($"Make sure you are not going above {MaxVolume}.");
        }

        public void EnableAudioTuner()
        {
            Console.WriteLine("=> Audio tuner Enabled.\n");
        }

        public void PowerOn()
        {
            Console.WriteLine($"{Device}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"=> Turned on {Device}\n");
        }

        public void PowerOff()
        {
            Console.WriteLine($"=> Turned off {Device}\n");
            Console.WriteLine();
        }

        #region CommonFunctions
        void ITuner.CommonFunction()
        {

        }

        void IRemote.CommonFunction()
        {

        }
        #endregion
    }
}
