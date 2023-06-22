using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0189
    {
        public void Rotate(int[] nums, int k)
        {
            Dictionary<int, int> indexesWithValuesAfterRotation = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int index = i - k; //Index of value that will come to 'i'th place after rotation.

                // If the index is negative, that means there has been a cycle.
                // loop is used because multiple cycles may occure.
                while (index < 0)
                {
                    // Adjust the negative index to wrap around to the end of the array
                    index = nums.Length + index;
                }

                //store 'i' with the value that will come to 'i' after rotations.
                indexesWithValuesAfterRotation.Add(i, nums[index]);
            }

            // Update the original array with the values from the dictionary
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = indexesWithValuesAfterRotation[i];
            }
        }
    }
}
