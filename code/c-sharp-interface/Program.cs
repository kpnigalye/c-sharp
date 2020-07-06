using System;
using System.Collections.Generic;

namespace c_sharp_interface
{
    class Program
    {
        private static void ExecuteCalls(IRemote remote)
        {
            remote.PowerOn();
            remote.AdjustVolume();
            remote.PowerOff();
        }

        static void Main(string[] args)
        {
            List<IRemote> devices = new List<IRemote>
            {
                new Tv("TV"),
                new MusicPlayer("Music Player"),
                new PremiumMusicPlayer("Premium Music Player")
            };

            devices.ForEach(device => ExecuteCalls(device));

            Console.ReadLine();
        }

    }
}

















//Console.WriteLine("Tv Remote");
//            Console.WriteLine("==========\n");
//            Tv tv = new Tv();
//tv.AdjustVolume();
//            tv.AdjustBrightness();

//            Console.WriteLine();

//            Console.WriteLine("Music Player Remote");
//            Console.WriteLine("====================\n");
//            MusicPlayer musicPlayer = new MusicPlayer();
//musicPlayer.AdjustVolume();
