using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0905
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int i = 0;
            int j =  nums.Length - 1;

            while (i < j)
            {
                if (nums[i] % 2!=0)
                {
                    int temp = nums[i];
                    if (nums[j]%2==0)
                    {
                        nums[i] = nums[j];
                        nums[j] = temp;
                        j--;
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }
                else
                {
                    i++;
                }
            }
            return nums;
        }
    }
}
