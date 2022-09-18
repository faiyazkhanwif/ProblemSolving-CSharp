using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0053
    {
        //O(n^3) finding out all possible subarrays - passes 200 / 209

        public int MaxSubArray(int[] nums)
        {
            int maxSize = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    int tempSize = 0;

                    for (int k = i; k <= j; k++)
                    {
                        tempSize+=nums[k];
                    }

                    if (tempSize>maxSize)
                    {
                        maxSize = tempSize;
                    }
                }
            }

            return maxSize;

        }
    }
}
