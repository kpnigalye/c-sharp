using System;

namespace c_sharp_interface
{
    class PremiumMusicPlayer : MusicPlayer
    {
        public PremiumMusicPlayer(string device) : base(device) { }

        public override event Action<string> OnVolumeChange = (message) => Console.WriteLine(message);

        public override void AdjustVolume()
        {
            Console.WriteLine("=> You can adjust volume using Mobile App.");
            OnVolumeChange($"Make sure you are not going above {MaxVolume}.\n");
        }
    }
}
