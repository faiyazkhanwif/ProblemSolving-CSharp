using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0080
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
            { // If array length is 2 or less, no duplicates to remove
                return nums.Length;
            }

            int count = 2;

            for (int i = 2; i < nums.Length; i++)
            { // Iterate through the array starting from the third element
                if (nums[i] != nums[count - 2])
                { // If current element is different from element at count-2, it is a non-duplicate
                    nums[count] = nums[i]; // Overwrite duplicates with non-duplicates
                    count++; // Increment count of non-duplicates
                }
            }

            return count; // Length of modified array with duplicates removed
        }
    }
}
