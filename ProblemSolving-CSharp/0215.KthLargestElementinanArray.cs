using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0215
    {

        int[] QuickSort(int[] list)
        {
            // base case: if the list has zero or one elements, it is already sorted
            if (list.Length <= 1)
            {
                return list;
            }

            // choose the pivot (we'll choose the first element)
            int pivot = list[0];

            // create two lists: smaller and larger
            List<int> smaller = new List<int>();
            List<int> larger = new List<int>();

            // iterate over the list, comparing each element to the pivot
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] < pivot)
                {
                    // if the element is smaller than the pivot, add it to the smaller list
                    smaller.Add(list[i]);
                }
                else
                {
                    // if the element is larger than the pivot, add it to the larger list
                    larger.Add(list[i]);
                }
            }

            // sort the smaller and larger lists using quick sort
            smaller = QuickSort(smaller.ToArray()).ToList();
            larger = QuickSort(larger.ToArray()).ToList();

            // return the sorted list by concatenating the sorted smaller list, the pivot, and the sorted larger list
            return smaller.Concat(new int[] { pivot }).Concat(larger).ToArray();
        }



        public int FindKthLargest(int[] nums, int k)
        {
            //Array.Sort(nums); Easy solution
            nums = QuickSort(nums);

            return nums[nums.Length - k];

        }
    }
}
