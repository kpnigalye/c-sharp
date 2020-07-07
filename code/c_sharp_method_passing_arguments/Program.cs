using System;

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

            Console.WriteLine($"Average = {test.FindAverage(2, 4)}");
            Console.WriteLine($"Average of a list of integers = {test.FindAverage(2, 4, 6, 8)}");

            int[] data = { 2, 4, 6, 8 };
            Console.WriteLine($"Average of a list of integers = {test.FindAverage(data)}");

            Console.WriteLine($"No error even if data is not passed = {test.FindAverage()}");

            Console.ReadLine();
        }
    }
}