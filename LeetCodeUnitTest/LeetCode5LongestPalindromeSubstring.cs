using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCodeUnitTest
{
    [TestClass]
    public class LeetCode5LongestPalindromeSubstring
    {
        [TestMethod]
        public void I_babad_O_bab()
        {
            var input = "babad";
            var expect = new string[] { "bab", "aba" };
            var actual = LongestPalindrome(input);

            Assert.IsTrue(expect.Contains(actual));
        }

        private string LongestPalindrome(string s)
        {
            Solutions.Solution sol = new Solutions.Solution();
            return sol.LongestPalindrome(s);
        }
    }
}
