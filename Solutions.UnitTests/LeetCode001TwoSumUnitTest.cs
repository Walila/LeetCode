using System;
using Solutions;
using System.Linq;
using NUnit.Framework;

namespace Solutions.UnitTests
{
    [TestFixture]
    public class LeetCode001TwoSumUnitTest
    {
        [Test]
        public void Input_1_8_Target_9()
        {
            var num = new int[] { 1, 8 };
            var target = 9;
            var expect = new int[] { 0, 1 };
            
            var actual = TwoSum(num, target);
            ShouldEqual(expect, actual);
        }

        [Test]
        public void Input_1_8_3_7Target_9()
        {
            var num = new int[] { 1, 8, 3, 7 };
            var target = 9;
            var expect = new int[] { 0, 1 };
            
            var actual = TwoSum(num, target);
            ShouldEqual(expect, actual);
        }

        [Test]
        public void Input_1_2_4_7Target_6()
        {
            var num = new int[] { 1, 2, 4, 7 };
            var target = 6;
            var expect = new int[] { 1, 2 };

            var actual = TwoSum(num, target);
            ShouldEqual(expect, actual);
        }

        [Test]
        public void Input_3_8_5_2Target10()
        {

            var num = new int[] { 3, 8, 5, 2 };
            var target = 10;
            var expect = new int[] { 1, 3 };

            var actual = TwoSum(num, target);
            ShouldEqual(expect, actual);
        }

        [Test]
        public void Input_1_3_5_7_9_2_4_6_8Target17()
        {

            var num = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
            var target = 17;
            var expect = new int[] { 4, 8 };

            var actual = TwoSum(num, target);
            ShouldEqual(expect, actual);
        }

        private static int[] TwoSum(int[] num, int target)
        {
            var sol = new Solution();
            return sol.TwoSum(num, target);
        }

        private static void ShouldEqual(int[] expect, int[] actual)
        {
            CollectionAssert.AreEqual(expect.OrderBy(x => x).ToArray(), actual.OrderBy(x => x).ToArray());
            
        }

    }
}
