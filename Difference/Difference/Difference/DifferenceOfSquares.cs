using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{    
    internal class DifferenceOfSquares
    {
        internal static int CalculateSquareOfSum(int max)
        {
            var numbers = Enumerable.Range(1, max).Sum();
            return numbers * numbers;
        }

        internal static int CalculateSumOfSquares(int max)
        {         
            return Enumerable.Range(1, max).Select(x => x * x).Sum();
        }

        internal static int CalculateDifferenceOfSquares(int max)
        {
            return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
        }
    }
}
