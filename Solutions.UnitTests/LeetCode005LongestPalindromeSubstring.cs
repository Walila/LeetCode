using System;
using NUnit.Framework;
using System.Linq;

namespace Solutions.UnitTests
{
    [TestFixture]
    public class LeetCode005LongestPalindromeSubstring
    {
        [Test]
        public void I_abaxyz_O_aba()
        {
            var input = "abaxyz";
            var expect = "aba";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void I_xyzaba_O_aba()
        {
            var input = "xyzaba";
            var expect = "aba";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void I_zrabaxz_O_aba()
        {
            var input = "zrabaxz";
            var expect = "aba";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_zrabbaxz_O_abba()
        {
            var input = "zrabbaxz";
            var expect = "abba";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void I_zrdgabba_O_abba()
        {
            var input = "zrdgabba";
            var expect = "abba";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void I_abbafexz_O_abba()
        {
            var input = "abbafexz";
            var expect = "abba";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void I_babad_O_bab()
        {
            var input = "babad";
            var expect = new string[] { "bab", "aba" };
            var actual = LongestPalindrome(input);

            Assert.IsTrue(expect.Contains(actual));
        }

        [Test]
        public void I_abcbaabcba_O_abcbaabcba()
        {
            var input = "abcbaabcba";
            var expect = "abcbaabcba";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_abcbaabcbaqwertyuiopoiuytrewq_O_qwertyuiopoiuytrewq()
        {
            var input = "abcbaabcbaqwertyuiopoiuytrewq";
            var expect = "qwertyuiopoiuytrewq";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_qwertyuiopasdfghjklzxcvbnmmnbvcxzlkjhgfdsapoiuytrewqwertyuiop_O_qwertyuiopasdfghjklzxcvbnmmnbvcxzlkjhgfdsapoiuytrewq()
        {
            var input = "qwertyuiopasdfghjklzxcvbnmmnbvcxzlkjhgfdsapoiuytrewqwertyuiop";
            var expect = "qwertyuiopasdfghjklzxcvbnmmnbvcxzlkjhgfdsapoiuytrewq";
            var actual = LongestPalindrome(input);

            Assert.AreEqual(expect, actual);
        }


        private string LongestPalindrome(string s)
        {
            Solutions.Solution sol = new Solutions.Solution();
            return sol.LongestPalindrome(s);
        }
    }
}
