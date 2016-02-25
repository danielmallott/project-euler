using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHelper;

namespace Problem89
{
    class Program
    {
        static void Main(string[] args)
        {
            var numerals = File.ReadAllLines("p089_roman.txt").ToList();

            Console.WriteLine(numerals.Count);

            List<RomanNumeralWithReduced> normalizedNumerals = new List<RomanNumeralWithReduced>();

            foreach(string numeral in numerals)
            {
                normalizedNumerals.Add(new RomanNumeralWithReduced()
                {
                    OriginalNumeral = numeral,
                    MinimalNumeral = RomanNumerals.CalculateRomanNumeral(RomanNumerals.CalculateRomanNumeralValue(numeral))
                });
            }

            var problems = normalizedNumerals.Where(nn => nn.MinimalValue != nn.OriginalValue);

            problems.ToList().ForEach(p => Console.WriteLine("{0}: {1}; {2}: {3}", p.OriginalNumeral, p.OriginalValue, p.MinimalNumeral, p.MinimalValue));

            var totalSavings = normalizedNumerals.Select(nn => nn.NumberOfCharactersInOriginal - nn.NumberOfCharactersInMinimal).Sum();

            Console.WriteLine("Characters saved by writing in minimal form: {0}", totalSavings);

            Console.Read();
        }        
    }
}
