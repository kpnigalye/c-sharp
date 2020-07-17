using System;

namespace c_sharp_constructors
{
    public class Employee
    {
        public Employee(int weeklySalary, int numberOfWeeks)
            : this(weeklySalary * numberOfWeeks)
        {

        }

        private Employee(int yearlyPackage)
        {
            Console.WriteLine("Yearly Package is {0}", yearlyPackage);
        }
    }
}