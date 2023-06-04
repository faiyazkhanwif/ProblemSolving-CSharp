using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0080
    {
        public class Solution
        {
            public int RemoveDuplicatesOptimized(int[] nums)
            {
                if (nums.Length <= 2)
                { // If array length is 2 or less, no duplicates to remove
                    return nums.Length;
                }

                int count = 2; // Count of allowed duplicates

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

            public int RemoveDuplicates(int[] nums)
            {
                if (nums.Length <= 1) // If array length is 1 or less, no duplicates to remove
                {
                    return nums.Length;
                }

                Dictionary<int, int> countChecker = new Dictionary<int, int>(); // Keeps track of number counts

                int left = 1; // Left pointer which tracks the index for the next unique value, also counts the number of unique values.
                int right = 1; // Right pointer which iterates through the array to find duplicates.
                countChecker.Add(nums[0], 1); // Add first element to countChecker

                while (right < nums.Length) // Iterate through the array
                {
                    if (nums[right] == nums[right - 1]) // If current number is same as previous number
                    {
                        if (countChecker[nums[right]] < 2) // checking this as we can take 2 copies of the same value
                        {
                            nums[left] = nums[right]; // Replace the value at the left index with the unique element.
                            left++; // Increment the left pointer to point to the next position for a unique value.
                        }
                        countChecker[nums[right]]++; // Increment count of current number
                        right++; // skip to the next element.
                    }
                    else // If current number is different from previous number
                    {
                        countChecker.Add(nums[right], 1); // Add current number to countChecker with count 1
                        nums[left] = nums[right]; // Replace the value at the left index with the unique element.
                        left++; // Increment the left pointer to point to the next position for a unique value.
                        right++; // skip to the next element.
                    }
                }

                return left;
            }
        }

    }
}
