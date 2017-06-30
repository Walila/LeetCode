using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Solution
    {
		#region test
		#endregion
		
        #region LeetCode 1
        public int[] TwoSum(int[] nums, int target)
        {
            var sortedDic = nums.Select((x, i) => new Tuple<int, int>(x, i)).OrderBy(x => x.Item1)
                .Select((x, i) => new { element = x, index = i }).ToDictionary(k => k.index, v => v.element);

            var start = 0;
            var end = nums.Count() - 1;

            for (; start < end;)
            {
                if (sortedDic[start].Item1 + sortedDic[end].Item1 == target)
                    return new int[] { sortedDic[start].Item2, sortedDic[end].Item2 };
                if (sortedDic[start].Item1 + sortedDic[end].Item1 > target)
                    --end;
                else
                    ++start;
            }

            return new int[] { -1, -1 };
        }
        #endregion

        #region LeetCode 2
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode last;
            int num = ((l1?.val ?? 0) + (l2?.val ?? 0));
            bool hasCarry = num / 10 > 0;

            ListNode list = new ListNode(num % 10);

            last = list;
            l1 = l1.next;
            l2 = l2.next;

            for (; l1 != null || l2 != null || hasCarry; l1 = l1?.next, l2 = l2?.next)
            {
                num = (l1?.val ?? 0) + (l2?.val ?? 0) + (hasCarry ? 1 : 0);
                hasCarry = num / 10 > 0;
                last.next = new ListNode(num % 10);
                last = last.next;
            }

            return list;
        }
        #endregion

        #region LeetCode 3
        /// <remarks>原來HASHMAP什麼的資料結構真的有差，快很多 … 
        /// 這個本來用STRING做的，效率差很多 …
        /// </remarks>
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> temp = new HashSet<char>();
            int longest = 0;
            int index = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (temp.Contains(s[i]))
                {
                    if (temp.Count > longest)
                    {
                        longest = temp.Count;
                    }

                    temp.Clear();
                    i = index;
                    ++index;

                }
                else
                {
                    temp.Add(s[i]);
                }
            }

            return (temp.Count > longest) ? temp.Count : longest;
        }
        #endregion

        #region LeetCode 4
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int totalLength = nums1.Length + nums2.Length;
            bool isEven = 0.Equals(totalLength % 2);
            Stack<int> stack = new Stack<int>();
            int x = 0, y = 0;
            for (int i = 0; i <= totalLength / 2; ++i)
            {
                if (y > nums2.Length - 1 || (x < nums1.Length && nums1[x] < nums2[y]))
                {
                    stack.Push(nums1[x++]);
                }
                else
                {
                    stack.Push(nums2[y++]);
                }
            }
            if (isEven)
                return (stack.Pop() + stack.Pop()) / 2.0;
            return stack.Pop();

        }
        #endregion

        #region LeetCode 5
        public string LongestPalindrome(string s)
        {
            return "bab";
        }
        #endregion

        #region LeetCode 6
        public string Convert(string s, int numRows)
        {
            string str = "";
            
            int y = 0;
            int length = s.Length;
            if (length <= numRows || numRows == 1) return s;

            for (int row = 1; row <= numRows; ++row)
            {
                y = row;
                str += s[y - 1];

                for (;;)
                {
                    if ((numRows > row) )
                    {
                        y += (numRows - row) * 2;
                        if (y > length) break;
                        str += s[y - 1];
                    }

                    if (row > 1)
                    {
                        y += (row - 1) * 2;
                        if (y > length) break;
                        str += s[y - 1];
                    }
                }
            }

            return str;
        }
        #endregion

    }
        
}
