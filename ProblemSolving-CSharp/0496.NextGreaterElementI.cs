using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0496
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] res = new int[nums1.Length];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                dict.Add(nums1[i], i);
            }

            stack.Push(0);

            for (int i = 1; i < nums2.Length; i++)
            { 
                while (stack.Count!=0 && nums2[stack.Peek()]<nums2[i])
                {
                    if (dict.ContainsKey(nums2[stack.Peek()]))
                    {
                        res[dict[nums2[stack.Pop()]]] = nums2[i];
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

                if (dict.ContainsKey(nums2[i]))
                {
                    stack.Push(i);
                }
            }

            while (stack.Count != 0)
            {
                if (dict.ContainsKey(nums2[stack.Peek()]))
                {
                    res[dict[nums2[stack.Pop()]]] = -1;
                }
                else
                {
                    stack.Pop();
                }
            }

            return res;
        }
    }
}
