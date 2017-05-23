using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace LeetCodeUnitTest
{
    [TestClass]
    public class LeetCode3LengthOfLongestSubstring
    {
        [TestMethod]
        public void Input_abc_return_3()
        {
            var input = "abc";
            int expect = 3;
            int actual = LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_aacbc_return_3()
        {
            var input = "aacbc";
            int expect = 3;
            int actual = LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_badacbcrr_return_5()
        {
            var input = "badacbcrr";
            int expect = 5;
            int actual = LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_pwwkew_return_3()
        {
            var input = "pwwkew";
            int expect = 3;
            int actual = LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_jbpnbwwd_return_4()
        {
            var input = "jbpnbwwd";
            int expect = 4;
            int actual = LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_longstring_return_94()
        {
            var input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            int expect = 94;
            int actual = LengthOfLongestSubstring(input);

            Assert.AreEqual(expect, actual);
        }



        private int LengthOfLongestSubstring(string s)
        {
            Solution sol = new Solution();
            return sol.LengthOfLongestSubstring(s);
        }
    }
}
