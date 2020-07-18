using System;

namespace c_sharp_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instance Constructor
            //Staff staff = new Staff("John", "Cena");
            #endregion

            #region Instance Constructor with Inheritance 
            //Vehical car = new SportsCar("MH-05-CS-2341");

            // case where 'base' keyword is not there
            //Vehical car = new SportsCar();
            #endregion

            #region Constructor calling another Constructor
            //Employee employee = new Employee(20000, 52);
            #endregion

            #region Copy Constructor
            //Circle circle = new Circle(5);
            //Circle anotherCircle = new Circle(circle);
            #endregion

            //StaticConstructorTest test = new StaticConstructorTest();
            StaticConstructorTest.Testing();
            StaticConstructorTest.TestingAgain();

            Console.ReadLine();
        }
    }
}






