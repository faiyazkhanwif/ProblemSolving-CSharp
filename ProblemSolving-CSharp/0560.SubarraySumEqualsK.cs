using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0560
    {
        // Sliding window -- Does not work, contains negative numbers
        public int SubarraySumSW(int[] nums, int k)
        {
            if (nums.Length == 1 && nums[0] == k)
            {
                return 1;
            }
            int subArrayCount = 0;
            int sum = 0;
            int startInd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum >= k)
                {
                    if (sum == k)
                    {
                        subArrayCount++;
                    }
                    while (startInd >= 0 && startInd < i && sum > k)
                    {
                        sum -= nums[startInd];
                        startInd++;
                        if (sum == k)
                        {
                            subArrayCount++;
                        }
                    }
                }
            }

            return subArrayCount;
        }

        //O(n^2) - Brute Force
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > nums.Length - 1)
                    {
                        break;
                    }
                    if (sum == k)
                    {
                        count++;
                    }
                    sum += nums[j];
                }

                if (sum == k)
                {
                    count++;
                }
            }
            return count;
        }

        //O(n)
        public int SubarraySumOpti(int[] nums, int k)
        {
            int count = 0;
            Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
            prefixSumCount.Add(0, 1);
            int runningSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                runningSum += nums[i];

                int diff = runningSum - k;

                if (prefixSumCount.ContainsKey(diff))
                { 
                    count += prefixSumCount[diff];
                }


                if (prefixSumCount.ContainsKey(runningSum))
                {
                    prefixSumCount[runningSum]++;
                }
                else
                {
                    prefixSumCount.Add(runningSum, 1);
                }

            }

            return count;
        }
    }
}
