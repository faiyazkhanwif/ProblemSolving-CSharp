using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6360
    {
        public int MinImpossibleOR(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            // Find all possible bitwise OR of the possible subsequences
            for (int i = 0; i < nums.Length; i++)
            {
                int result = nums[i];
                set.Add(result);

                foreach (int val in set.ToList())
                {
                    result = val | nums[i];
                    set.Add(result);
                }
            }
            int min = 1;
            while (set.Contains(min))
            {
                min++;
            }
            return min;
        }
    }
}
