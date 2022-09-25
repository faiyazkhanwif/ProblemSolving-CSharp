using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6189
    {
        //O(n)
        public int LongestSubarray(int[] nums)
        {
            int maxNum = int.MinValue;
            int subArrLen = 0;
            int res = 0;

            foreach (int num in nums)
            {
                maxNum = Math.Max(maxNum, num);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == maxNum)
                {
                    subArrLen++;
                }
                else
                {
                    subArrLen = 0; // As a subarray is a contiguous sequence of elements, we start the count again.
                }
                res = Math.Max(res, subArrLen); // Check and store the current length if it is larger.
            }
            return res;
        }
    }
}
