using System;

namespace c_sharp_method_passing_arguments
{
    public class TestParamsKeyword
    {
        #region Public Methods
        public void PrintHeader()
        {
            Console.WriteLine("Use of Params keyword");
            Console.WriteLine("-----------------------");
        }

        public int FindSum(bool flag, params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return flag ? sum *= 2 : sum;
        }
        #endregion
    }
}
