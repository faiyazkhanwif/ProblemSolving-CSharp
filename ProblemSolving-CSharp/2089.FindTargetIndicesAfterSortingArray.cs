using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _2089
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            List<int> result = new List<int>();
            Array.Sort(nums);

            //for (int q = 0; q < nums.Length; q++)
            //{
            //    Console.Write(nums[q] + " ");
            //}
            //Console.WriteLine();

            int i = 0;
            int j = nums.Length - 1;
            bool found = false;
            int matchedInd = -1;

            while (i <= j)
            {
                int mid = i + (j - i) / 2;

                //Console.WriteLine("mid: " + mid);
                //Console.WriteLine("i: " + i);
                //Console.WriteLine("j: " + j);
                //Console.WriteLine(nums[mid]);
                if (nums[mid] != target)
                {
                    if (nums[mid] < target)
                    {
                        i = mid + 1;
                    }
                    else
                    {
                        j = mid - 1;
                    }
                }
                else
                {
                    matchedInd = mid;
                    result.Add(matchedInd);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return result;
            }

            bool existsInBack = true;
            int tempindB = matchedInd - 1;
            while (existsInBack)
            {
                if (tempindB < 0)
                {
                    existsInBack = false;
                    break;
                }
                if (nums[tempindB] == target)
                {
                    result.Add(tempindB);
                    tempindB--;
                }
                else
                {
                    existsInBack = false;
                }
            }

            bool existsInFront = true;
            int tempindF = matchedInd + 1;

            while (existsInFront)
            {
                if (tempindF >= nums.Length)
                {
                    existsInFront = false;
                    break;
                }
                if (nums[tempindF] == target)
                {
                    result.Add(tempindF);
                    tempindF++;
                }
                else
                {
                    existsInFront = false;
                    break;
                }
            }

            result.Sort();
            return result;
        }
    }
}
