using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0004
    {
        //Brute force - Accepted; Have to do Binary search.
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int[] combined = nums1.Concat(nums2).ToArray();
            int length = combined.Length;
            Array.Sort(combined);

            if (length % 2 != 0)
            {
                //Odd length  
                return (combined[length / 2]);


            }
            else
            {
                //Even length 
                double val1 = combined[length / 2];
                double val2 = combined[(length / 2) - 1];

                Console.WriteLine("1: - " + val1);
                Console.WriteLine("2: - " + val1);
                Console.WriteLine(val1 + val2);
                return (double)(val1 + val2) / 2;

            }
        }
    }
}

