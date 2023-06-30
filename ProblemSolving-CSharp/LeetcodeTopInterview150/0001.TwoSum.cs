using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int index = 0;

            foreach (int num in nums)
            {
                int val = target - num;
                if (dic.ContainsKey(val))
                {
                    return new int[] { index, dic[val] };
                }
                else
                {
                    if (!dic.ContainsKey(num))
                    { 
                        dic.Add(num, index);
                    }
                }
                index++;
            }

            return new int[] {};
        }
    }
}
