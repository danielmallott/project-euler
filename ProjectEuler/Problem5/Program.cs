using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            int testingValue = 2520;
            int maxDivisor = 20;

            while(shouldContinue)
            {
                Console.WriteLine("Testing: {0}", testingValue);
                shouldContinue = !(DivisionHelper.Test(testingValue, maxDivisor));
                if(shouldContinue)
                {
                    testingValue += 10;
                }
            }

            Console.WriteLine("The number: {0} is evenly divisible by all integers from 1 to {1}", testingValue, maxDivisor);
            Console.Read();
        }
    }
}
