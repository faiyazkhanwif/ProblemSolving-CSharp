using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0268
    {
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != nums[i])
                {
                    return i;
                }
            }
            return nums.Length;
        }

        public int MissingNumberALT(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i <= nums.Length; i++)
            {
                sum += i;
            }
            return sum - nums.Sum();
        }
    }
}

