using System;
using NUnit.Framework;
using Solutions;
using static Solutions.Solution;

namespace Solutions.UnitTests
{
    [TestFixture]
    public class LeetCode002AddTwoNumbers
    {
        [Test]
        public void Input1_2_3And2_3_4Output3_5_7()
        {
            ListNode expect = CreateNodeList(new int[] { 3, 5, 7 });
            
            ListNode l1 = CreateNodeList(new int[] { 1, 2, 3 });
            ListNode l2 = CreateNodeList(new int[] { 2, 3, 4 });

            var actual = AddTwoNumbers(l1, l2);
            ShouldEqual(expect, actual);
        }

        [Test]
        public void Input1_4_2And4_8_3Output5_2_6()
        {
            ListNode expect = CreateNodeList(new int[] { 5, 2, 6 });

            ListNode l1 = CreateNodeList(new int[] { 1, 4, 2 });
            ListNode l2 = CreateNodeList(new int[] { 4, 8, 3 });

            var actual = AddTwoNumbers(l1, l2);
            ShouldEqual(expect, actual);
        }

        [Test]
        public void Input2_4_6And4_6_8Output6_0_5_1()
        {
            ListNode expect = CreateNodeList(new int[] { 6, 0, 5, 1 });

            ListNode l1 = CreateNodeList(new int[] { 2, 4, 6 });
            ListNode l2 = CreateNodeList(new int[] { 4, 6, 8 });

            var actual = AddTwoNumbers(l1, l2);
            ShouldEqual(expect, actual);
        }

        private static ListNode CreateNodeList(int[] nums)
        {
            ListNode list = new ListNode(nums[0]);
            var last = list;
            for(int i =1;i<nums.Length;++i)
            {
                last.next = new ListNode(nums[i]);
                last = last.next;
            }
            return list;
        }

        private static ListNode AddTwoNumbers(ListNode node1, ListNode node2)
        {
            var sol = new Solution();
            return sol.AddTwoNumbers(node1, node2);
        }

        private static void ShouldEqual(ListNode expect, ListNode actual)
        {
            for(; expect!=null;expect = expect.next, actual = actual.next)
            {
                Assert.AreEqual(expect.val, actual.val);
            }

            Assert.IsNull(expect);
            Assert.IsNull(actual);
        }
    }
}
