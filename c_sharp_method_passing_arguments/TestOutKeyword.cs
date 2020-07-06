using System;

namespace c_sharp_method_passing_arguments
{
    public class TestOutKeyword: ITestMethodPassingArgument
    {
        #region Private Methods
        private void FindSquare(out int num)
        {
            num = 5;    // value is initalized inside the function
            num *= num;
            Console.WriteLine($"=> Value of num inside FindSquare() is {num}");
        }
        #endregion

        #region Public Methods
        public void PrintHeader()
        {
            Console.WriteLine("Use of Out keyword");
            Console.WriteLine("--------------------");
        }

        public void TestMethodPassingArgument()
        {
            FindSquare(out int num);

            Console.WriteLine($"=> Value of num after calling FindSquare() is {num}\n");
        }
        #endregion
    }
}
