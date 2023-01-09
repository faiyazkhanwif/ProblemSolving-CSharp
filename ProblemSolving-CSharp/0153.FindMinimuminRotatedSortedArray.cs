using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0153
    {
        public int FindMin(int[] nums)
        {
            if (nums[nums.Length - 1] > nums[0])
            {
                return nums[0];
            }

            int startInd = 0;
            int EndInd = nums.Length - 1;

            while (startInd < EndInd)
            {
                int midInd = startInd + (EndInd - startInd) / 2;
                if (nums[midInd] < nums[nums.Length - 1])
                {
                    EndInd = midInd;
                }
                else
                {
                    startInd = midInd + 1;
                }
            }
            return nums[startInd];
        }

    }
}
