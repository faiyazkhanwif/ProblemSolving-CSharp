using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _1679
    {
        //Works but unoptimized, 44 test cases out of 51
        public int MaxOperations(int[] nums, int k)
        {
            int[] diffArr = new int[nums.Length];
            HashSet<int> indexStorage = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = k - nums[i];
                diffArr[i] = diff;
            }

            int removeCount = 0;
            int operationCount = 0;

            for (int i = 0; i < diffArr.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (diffArr[i] == nums[j] && i != j && !indexStorage.Contains(i) && !indexStorage.Contains(j))
                    {
                        //Console.WriteLine("i - " + i);
                        //Console.WriteLine("j - " + j);
                        nums[i] = '-';
                        nums[j] = '-';
                        indexStorage.Add(i);
                        indexStorage.Add(j);
                        removeCount += 2;
                        operationCount++;
                        break;
                    }
                }
                if (removeCount == nums.Length)
                {
                    break;
                }
            }
            return operationCount;
        }

        //Optimized
        public int MaxOperationsOptimized(int[] nums, int k)
        {
            Dictionary<int, int> valueOcc = new Dictionary<int, int>();
            int operations = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = k - nums[i];
                if (valueOcc.ContainsKey(diff))
                {
                    int occ = valueOcc[diff];
                    if (occ > 1)
                    {
                        valueOcc[diff] = occ-1;
                    }
                    else
                    {
                        valueOcc.Remove(diff);
                    }
                    operations++;
                }
                else
                {
                    if (valueOcc.ContainsKey(nums[i]))
                    {
                        int val = valueOcc[nums[i]];
                        valueOcc[nums[i]] = val+1;
                    }
                    else
                    {
                        valueOcc[nums[i]] = 1;
                    }
                }
            }
            return operations;
        }
    }
}
