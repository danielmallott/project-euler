using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHelper;

namespace Problem89
{
    public class RomanNumeralWithReduced
    {
        public string OriginalNumeral { get; set; }
        public int NumberOfCharactersInOriginal
        {
            get
            {
                return OriginalNumeral.Length;
            }
        }

        public int OriginalValue
        {
            get
            {
                return RomanNumerals.CalculateRomanNumeralValue(OriginalNumeral);
            }
        }

        public string MinimalNumeral { get; set; }
        public int NumberOfCharactersInMinimal
        {
            get
            {
                return MinimalNumeral.Length;
            }
        }

        public int MinimalValue
        {
            get
            {
                return RomanNumerals.CalculateRomanNumeralValue(MinimalNumeral);
            }
        }
    }
}
