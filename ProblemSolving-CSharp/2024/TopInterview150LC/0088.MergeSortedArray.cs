using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0088
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int endPointer = nums1.Length - 1;
            int p1 = m - 1;
            int p2 = n - 1;

            while (p1 >= 0 && p2 >= 0 && endPointer >= 0)
            {
                //Move larger element to the endPointer position
                if (nums1[p1] < nums2[p2])
                {
                    nums1[endPointer] = nums2[p2];
                    p2--;
                }
                else
                {
                    nums1[endPointer] = nums1[p1];
                    p1--;
                }
                endPointer--;
            }

            if (endPointer >= 0)
            {
                //Store remaining elements
                while (p1 >= 0)
                {
                    nums1[endPointer] = nums1[p1];
                    p1--;
                    endPointer--;
                }

                while (p2 >= 0)
                {
                    nums1[endPointer] = nums2[p2];
                    p2--;
                    endPointer--;
                }
            }
        }
    }
}
