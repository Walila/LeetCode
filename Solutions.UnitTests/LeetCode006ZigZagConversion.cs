using System;
using NUnit.Framework;

namespace Solutions.UnitTests
{
    [TestFixture]
    public class LeetCode006ZigZagConversion
    {
        [Test]
        public void I__3_O_()
        {
            var input = "";
            var expect = "";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_A_1_O_A()
        {
            var input = "A";
            var expect = "A";
            var actual = Convert(input, 1);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_AB_1_O_AB()
        {
            var input = "AB";
            var expect = "AB";
            var actual = Convert(input, 1);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_PAYPALISHIRING_3_O_PAHNAPLSIIGYIR()
        {
            var input = "PAYPALISHIRING";
            var expect = "PAHNAPLSIIGYIR";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFG_3_O_AEBDFCG()
        {
            var input = "ABCDEFG";
            var expect = "AEBDFCG";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGH_3_O_AEBDFHCG()
        {
            var input = "ABCDEFGH";
            var expect = "AEBDFHCG";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHI_3_O_AEIBDFHCG()
        {
            var input = "ABCDEFGHI";
            var expect = "AEIBDFHCG";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHIJ_3_O_AEIBDFHJCG()
        {
            var input = "ABCDEFGHIJ";
            var expect = "AEIBDFHJCG";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHIJK_3_O_AEIBDFHJCGK()
        {
            var input = "ABCDEFGHIJK";
            var expect = "AEIBDFHJCGK";
            var actual = Convert(input, 3);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHIJKLMNOP_4_O_AGMBFHLNCEIKODJP()
        {
            var input = "ABCDEFGHIJKLMNOP";
            var expect = "AGMBFHLNCEIKODJP";
            var actual = Convert(input, 4);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHIJKLMNOPQ_4_O_AGMBFHLNCEIKOQDJP()
        {
            var input = "ABCDEFGHIJKLMNOPQ";
            var expect = "AGMBFHLNCEIKOQDJP";
            var actual = Convert(input, 4);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHIJKLMNOPQR_4_O_AGMBFHLNRCEIKOQDJP()
        {
            var input = "ABCDEFGHIJKLMNOPQR";
            var expect = "AGMBFHLNRCEIKOQDJP";
            var actual = Convert(input, 4);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHIJKLMNOPQRS_4_O_AGMSBFHLNRCEIKOQDJP()
        {
            var input = "ABCDEFGHIJKLMNOPQRS";
            var expect = "AGMSBFHLNRCEIKOQDJP";
            var actual = Convert(input, 4);
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void I_ABCDEFGHIJKLMNOPQRST_4_O_AGMSBFHLNRTCEIKOQDJP()
        {
            var input = "ABCDEFGHIJKLMNOPQRST";
            var expect = "AGMSBFHLNRTCEIKOQDJP";
            var actual = Convert(input, 4);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void I_ABCDEFGHIJKLMNOPQRSTU_4_O_AGMSBFHLNRTCEIKOQUDJP()
        {
            var input = "ABCDEFGHIJKLMNOPQRSTU";
            var expect = "AGMSBFHLNRTCEIKOQUDJP";
                        //AGMSBFHLNRTCGKOSDJP
            var actual = Convert(input, 4);
            Assert.AreEqual(expect, actual);
        }


        private string Convert(string s, int numRows)
        {
            Solutions.Solution sol = new Solutions.Solution();
            return sol.Convert(s, numRows);
        }
    }
}
