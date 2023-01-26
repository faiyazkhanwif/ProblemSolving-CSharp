using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0128
    {
        //O(nlogn)
        public int LongestConsecutive(int[] nums)
        {
            int seqLen = 0;
            if (nums.Length == 0)
            {
                return seqLen;
            }
            Array.Sort(nums);
            int tempLen = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 == nums.Length)
                {
                    if (tempLen > seqLen)
                    {
                        seqLen = tempLen;
                    }
                    tempLen = 0;
                    break;
                }

                if (nums[i + 1] - nums[i] == 1)
                {
                    tempLen++;
                }
                else if (nums[i + 1] - nums[i] == 0)
                {
                    continue;
                }
                else
                {
                    if (tempLen > seqLen)
                    {
                        seqLen = tempLen;
                    }
                    tempLen = 0;
                }
            }

            return seqLen + 1; //Minimum length is 1 for 1 element.
        }

        //O(n)
        public int LongestConsecutiveOpti(int[] nums)
        {
            int count = 0;
            int maxCount = 0;
            HashSet<int> tracker = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!tracker.Contains(nums[i]))
                {
                    tracker.Add(nums[i]);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!tracker.Contains(nums[i] - 1))
                {// check if this is the smallest element in the current sequence
                    count = 0;
                    int current = nums[i];
                    while (tracker.Contains(current))
                    {  // as long as there is a next element in the current sequence we loop through the values
                        count = count + 1;
                        current = current + 1;
                    }
                    maxCount = Math.Max(maxCount, count);
                }
            }
            return maxCount;
        }
    }
}
