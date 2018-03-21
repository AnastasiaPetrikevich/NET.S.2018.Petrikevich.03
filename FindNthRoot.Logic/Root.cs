using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthRoot.Logic
{
    /// <summary>
    /// This class contains methods for finding the root of a number. 
    /// </summary>
    public static class Root
    {
        /// <summary>
        /// Finds the Nth root of the number using the Newton algorithm.
        /// </summary>
        /// <param name="number">Your number.</param>
        /// <param name="degree">Root degree.</param>
        /// <param name="precision">Prescision of the calculation.</param>
        /// <returns>Root value.</returns>

        public static double FindNthRoot(double number, int degree, double precision)
        {
            if (number < 0 && (degree % 2 == 0))
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }
            if (degree < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(degree));
            }

            if (precision < 0 || precision > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }


            double first = number / degree;
            double second = 1.0 / degree * ((degree - 1) * first + number / Math.Pow(first, degree - 1));

            while (Math.Abs(second - first) > precision)
            {
                first = second;
                second = 1.0 / degree * ((degree - 1) * first + number / Math.Pow(first, degree - 1));

            }
            return second;
        }
    }
}
