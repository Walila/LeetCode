using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Solution
    {
		#region test222
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
            int    max    = 0;
            string maxStr = "";
            int    length = s.Length;

            for (int i = 0; i < length; ++i)
            {
                int head = i-1;
                int tail = i+1;
                int current = 1;
                
                for (; head > -1 && tail < length; --head, ++tail)
                {
                    if (s[head] == s[tail])
                        current += 2;
                    else
                        break;
                }
                if(current > max)
                {
                    max = current;
                    maxStr = s.Substring(head + 1, max);
                }

                head = i;
                tail = i + 1;
                current = 0;
                for (; head > -1 && tail < length; --head, ++tail)
                {
                    if (s[head] == s[tail])
                        current += 2;
                    else
                        break;
                }
                if (current > max)
                {
                    max = current;
                    maxStr = s.Substring(head + 1, max);
                }
            }

            return maxStr;
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

        #region LeetCode 7
        public int Reverse(int x)
        {
            // int range : 2147483647 ~ -2147483648
            bool isP = x == (uint)x;
            Queue<sbyte> queue = new Queue<sbyte>();

            int r = 0;
            for (int i = 0; i < 10 && (x > 0 || x < 0 ); ++i)
            {
                int n = x % 10;
                queue.Enqueue((sbyte)n);
                x = x / 10;
            }
            int last = 0;
            var qcount = queue.Count;
            for (int i = 0; i < qcount; ++i)
            {
                r *= 10;                
                r += queue.Dequeue();
                if (isP && (r / 10 < last)) return 0;
                if (!isP && (r / 10 > last)) return 0;
                last = r;
            }
            return r;
        }
        #endregion

        #region LeetCode 8
        // int.MaxValue =  2147483647
        // int.MinValue = -2147483648
        // 43 45 48 49 50 51 52 53 54 55 56 57
        private static HashSet<char> integerChar = new HashSet<char>() { '+', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ' };
        public int MyAtoi(string str)
        {
            int result = 0;
            bool startFlag = false;
            bool sign = true;//正為true，負為false
            for (int i = 0; i < str.Length; ++i)
            {
                if (!startFlag && !integerChar.Contains(str[i]))
                    return 0;

                int currentNumber = str[i] - 48; //做這個連前面空白的事也擋掉了，怎麼這麼好 …，等一下來測一下

                if (startFlag)
                {
                    if ((-3).Equals(currentNumber) || (-5).Equals(currentNumber))
                        return 0;
                    if ((currentNumber < 0 || currentNumber > 9))
                        return result * (sign ? 1 : -1);
                }

                if ((!startFlag && currentNumber < 1))
                {
                    if (currentNumber.Equals(-3))
                    {
                        startFlag = true;
                        sign = false;
                    }
                    if (currentNumber.Equals(-5))
                        startFlag = true;
                    continue;
                }
                else
                    startFlag = true;


                if(214748364.Equals(result))
                {
                    if (sign && currentNumber > 7)
                        return int.MaxValue;
                    if (!sign && currentNumber > 8)
                        return int.MinValue;
                }
                else if(214748364 < result)
                {
                    return sign ? int.MaxValue : int.MinValue;
                }

                result *= 10;
                result += currentNumber;
            }
            return result * (sign ? 1 : -1);
        }
        #endregion LeetCode 8

        #region LeetCode 9
        public bool IsMatch(string s, string p)
        {
            if(string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p))
                return true;
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p))
                return false;

            return s.Equals(p);
        }
        #endregion LeetCode 9
    }
        
}
