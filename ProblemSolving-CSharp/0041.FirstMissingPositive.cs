using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0041
    {
        //O(n) time and O(n) space
        public int FirstMissingPositive(int[] nums)
        {
            HashSet<int> values = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                values.Add(nums[i]);
            }

            int possibleMissingPositive = 1;

            while (values.Contains(possibleMissingPositive))
            {
                possibleMissingPositive++;
            }

            return possibleMissingPositive;

        }
    }
}
