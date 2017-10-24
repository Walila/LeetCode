using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Solutions.UnitTests
{
    [TestFixture]
    public class LeetCode10RegularExpressionMatchingTest
    {
        [Test]
        public void I_null_null_O_T()
        {
            string str = null;
            string pattern = null;
            bool result = IsMatch(str, pattern);
            Assert.True(result);
        }

        [Test]
        public void I_a_a_O_T()
        {
            string str = "a";
            string pattern = "a";
            bool result = IsMatch(str, pattern);
            Assert.True(result);
        }

        [TestCase("B")]
        [TestCase("C")]
        [TestCase("D")]
        public void s_notA_p_A_O_F(string str)
        {
            //string str = "a";
            string pattern = "A";
            bool result = IsMatch(str, pattern);
            Assert.False(result);
        }

        private bool IsMatch(string s, string p)
        {
            Solution sol = new Solution();
            return sol.IsMatch(s, p);
        }
    }
}
