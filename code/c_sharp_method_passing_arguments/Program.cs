using System;
using System.Collections.Generic;

namespace c_sharp_method_passing_arguments
{
    class Program
    {
        public static void ExecuteMethod(ITestMethodPassingArgument test)
        {
            test.PrintHeader();
            test.TestMethodPassingArgument();
        }

        static void Main(string[] args)
        {
            ExecuteMethod(new TestValueType());
            ExecuteMethod(new TestRefKeyword());
            ExecuteMethod(new TestOutKeyword());
            ExecuteMethod(new TestInKeyword());

            TestParamsKeyword test = new TestParamsKeyword();
            test.PrintHeader();

            Console.WriteLine($"Sum of numbers = {test.FindSum(true, 5, 10, 15, 50, 30)}");
            Console.WriteLine($"Sum of all numbers in the array = {test.FindSum(false, new[] { 1, 3, 5, 7, 9 })}\n");

            Console.WriteLine($"DoubleAndAdd result = {test.DoubleAndAdd(2, 3)}");
            Console.WriteLine($"Result of Passing no arguments to DoubleAndAdd = {test.DoubleAndAdd(2, 3)}");

            Console.ReadLine();
        }
    }
}
