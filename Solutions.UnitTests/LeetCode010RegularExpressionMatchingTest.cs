using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Solutions.UnitTests
{
    //從這題開始換成NUnit
    //可以有不同的TestCase感覺不錯
    [TestFixture]
    public class LeetCode010RegularExpressionMatchingTest
    {
        //都是NULL
        [Test]
        public void I_null_null_O_T()
        {
            string str = null;
            string pattern = null;
            bool result = IsMatch(str, pattern);
            Assert.IsTrue(result);
        }

        //都是字串a
        [Test]
        public void I_a_a_O_T()
        {
            string str = "a";
            string pattern = "a";
            bool result = IsMatch(str, pattern);
            Assert.IsTrue(result);
        }

        //pattern是A，輸入不是
        [TestCase("B")]
        [TestCase("C")]
        [TestCase("D")]
        public void I_notA_p_A_O_F(string str)
        {
            //string str = "a";
            string pattern = "A";
            bool result = IsMatch(str, pattern);
            Assert.IsFalse(result);
        }

        //輸入和pattern一樣
        [Test]
        public void S_and_P_are_The_Same()
        {
            string str = "abcde";
            bool result = IsMatch(str, str);
            Assert.IsTrue(result);

            str = "d 29fd5";
            result = IsMatch(str, str);
            Assert.IsTrue(result);
        }

        //輸入和pattern不同
        [TestCase("abcd", TestName = "I abcd to abcde")]
        [TestCase("abcdef", TestName = "I abcdef to abcde")]
        [TestCase("bcde", TestName = "I bcde to abcde")]
        [TestCase("abc de", TestName = "I abc de to abcde")]
        public void p_abcde_O_F(string str)
        {
            string pattern = "abcde";
            bool result = IsMatch(str, pattern);
            Assert.IsFalse(result);
        }
        
        //加一個星號的測試
        [Test]
        public void p_aSbcd_O_T([Values("abcd", "bcd", "aaabcd")] string str)
        {
            string pattern = "a*bcd";
            bool result = IsMatch(str, pattern);
            Assert.IsTrue(result);
        }

        //pattern加兩個星號的測試
        [TestCase("bd", TestName = "I bd to a*bc*d")]
        [TestCase("abd", TestName = "I abd to a*bc*d")]
        [TestCase("bcd", TestName = "I bcd to a*bc*d")]
        [TestCase("abcd", TestName = "I abcd to a*bc*d")]
        [TestCase("aaaabd", TestName = "I aaaabd to a*bc*d")]
        [TestCase("bccccd", TestName = "I bccccd to a*bc*d")]
        [TestCase("aabcccd", TestName = "I aabcccd to a*bc*d")]
        public void p_aSbcSd_O_F(string str)
        {
            string pattern = "a*bc*d";
            bool result = IsMatch(str, pattern);
            Assert.IsTrue(result);
        }

        private bool IsMatch(string s, string p)
        {
            Solution sol = new Solution();
            return sol.IsMatch(s, p);
        }
    }
}
