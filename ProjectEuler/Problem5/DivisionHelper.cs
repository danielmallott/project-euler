using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal static class DivisionHelper
    {
        public static bool Test(int numberToTest, int maxDivisor)
        {
            bool success = true;
            ConcurrentBag<int> successfulDivisors = new ConcurrentBag<int>();

            Parallel.For(1, maxDivisor + 1, i =>
            {
                if (numberToTest % i == 0)
                {
                    successfulDivisors.Add(i);
                }
            });
            
            if(successfulDivisors.Count < maxDivisor)
            {
                success = false;
            }

            return success;
        }
    }
}
