using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _2210
    {
        public int CountHillValley(int[] nums)
        {
            int cnt = 0;
            int i = 0;
            while (i < nums.Length)
            {
                if (i > 0 && i < nums.Length - 1)
                {
                    if (nums[i - 1] < nums[i] && nums[i] > nums[i + 1])
                    {
                        cnt++;
                        i++;
                        continue;
                    }
                    if (nums[i - 1] > nums[i] && nums[i] < nums[i + 1])
                    {
                        cnt++;
                        i++;
                        continue;
                    }
                    if (nums[i - 1] == nums[i])
                    {
                        int ind = i;
                        while (ind < nums.Length - 1 && nums[ind] == nums[i - 1])
                        {
                            ind++;
                        }
                        if (i - 2 >= 0 && nums[i - 2] < nums[i] && nums[i] > nums[ind])
                        {
                            cnt++;
                            i = ind;
                            continue;
                        }
                        if (i - 2 >= 0 && nums[i - 2] > nums[i] && nums[i] < nums[ind])
                        {
                            cnt++;
                            i = ind;
                            continue;
                        }
                    }

                    i++;
                    continue;

                }

                i++;

            }
            return cnt;

        }
    }
}
