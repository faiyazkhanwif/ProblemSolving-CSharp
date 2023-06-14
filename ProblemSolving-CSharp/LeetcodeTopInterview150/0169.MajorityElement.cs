using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0169
    {
        public int MajorityElement(int[] nums)
        {
            int countToBeMatched = nums.Length / 2;
            int index = 0;

            Dictionary<int, int> numsWithCounts = new Dictionary<int, int>();

            while (index < nums.Length)
            {
                if (numsWithCounts.ContainsKey(nums[index]))
                {
                    numsWithCounts[nums[index]]++;
                    if (numsWithCounts[nums[index]] > countToBeMatched)
                    {
                        return nums[index];
                    }
                }
                else
                {
                    numsWithCounts.Add(nums[index], 1);
                }
                index++;
            }

            return nums[0];

        }
    }

}
