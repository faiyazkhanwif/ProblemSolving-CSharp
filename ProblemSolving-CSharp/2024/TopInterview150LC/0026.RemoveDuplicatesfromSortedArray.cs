﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length; // If the array has only 1 or 0 elements, there are no duplicates to remove.
            }

            int left = 1; // Left pointer which tracks the index for the next unique value, also counts the number of unique values.
            int right = 1; // Right pointer which iterates through the array to find duplicates.

            while (right < nums.Length)
            {
                if (nums[right] == nums[right - 1])
                {
                    // Duplicate found, skip to the next element.
                    right++;
                }
                else
                {
                    // Unique element found.
                    nums[left] = nums[right]; // Replace the value at the left index with the unique element.
                    left++; // Increment the left pointer to point to the next position for a unique value.
                    right++; // Move the right pointer to the next element.
                }
            }

            return left;
        }
    }
}
