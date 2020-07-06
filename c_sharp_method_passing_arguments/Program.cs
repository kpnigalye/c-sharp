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

            Console.ReadLine();
        }
    }
}
