using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _1818
    {
        //Passes 36/51
        public int MinAbsoluteSumDiff(int[] nums1, int[] nums2)
        {
            int MOD = (int)(1E9) + 7;
            int[] diffArr = new int[nums1.Length];
            int[] bestDiffArr = new int[nums1.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                diffArr[i] = Math.Abs(nums1[i] - nums2[i]);
            }

            if (diffArr.Sum() == 0)
            {
                return 0;
            }

            Array.Sort(nums1);
            for (int i = 0; i < nums2.Length; i++)
            {
                bestDiffArr[i] = Math.Abs(binarySearchToFindClosestToNums2Val(nums1, nums2[i]) - nums2[i]);
                Console.WriteLine("bestDiffArr[i]: " + bestDiffArr[i]);
            }

            int maxSaved = int.MinValue;
            //int maxSavedInd = -1;
            for (int i = 0; i < bestDiffArr.Length; i++)
            {
                int saved = diffArr[i] - bestDiffArr[i];
                if (maxSaved < saved)
                {
                    maxSaved = saved;
                    //maxSavedInd = i;
                }
            }

            return (diffArr.Sum() - maxSaved) % MOD;
        }

        public int binarySearchToFindClosestToNums2Val(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int closestVal = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target)
                {
                    return arr[mid];
                }
                else if (arr[mid] < target)
                {
                    closestVal = arr[mid];
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return closestVal;
        }
    }
}
