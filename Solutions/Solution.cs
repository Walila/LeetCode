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
    }
}
