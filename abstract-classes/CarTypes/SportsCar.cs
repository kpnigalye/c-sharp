using System;

namespace abstract_classes
{
    public class SportsCar : Car
    {
        public override int NumberOfAirBags => 6;

        public SportsCar(string header) : base(header)
        {
        }

        /// <summary>
        /// Hides the 'Start' method defined in the base class 
        /// </summary>
        public new void Start()
        {
            // you can call the base class method using 'base' keyword. 
            //base.Start();
            Console.WriteLine("--> Starting the Car using Power button.\n");
        }

        /// <summary>
        /// Override Stop function defined in base class
        /// </summary>
        public override void Stop()
        {
            Console.WriteLine("--> Stopping the Car using Power button.\n");
        }

        /// <summary>
        /// Override a function defined as abstract in base class
        /// </summary>
        public override void TurnOnRadio()
        {
            Console.WriteLine("--> Turning on the radio using remote.\n");
        }
    }
}













