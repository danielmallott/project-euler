using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHelper;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the factors of the number
            long numberToTest = 600851475143;
            var factors = Factors.FindFactors(numberToTest);

            // Find the prime factors
            var primeFactors = factors.Where(f => Primes.IntegerIsPrime(f));

            // Find the largest
            long largestPrimeFactor = primeFactors.Max();

            // Display it
            Console.WriteLine("The largest prime factor of {0} is {1}", numberToTest, largestPrimeFactor);
            Console.Read();
        }
    }
}
