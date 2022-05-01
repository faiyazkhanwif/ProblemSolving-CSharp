using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> storage = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (storage.ContainsKey(nums[i]))
                {
                    int index;
                    storage.TryGetValue(nums[i], out index);
                    if (index != i)
                    {
                        result[0] = i;
                        result[1] = index;
                        break;
                    }
                }
                else
                {
                    int diff = target - nums[i];
                    if (!storage.ContainsKey(diff))
                    {
                        storage.Add(diff, i);
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
