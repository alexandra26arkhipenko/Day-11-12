using System;
using System.Collections.Generic;

namespace Fibinacci
{
    public class Fibinacci
    {
        /// <summary>
        /// Method generates Fibonacci numbers
        /// </summary>
        /// <returns>sequence of numbers of long type</returns>
        public static IEnumerable<long> FibonacciGenerate()
        {
            long lhs = 0, rhs = 1;

            yield return 0;
            yield return 1;
            while (true)
            {
                long tmp = lhs + rhs;
                lhs = rhs;
                rhs = tmp;
                yield return rhs;
            }
        }
    }
}
