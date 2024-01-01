using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0027
    {
        public int RemoveElement(int[] nums, int val)
        {
            // Initialize two pointers: startPointer at the beginning and endPointer at the end of the array.
            int startPointer = 0;
            int endPointer = nums.Length - 1;

            // Initialize variable k to keep track of the count of elements not equal to val.
            int k = 0;

            // Iterate through the array until startPointer crosses or meets endPointer.
            while (startPointer <= endPointer)
            {
                // Check if the element at startPointer is equal to val.
                if (nums[startPointer] == val)
                {
                    // Swap the element at startPointer with the element at endPointer.
                    int valueToBeShifted = nums[startPointer];
                    nums[startPointer] = nums[endPointer];
                    nums[endPointer] = valueToBeShifted;

                    // Moving endPointer one step to the left to ignore the swapped element (equal to val).
                    endPointer--;
                }
                else
                {
                    // If the element at startPointer is not equal to val, we move to the next element and increment k.
                    startPointer++;
                    k++;
                }
            }

            // The first k elements of nums now contain elements not equal to val.

            // Return the count of elements not equal to val.
            return k;
        }
    }
}
