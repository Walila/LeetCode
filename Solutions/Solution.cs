using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var sortedDic = nums.Select((x, i) => new Tuple<int, int>(x, i)).OrderBy(x => x.Item1)
                .Select((x, i) => new { element = x, index = i }).ToDictionary(k => k.index, v => v.element);

            var start = 0;
            var end   = nums.Count()-1;

            for(;start<end;)
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

            ListNode list = new ListNode( num % 10);

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
    }
}
