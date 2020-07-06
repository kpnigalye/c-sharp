using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Static functions of Abstract Class");
            Console.WriteLine("-------------------------------------------");
            Car.Test();
            Console.WriteLine();

            CallCarFunction(new SportsCar("Sports Car"));
            Console.WriteLine();
            CallCarFunction(new PremiumSportsCar("Premium Car"));

            Console.ReadLine();
        }

        /// <summary>
        /// You can pass any type of Car object to this method
        /// </summary>
        /// <param name="car"></param>
        private static void CallCarFunction(Car car)
        {
            car.PrintHeader();
            car.Start();
            car.Stop();
            car.OpenWindows();
            car.TurnOnRadio();
        }
    }
}





















