using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of primes
            List<long> primes = new List<long>(10001);

            long primeSeed = 2;
            while(primes.Count < 10001)
            {
                if(MathHelper.Primes.IntegerIsPrime(primeSeed))
                {
                    primes.Add(primeSeed);
                }
                primeSeed++;
            }

            // Display the 10001st
            Console.WriteLine("The 10001st prime is: {0}", primes[10000]);
            Console.Read();
        }
    }
}
