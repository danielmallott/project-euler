using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class RomanNumerals
    {
        public static int CalculateRomanNumeralValue(string romanNumeral)
        {
            int result = 0;

            // Take care of subtractive combinations first.
            if (romanNumeral.Contains("CM"))
            {
                result += 900;
                romanNumeral = romanNumeral.Replace("CM", string.Empty);
            }
            if (romanNumeral.Contains("CD"))
            {
                result += 400;
                romanNumeral = romanNumeral.Replace("CD", string.Empty);
            }
            if (romanNumeral.Contains("XC"))
            {
                result += 90;
                romanNumeral = romanNumeral.Replace("XC", string.Empty);
            }
            if (romanNumeral.Contains("XL"))
            {
                result += 40;
                romanNumeral = romanNumeral.Replace("XL", string.Empty);
            }
            if (romanNumeral.Contains("IX"))
            {
                result += 9;
                romanNumeral = romanNumeral.Replace("IX", string.Empty);
            }
            if (romanNumeral.Contains("IV"))
            {
                result += 4;
                romanNumeral = romanNumeral.Replace("IV", string.Empty);
            }

            // Deal with additive combinations.
            var remainingNumerals = romanNumeral.ToCharArray();

            foreach (char numeral in remainingNumerals)
            {
                switch (numeral)
                {
                    case 'M':
                        result += 1000;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'C':
                        result += 100;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'X':
                        result += 10;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'I':
                        result += 1;
                        break;
                }
            }

            return result;
        }

        public static string CalculateRomanNumeral(int value)
        {
            var result = new StringBuilder();

            if(value >= 1000)
            {
                int numberOfThousandIncrements = value / 1000;
                for(int i = 0; i < numberOfThousandIncrements; i++)
                {
                    result.Append("M");
                }
                value -= (numberOfThousandIncrements * 1000);
            }

            if(value >= 900)
            {
                result.Append("CM");
                value -= 900;
            }

            if(value >= 500)
            {
                result.Append("D");
                value -= 500;
            }

            if(value >= 400)
            {
                result.Append("CD");
                value -= 400;
            }

            if(value >= 100)
            {
                int numberOfHundredIncrements = value / 100;
                for(int i = 0; i < numberOfHundredIncrements; i++)
                {
                    result.Append("C");
                }
                value -= (numberOfHundredIncrements * 100);
            }

            if(value >= 50)
            {
                result.Append("L");
                value -= 50;
            }

            if(value >= 40)
            {
                result.Append("XL");
                value -= 40;
            }

            if(value >= 10)
            {
                int numberOfTensIncrements = value / 10;
                for(int i = 0; i < numberOfTensIncrements; i++)
                {
                    result.Append("X");
                }
                value -= (numberOfTensIncrements * 10);
            }

            if(value >= 9)
            {
                result.Append("IX");
                value -= 9;
            }

            if(value >= 5)
            {
                result.Append("V");
                value -= 5;
            }

            if(value >= 4)
            {
                result.Append("IV");
                value -= 4;
            }

            if(value > 0)
            {
                for(int i = 0; i < value; i++)
                {
                    result.Append("I");
                }
            }

            return result.ToString();
        }
    }
}
