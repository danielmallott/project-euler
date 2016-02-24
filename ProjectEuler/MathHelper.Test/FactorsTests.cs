using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace MathHelper.Test
{
    [TestClass]
    public class FactorsTests
    {
        [TestMethod]
        public void Test_FindFactors_Two()
        {
            var expectedResult = new List<long>() { 1, 2 };
            var result = Factors.FindFactors(2);
            Assert.AreEqual(2, result.Count());
            foreach(long expectedFactor in expectedResult)
            {
                Assert.IsTrue(result.Contains(expectedFactor));
            }
        }

        [TestMethod]
        public void Test_FindFactors_Three()
        {
            var expectedResult = new List<long>() { 1, 3 };
            var result = Factors.FindFactors(3);
            Assert.AreEqual(2, result.Count());
            foreach(long expectedFactor in expectedResult)
            {
                Assert.IsTrue(result.Contains(expectedFactor));
            }
        }

        [TestMethod]
        public void Test_FindFactors_Eighteen()
        {
            var expectedResult = new List<long>() { 1, 2, 3, 6, 9, 18 };
            var result = Factors.FindFactors(18);
            Assert.AreEqual(6, result.Count());
            foreach(long expectedFactor in expectedResult)
            {
                Assert.IsTrue(result.Contains(expectedFactor));
            }
        }

        [TestMethod]
        public void Test_FindFactors_Nine()
        {
            var expectedResult = new List<long>() { 1, 3, 9 };
            var result = Factors.FindFactors(9);
            Assert.AreEqual(3, result.Count());
            foreach(long expectedFactor in expectedResult)
            {
                Assert.IsTrue(result.Contains(expectedFactor));
            }
        }
    }
}
