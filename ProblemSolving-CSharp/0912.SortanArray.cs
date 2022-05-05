using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0912
    {
        //merge sort
        public int[] SortArray(int[] nums)
        {
            int length = nums.Length;
            if (length <= 1)
            {
                return nums;
            }

            int mid = length / 2;
            int[] left = new int[mid];
            int[] right = new int[length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = nums[i];
            }

            int righti = 0;
            for (int i = mid; i < length; i++)
            {
                right[righti] = nums[i];
                righti++;
            }

            left = SortArray(left);
            right = SortArray(right);

            return merge(left, right);
        }

        public int[] merge(int[] left, int[] right)
        {
            int lLength = left.Length;
            int rLength = right.Length;

            int[] merged = new int[lLength + rLength];

            int leftPointer = 0;
            int rightPointer = 0;

            int ind = 0;

            while (leftPointer < lLength && rightPointer < rLength)
            {
                if (left[leftPointer] <= right[rightPointer])
                {
                    merged[ind] = left[leftPointer];
                    leftPointer++;
                }
                else
                {
                    merged[ind] = right[rightPointer];
                    rightPointer++;
                }

                ind++;
            }

            while (leftPointer < lLength)
            {
                merged[ind] = left[leftPointer];
                ind++;
                leftPointer++;
            }

            while (rightPointer < rLength)
            {
                merged[ind] = right[rightPointer];
                ind++;
                rightPointer++;
            }

            return merged;
        }
    }
}
