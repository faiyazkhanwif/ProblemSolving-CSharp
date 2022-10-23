using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0209
    {
        // O(n) - Dynamic sliding window
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minSubArrLength = nums.Length;

            int subArrayLength = 0;
            int subArrayStartInd = 0;

            int runningSum = 0;

            int totalSum = 0; //For an edge case where the sum of nums is smaller than target.

            for (int i = 0; i < nums.Length; i++)
            {
                totalSum += nums[i]; //For the edge case

                runningSum += nums[i];
                subArrayLength++;

                if (runningSum >= target)
                {
                    if (subArrayLength < minSubArrLength)
                    {
                        minSubArrLength = subArrayLength;
                    }

                    if (minSubArrLength == 1)
                    {
                        return minSubArrLength;
                    }

                    //As current window adds up to the target, we try to shrink the window 
                    while (runningSum>=target && subArrayStartInd<nums.Length)
                    {
                        runningSum -= nums[subArrayStartInd];
                        subArrayStartInd++;
                        subArrayLength--;
                        if (runningSum>=target && minSubArrLength>subArrayLength)
                        {
                            minSubArrLength = subArrayLength;
                        }
                    }
                }

            }

            //For the edge case
            if (totalSum<target)
            {
                return 0;
            }


            return minSubArrLength;
        }
    }
}
