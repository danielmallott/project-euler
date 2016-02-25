using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathHelper.Test
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void Test_CalculateRomanNumeralValue_One()
        {
            var result = RomanNumerals.CalculateRomanNumeralValue("I");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeralValue_Four()
        {
            var result = RomanNumerals.CalculateRomanNumeralValue("IV");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeralValue_Fourteen()
        {
            var result = RomanNumerals.CalculateRomanNumeralValue("XIV");
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeralValue_OneThousandNineHundred()
        {
            var result = RomanNumerals.CalculateRomanNumeralValue("MCM");
            Assert.AreEqual(1900, result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_One()
        {
            var result = RomanNumerals.CalculateRomanNumeral(1);
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_Two()
        {
            var result = RomanNumerals.CalculateRomanNumeral(2);
            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_Four()
        {
            var result = RomanNumerals.CalculateRomanNumeral(4);
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_Six()
        {
            var result = RomanNumerals.CalculateRomanNumeral(6);
            Assert.AreEqual("VI", result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_Ten()
        {
            var result = RomanNumerals.CalculateRomanNumeral(10);
            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_Nineteen()
        {
            var result = RomanNumerals.CalculateRomanNumeral(19);
            Assert.AreEqual("XIX", result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_FortyNine()
        {
            var result = RomanNumerals.CalculateRomanNumeral(49);
            Assert.AreEqual("XLIX", result);
        }

        [TestMethod]
        public void Test_CalculateRomanNumeral_OneThousandSixHundredSix()
        {
            var result = RomanNumerals.CalculateRomanNumeral(1606);
            Assert.AreEqual("MDCVI", result);
        }
    }
}
