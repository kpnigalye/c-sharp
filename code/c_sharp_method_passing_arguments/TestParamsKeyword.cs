using System;
using System.Linq;

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

        public int FindAverage(params int[] numbers)
        {
            int sum = 0;
            if (numbers.Length == 0)
                return sum;

            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        #endregion
    }
}
