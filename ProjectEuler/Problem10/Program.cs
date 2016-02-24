using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHelper;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get all primes under 2,000,000
            ConcurrentBag<long> primes = new ConcurrentBag<long>();

            Parallel.For(2L, 2000000L, l =>
            {
                if (Primes.IntegerIsPrime(l))
                {
                    primes.Add(l);
                }
            });

            // Sum them
            long sumOfPrimes = primes.Sum();

            // Display
            Console.WriteLine("Sum is: {0}", sumOfPrimes);

            Console.Read();
        }
    }
}
