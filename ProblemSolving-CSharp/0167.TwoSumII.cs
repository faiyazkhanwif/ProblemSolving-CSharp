using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] res = new int[2];
            int p = 0;
            int q = numbers.Length - 1;

            while (p < q)
            {
                int sum = numbers[p]+numbers[q];
                if (sum>target)
                {
                    q--;
                }else if (sum < target)
                {
                    p++;
                }
                else
                {
                    res[0] = p+1;
                    res[1] = q+1;
                    break;
                }
            }
            return res;
        }
    }
}
