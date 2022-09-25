using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6189
    {
        public int LongestSubarray(int[] nums)
        {
            int n = nums.Length;

            Dictionary<int, int> ANDValLength = new Dictionary<int, int>();

            int maxAND = int.MinValue;
            // Initialize result 

            // Pick starting points of subarrays 
            for (int i = 0; i < n; i++)
            {
                // to store AND of current subarray  
                int curr_and = 0;

                // Pick ending points of  
                // subarrays starting with i 
                for (int j = i; j < n; j++)
                {
                    curr_and = curr_and & nums[j];
                    if (ANDValLength.ContainsKey(curr_and))
                    {
                        ANDValLength[curr_and] = Math.Max(j + 1, ANDValLength[curr_and]);
                    }
                    else
                    {
                        ANDValLength[curr_and] = j + 1;
                    }
                    maxAND = Math.Max(maxAND, curr_and);
                }
            }
            return ANDValLength[maxAND];
        }
    }
}
