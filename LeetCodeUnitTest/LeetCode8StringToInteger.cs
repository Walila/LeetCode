using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    // int.MaxValue =  2147483647
    // int.MinValue = -2147483648
    //超認真的測試啊，再加個亂七八糟的就應該沒問題了
    //幹，結果還是POST了三次才過，根本誤會題目的意思 … 
    //英文太差 … 
    [TestClass]
    public class LeetCode8StringToInteger
    {
        #region 輸入輸出為0
        [TestMethod]
        public void IO_0()
        {
            string input = "0";
            int    actual = MyAtoi(input);
            int    expected = 0;
            Assert.AreEqual(expected, actual);
        }
        #endregion 輸入輸出為0

        #region 下面先來幾個正數，不大於int.MaxValue的
        [TestMethod]
        public void IO_5()
        {
            string input = "5";
            int actual = MyAtoi(input);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IO_9487()
        {
            string input = "9487";
            int actual = MyAtoi(input);
            int expected = 9487;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IO_987654321()
        {
            string input = "987654321";
            int actual = MyAtoi(input);
            int expected = 987654321;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IO_2147483647()
        {
            string input = "2147483647";
            int actual = MyAtoi(input);
            int expected = 2147483647;
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void IO_58()
        {
            string input = "58";
            int actual = MyAtoi(input);
            int expected = 58;
            Assert.AreEqual(expected, actual);
        }
        #endregion 下面先來幾個正數，不大於int.MaxValue的
        
        #region 再來做簡單點的，前面偷放0的…
        [TestMethod]
        public void I_00000000_O_0()
        {
            string input = "00000000";
            int actual = MyAtoi(input);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_00001234_O_1234()
        {
            string input = "00001234";
            int actual = MyAtoi(input);
            int expected = 1234;
            Assert.AreEqual(expected, actual);
        }
        #endregion 再來做簡單點的，前面偷放0的…
        
        #region 可以做正負號了
        [TestMethod]
        public void I_p1234_O_1234()
        {
            string input = "+1234";
            int actual = MyAtoi(input);
            int expected = 1234;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_m1234_O_m1234()
        {
            string input = "-1234";
            int actual = MyAtoi(input);
            int expected = -1234;
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void I_m12390540_O_m12390540()
        {
            string input = "-12390540";
            int actual = MyAtoi(input);
            int expected = -12390540;
            Assert.AreEqual(expected, actual);
        }
        #endregion 可以做正負號了
        
        #region 超過上限值2147483647
        [TestMethod]
        public void I_2147483648_O_2147483647()
        {
            string input = "2147483648";
            int actual = MyAtoi(input);
            int expected = int.MaxValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_11147483648_O_2147483647()
        {
            string input = "11147483648";
            int actual = MyAtoi(input);
            int expected = int.MaxValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_m2147483648_O_m2147483648()
        {
            string input = "-2147483648";
            int actual = MyAtoi(input);
            int expected = -2147483648;
            Assert.AreEqual(expected, actual);
        }
        #endregion 超過上限值2147483647

        #region 超過下限值-2147483648
        [TestMethod]
        public void I_m2147483649_O_m2147483648()
        {
            string input = "-2147483648";
            int actual = MyAtoi(input);
            int expected = int.MinValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_m11147483648_O_m2147483648()
        {
            string input = "-11147483648";
            int actual = MyAtoi(input);
            int expected = int.MinValue;
            Assert.AreEqual(expected, actual);
        }
        #endregion 超過下限值-2147483648

        #region 前面來點空白
        [TestMethod]
        public void I_sssss1234_O_1234()
        {
            string input = "     1234";
            int actual = MyAtoi(input);
            int expected = 1234;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_ssssssm15234_O_15234()
        {
            string input = "      -15234";
            int actual = MyAtoi(input);
            int expected = -15234;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_sssssssp15234_O_15234()
        {
            string input = "       +15234";
            int actual = MyAtoi(input);
            int expected = 15234;
            Assert.AreEqual(expected, actual);
        }
        #endregion 前面來點空白

        #region 前面讀到的第一個字元是奇怪東西

        [TestMethod]
        public void I_xm12390540_O_0()
        {
            string input = "x-12390540";
            int actual = MyAtoi(input);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_slash12390540_O_0()
        {
            string input = "/12390540";
            int actual = MyAtoi(input);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        #endregion 前面讀到的第一個字元是奇怪東西

        #region 裡面的字元有奇怪的東西

        [TestMethod]
        public void I_1239slash0540_O_m1239()
        {
            string input = "1239/0540";
            int actual = MyAtoi(input);
            int expected = 1239;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_1q2w3e9r0t5y4u0_O_1()
        {
            string input = "1q2w3e9r0t5y4u0";
            int actual = MyAtoi(input);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void I_sssm8541236mdf7_O_12390540()
        {
            string input = "   -8541236mdf7";
            int actual = MyAtoi(input);
            int expected = -8541236;
            Assert.AreEqual(expected, actual);
        }
        #endregion 裡面的字元有奇怪的東西

        #region 來點亂七八糟的
        [TestMethod]
        public void I_ssm9sxyzw8e7q6t5r4e3g2h1j_O_()
        {
            string input = "  -9 xyzw8e7q6t5r4e3g2h1j";
            int actual = MyAtoi(input);
            int expected = -9;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_ssmsx9yzw8e7q6t5r4e3g2h1j_O_()
        {
            string input = "  - x9yzw8e7q6t5r4e3g2h1j";
            int actual = MyAtoi(input);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        #endregion

        private int MyAtoi(string str)
        {
            Solutions.Solution sol = new Solutions.Solution();
            return sol.MyAtoi(str);
        }
    }
}
