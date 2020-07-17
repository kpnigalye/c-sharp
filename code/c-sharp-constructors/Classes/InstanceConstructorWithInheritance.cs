using System;

namespace c_sharp_constructors
{
    public class Vehical
    {
        private string _vehicalNumber { get; set; }

        public Vehical(string vehicalNumber)
        {
            _vehicalNumber = vehicalNumber;
            Console.WriteLine("Base.Contructor");
        }
    }

    public class SportsCar : Vehical
    {
        public SportsCar(string vehicalNumber) : base(vehicalNumber)
        {
            Console.WriteLine("Dervied.Contructor");
        }
    }


    // Case where 'base' keyword is not declared
    // =========================================

    //public class Vehical
    //{
    //    public Vehical()
    //    {
    //        Console.WriteLine("Base.Contructor");
    //    }
    //}

    //public class SportsCar : Vehical
    //{
    //    public SportsCar()
    //    {
    //        Console.WriteLine("Dervied.Contructor");
    //    }
    //}
}

