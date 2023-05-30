using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0088
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int pnum1 = m - 1;
            int pnum2 = n - 1;

            int index = nums1.Length - 1;

            while (pnum1 > -1 && pnum2 > -1)
            {
                if (nums1[pnum1] < nums2[pnum2])
                {
                    nums1[index] = nums2[pnum2];
                    Console.WriteLine(nums1[index]);
                    pnum2--;
                }
                else
                {
                    nums1[index] = nums1[pnum1];
                    Console.WriteLine(nums1[index]);
                    pnum1--;
                }

                index--;
            }

            if (index > -1)
            {
                //Console.WriteLine("LeftOut");
                while (pnum1 > -1)
                {
                    nums1[index] = nums1[pnum1];
                    Console.WriteLine(nums1[index]);
                    pnum1--;
                    index--;
                }
                while (pnum2 > -1)
                {
                    nums1[index] = nums2[pnum2];
                    Console.WriteLine(nums1[index]);
                    pnum2--;
                    index--;
                }
            }
        }
    }
}
