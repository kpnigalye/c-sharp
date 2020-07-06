using System;

namespace c_sharp_method_passing_arguments
{
    public class TestValueType : ITestMethodPassingArgument
    {
        #region Private Methods
        private void FindSquare(int num)
        {
            num *= num;
            Console.WriteLine($"=> Value of num inside FindSquare() is {num}");
        }
        #endregion

        #region Public Methods
        public void PrintHeader()
        {
            Console.WriteLine("Pass by Value");
            Console.WriteLine("----------------");
        }

        public void TestMethodPassingArgument()
        {
            int num = 5;
            Console.WriteLine($"=> Value of num before calling FindSquare() is {num}");

            FindSquare(5);

            Console.WriteLine($"=> Value of num after calling FindSquare() is {num}\n");
        }
        #endregion
    }
}
