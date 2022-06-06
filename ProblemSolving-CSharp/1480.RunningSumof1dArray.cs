using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _1480
    {
        public int[] RunningSum(int[] nums)
        {
            
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i]+sum;
                sum = nums[i];
            }
            return nums;

        }
    }
}
