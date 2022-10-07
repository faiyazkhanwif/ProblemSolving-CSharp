using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0503
    {

        //O(n^2)
        public int[] NextGreaterElements(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int ind = i + 1;
                bool found = false;

                while (ind != i)
                {
                    if (ind == nums.Length)
                    {
                        ind = 0;
                        continue;
                    }

                    if (nums[ind] > nums[i])
                    {
                        result[i] = nums[ind];
                        found = true;
                        break;
                    }

                    ind++;
                }
                if (!found)
                {
                    result[i] = -1;
                }
            }

            return result;

        }

        //O(n)
        public int[] NextGreaterElementsOpti(int[] nums)
        {
            int[] result = new int[nums.Length];
            Stack<int> stack = new Stack<int>();

            stack.Push(0);

            for (int i = 1; i < nums.Length; i++)
            {
                while (stack.Count != 0 && nums[stack.Peek()] < nums[i])
                {
                    result[stack.Pop()] = nums[i];
                }

                stack.Push(i);
            }

            //2nd loop for checking greater element as this is a circular array.
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count != 0 && nums[stack.Peek()] < nums[i])
                {
                    result[stack.Pop()] = nums[i];
                }
            }

            //Storing -1 for elements that have no greater elements
            while (stack.Count != 0)
            {
                result[stack.Pop()] = -1;
            }


            return result;

        }
    }
}
