using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0034
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2];
            result[0] = -1;
            result[1] = -1;

            int start = 0;
            int end = nums.Length - 1;

            //find start index
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target == nums[mid])
                {
                    result[0] = mid;
                }

                if (target == nums[mid] || target < nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            start = 0;
            end = nums.Length - 1;

            //find end index
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target == nums[mid])
                {
                    result[1] = mid;
                }

                if (target == nums[mid] || target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }
    }
}
