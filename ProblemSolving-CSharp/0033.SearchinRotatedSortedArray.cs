using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0033
    {
        public int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                    return middle;

                // left part is non-rotated?
                if (nums[left] <= nums[middle])
                {
                    // if the target is in the left part, keep on serching there
                    if (target >= nums[left] && target <= nums[middle])
                        right = middle - 1;
                    else
                        // else, keep on searching in the right part
                        left = middle + 1;
                }
                else // right part is non-rotated
                {
                    // is target is on the right side?
                    if (target >= nums[middle] && target <= nums[right])
                        left = middle + 1;
                    else
                        right = middle - 1;
                }
            }

            return -1;
        }
    }
}
