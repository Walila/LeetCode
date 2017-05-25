using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    [TestClass]
    public class LeetCode6ZigZagConversion
    {
        [TestMethod]
        public void I_PAHNAPLSIIGYIR_3_O_PAHNAPLSIIGYIR()
        {
            var input = "PAHNAPLSIIGYIR";
            var expect = "PAHNAPLSIIGYIR";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        private string Convert(string s, int numRows)
        {
            Solutions.Solution sol = new Solutions.Solution();
            return sol.Convert(s, numRows);
        }
    }
}
