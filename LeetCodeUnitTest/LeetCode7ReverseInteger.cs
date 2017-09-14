using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    /// <remarks>
    /// 這太他媽懶了，沒有認真寫測試…結果去LEETCODE上被退了兩次
    /// 有兩個沒有考慮到的例外，這是TDD的用意之一嗎？
    /// 那測試沒想到的話也是GG XD
    /// </remarks>
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
