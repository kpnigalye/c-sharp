using System;

namespace abstract_classes
{
    public class PremiumSportsCar : SportsCar
    {
        public override int NumberOfAirBags => 8;

        public PremiumSportsCar(string header) : base(header)
        {
        }

        /// <summary>
        /// Further override a function defined in SportsCar class
        /// </summary>
        public override void TurnOnRadio()
        {
            Console.WriteLine("--> Turning on Car Radio from mobile..\n");
        }
    }
}













