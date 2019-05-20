using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class Factors
    {
        public static IEnumerable<long> FindFactors(long number)
        {
            List<long> factors = new List<long>
            {

                // A number always has 1 and itself as factors
                1,
                number
            };

            // Start at 2 and add factors that evenly divide (along with the division result)
            // until we reach a number already in the list.
            for (long l = 2; l <= number; l++)
            {
                if(factors.Contains(l))
                {
                    break;
                }

                if(number % l == 0)
                {
                    factors.Add(l);
                    factors.Add(number / l);
                }
            }

            factors = factors.Distinct().ToList();

            return factors;
        }
    }
}
