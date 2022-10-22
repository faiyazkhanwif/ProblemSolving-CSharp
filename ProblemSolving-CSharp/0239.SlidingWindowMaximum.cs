using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0239
    {
        //TLE - Brute Force
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] result = new int[nums.Length - k + 1];
            int resultInd = 0;
            int max = int.MinValue;

            Queue<int> window = new Queue<int>();

            //Creating first window
            for (int i = 0; i <= k - 1; i++)
            {
                window.Enqueue(nums[i]);
            }

            max = window.Max();
            result[0] = max;
            resultInd++;

            if (nums.Length == k - 1)
            {
                return result;
            }

            for (int i = k; i < nums.Length; i++)
            {
                window.Enqueue(nums[i]);
                window.Dequeue();

                if (nums[i] > max)
                {
                    max = nums[i];
                }
                else
                {
                    max = window.Max();
                }
                result[resultInd] = max;
                resultInd++;
            }

            return result;
        }

        //O(n) - LinkedList (Deque)
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] result = new int[nums.Length - k + 1];
            int resultInd = 0;

            LinkedList<int> window = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (window.Count != 0 && i >= k && window.First() <= i - k)
                {
                    window.RemoveFirst();
                }

                while (window.Count != 0 && nums[window.Last()] <= nums[i])
                {
                    window.RemoveLast();
                }
                window.AddLast(i);
                if (i >= k - 1)
                {
                    result[resultInd] = nums[window.First()];
                    resultInd++;
                }
            }

            return result;
        }
    }
}
