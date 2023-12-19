using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0055_
    {
        public bool CanJump(int[] nums)
        {
            int goalIndex = nums.Length - 1;

            int currIndex = goalIndex - 1;

            while (currIndex >= -1)
            {
                if (goalIndex == 0)
                {
                    return true;
                }
                if (currIndex == -1)
                {
                    return false;
                }
                if (currIndex + nums[currIndex] >= goalIndex)
                {
                    //Console.WriteLine($"Goal- {currIndex} - {goalIndex}");
                    if (currIndex == 0)
                    {
                        return true;
                    }
                    goalIndex = currIndex;
                    currIndex--;
                }
                else
                {
                    currIndex--;
                }
            }

            return false;
        }
    }
}
