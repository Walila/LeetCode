using System;
using NUnit.Framework;

namespace Solutions.UnitTests
{
    [TestFixture]
    public class LeetCode004MidianOfTwoSortedArrays
    {
        [Test]
        public void In_1_2And_3_Out_2()
        {
            int[] nums1 = new int[]{ 1, 2 };
            int[] nums2 = new int[] { 3 };

            double expect = 2.0;
            double actual = FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void In_1_2And_3_4_Out_2p5()
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };

            double expect = 2.5;
            double actual = FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void In_3_4And_1_2_Out_2p5()
        {
            int[] nums1 = new int[] { 3, 4 };
            int[] nums2 = new int[] { 1, 2 };

            double expect = 2.5;
            double actual = FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void In_two_same_long_int_arr_Out_lengthm0p5p5()
        {
            int length = 100;
            int[] nums1 = new int[length];
            int[] nums2 = new int[length];

            for(int i=1;i<=length;++i)
            {
                nums1[i-1] = i;
                nums2[i-1] = i;
            }

            double expect = 0.5 + (length * 0.5);
            double actual = FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void In_two_different_long_int_arr_Out_lengthp5()
        {
            int length = 100;
            int[] nums1 = new int[length];
            int[] nums2 = new int[length];

            for (int i = 1; i <= length; ++i)
            {
                nums1[i - 1] = i * 2;
                nums2[i - 1] = i * 2 - 1;
            }

            double expect = 0.5 + length;
            double actual = FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void In_two_different_long_int_arr2_Out_lengthp5()
        {
            int length = 1000;
            int[] nums1 = new int[length];
            int[] nums2 = new int[length];

            for (int i = 1; i <= length; ++i)
            {
                nums1[i - 1] = i;
                nums2[i - 1] = i + length;
            }

            double expect = 0.5 + length;
            double actual = FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expect, actual);
        }


        private double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            Solutions.Solution sol = new Solutions.Solution();
            return sol.FindMedianSortedArrays(nums1, nums2);
        }
    }
}
