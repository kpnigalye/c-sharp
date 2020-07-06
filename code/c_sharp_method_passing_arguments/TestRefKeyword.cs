using System;

namespace c_sharp_method_passing_arguments
{
    public class TestRefKeyword : ITestMethodPassingArgument
    {
        #region Private Methods
        private void FindSquare(ref int num)
        {
            num *= num;
            Console.WriteLine($"=> Value of num inside FindSquare() is {num}");
        }
        #endregion

        #region Public Methods
        public void PrintHeader()
        {
            Console.WriteLine("Use of Ref keyword");
            Console.WriteLine("---------------------");
        }

        public void TestMethodPassingArgument()
        {
            int num = 5;
            Console.WriteLine($"=> Value of num before calling FindSquare() is {num}");

            FindSquare(ref num);

            Console.WriteLine($"=> Value of num after calling FindSquare() is {num}\n");
        }
        #endregion
    }
}
