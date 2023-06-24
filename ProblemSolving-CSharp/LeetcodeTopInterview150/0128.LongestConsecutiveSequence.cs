using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0055
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> storage = new HashSet<int>(nums);

            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (storage.Contains(nums[i] - 1))
                {
                    continue;
                }

                int current = nums[i];
                int countFromCurrentInclusive = 0;

                while (storage.Contains(current))
                {
                    countFromCurrentInclusive++;
                    current++;
                }

                if (countFromCurrentInclusive > maxCount)
                {
                    maxCount = countFromCurrentInclusive;
                }
            }

            return maxCount;
        }
    }
}
