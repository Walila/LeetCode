using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    [TestClass]
    public class LeetCode7ReverseInteger
    {
        [TestMethod]
        public void I_5_O_5()
        {
            int input = 5;
            int expected = 5;
            int actual = Reverse(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void I_m5_O_m5()
        {
            int input = -5;
            int expected = -5;
            int actual = Reverse(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void I_12_O_21()
        {
            int input = 12;
            int expected = 21;
            int actual = Reverse(input);
            Assert.AreEqual(expected, actual);
        }

        private int Reverse(int x)
        {
            Solutions.Solution sol = new Solutions.Solution();
            return sol.Reverse(x);
        }
    }
}
