using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0462
    {
        public int MinMoves2(int[] nums)
        {
            int moves = 0;

            Array.Sort(nums);
            int median = nums[nums.Length / 2];

            foreach (int num in nums)
            {
                moves += Math.Abs(median - num);
            }
            return moves;
        }
    }
}
