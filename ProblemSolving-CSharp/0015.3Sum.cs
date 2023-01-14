using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0015
    {
        //o(n^2)
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i + 2 < nums.Length; i++)
            {
                if (nums[i] > 0) break; // as the array is sorted, if the num is larger than 0, then a result can't be found
                if (i > 0 && nums[i] == nums[i - 1]) continue; // skip duplicates

                int target = 0 - nums[i], left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[left] + nums[right] == target)
                    {
                        list.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; // duplicates from left side
                        while (left < right && nums[right] == nums[right - 1]) right--; // duplicates from right side
                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return list;
        }
    }
}
