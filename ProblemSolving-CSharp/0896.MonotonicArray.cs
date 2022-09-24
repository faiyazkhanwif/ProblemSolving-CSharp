using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0896
    {   //O(n)
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }
            bool increasing = false;
            bool decreasing = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (increasing && decreasing)
                {
                    return false;
                }

                if (nums[i] < nums[i - 1])
                {
                    decreasing = true;
                }

                if (nums[i] > nums[i - 1])
                {
                    increasing = true;
                }
            }

            if (increasing && decreasing)
            {
                return false;
            }

            return true;
        }
    }
}
