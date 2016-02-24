using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathHelper.Test
{
    [TestClass]
    public class PrimesTests
    {
        [TestMethod]
        public void Test_IntegerIsPrime_Two()
        {
            bool result = Primes.IntegerIsPrime(2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_IntegerIsPrime_Three()
        {
            bool result = Primes.IntegerIsPrime(3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_IntegerIsPrime_Four()
        {
            bool result = Primes.IntegerIsPrime(4);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_IntegerIsPrime_Five()
        {
            bool result = Primes.IntegerIsPrime(5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_IntegerIsPrime_TwentySeven()
        {
            bool result = Primes.IntegerIsPrime(27);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_IntegerIsPrime_NinetySeven()
        {
            bool result = Primes.IntegerIsPrime(97);
            Assert.IsTrue(result);
        }
    }
}
