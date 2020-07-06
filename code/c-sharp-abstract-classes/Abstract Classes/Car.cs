using System;

namespace abstract_classes
{

    /// <summary>
    /// Abstract definition of Car of any kind
    /// </summary>
    public abstract class Car: CarHeader
    {
        /// <summary>
        /// Derived Class must set this value
        /// </summary>
        public abstract int NumberOfAirBags { get; }

        public Car(string header) : base(header)
        {
        }

        #region Static Methods
        public static void Test()
        {
            Console.WriteLine("--> Abstract Class can have static methods.\n");
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Public Method can be called using object of child class
        /// </summary>
        public void Start()
        {
            Console.WriteLine("--> Starting the Car..\n");
        }

        public void OpenWindows()
        {
            Console.WriteLine("--> Opening windows..\n");
        }

        #endregion

        #region Virtual Methods
        public virtual void Stop()
        {
            Console.WriteLine("--> Stopping the Car..\n");
        }
        #endregion

        #region Abstract Methods
        /// <summary>
        /// Method declared as abstract has to be derived in the child class.
        /// </summary>
        public abstract void TurnOnRadio();
        #endregion

    }
}