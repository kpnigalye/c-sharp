using System;

namespace c_sharp_method_passing_arguments
{
    public class TestInKeyword: ITestMethodPassingArgument
    {
        #region Private Methods
        private void PrintNumbers(in int num)
        {
            Console.WriteLine($"=> Value of num inside PrintNumbers() is {num}");
        }
        #endregion

        #region Public Methods
        public void PrintHeader()
        {
            Console.WriteLine("Use of In keyword");
            Console.WriteLine("---------------------");
        }

        public void TestMethodPassingArgument()
        {
            // In read word situation, this code will be more complex. 
            for (int num = 0; num < 5; num++)
            {
                Console.WriteLine($"=> Value of num before calling FindSquare() is {num}");

                PrintNumbers(in num);

                Console.WriteLine($"=> Value of num after calling FindSquare() is {num}\n");
            }
        }
        #endregion
    }
}
