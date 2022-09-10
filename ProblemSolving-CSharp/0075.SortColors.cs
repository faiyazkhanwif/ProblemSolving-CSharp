using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0075
    {
        public void SortColors(int[] nums)
        {
            int max = 2;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = dic[nums[i]] + 1;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            int ind = 0;

            for (int i = 0; i <= max; i++)
            {
                if (dic.ContainsKey(i))
                {
                    int count = dic[i];
                    for (int p = 0; p < count; p++)
                    {
                        nums[ind] = i;
                        ind++;
                    }

                }
            }
        }

    }
}
