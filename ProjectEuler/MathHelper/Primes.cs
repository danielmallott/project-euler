using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class Primes
    {
        /// <summary>
        /// Determine whether the passed <paramref name="numberToTest"/> is prime or not.
        /// </summary>
        /// <param name="numberToTest">The natural number to determine if prime.</param>
        /// <returns><c>true</c> if prime; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Uses the brute force method of dividing the <paramref name="numberToTest"/> (n) by
        /// a sequence of number (2, 3, 4,..., sqrt(n)).
        /// </remarks>
        public static bool IntegerIsPrime(long numberToTest)
        {
            bool isPrime = true;

            if(numberToTest == 2)
            {
                return isPrime;
            }

            // Determine the max number for our division sequence.
            var squareRoot = Math.Sqrt(numberToTest);

            long maxDivisor = Convert.ToInt64(Math.Ceiling(squareRoot));

            // Create our sequence
            List<long> divisors = new List<long>();
            for (long l = 2; l <= maxDivisor; l++)
            {
                divisors.Add(l);
            }

            // Test the number
            foreach(long divisor in divisors)
            {
                if(numberToTest % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }            

            return isPrime;
        }
    }
}
