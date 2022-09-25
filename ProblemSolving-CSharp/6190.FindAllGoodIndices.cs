using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6190
    {
        //Bruteforce - passes 64 / 66 test cases.
        public IList<int> GoodIndices(int[] nums, int k)
        {
            IList<int> result = new List<int>();

            int i = k;

            while (i < (nums.Length - k))
            {
                bool increasingRight = true;
                bool increasingLeft = true;
                int indR = i + 1;
                int maxL = int.MinValue;
                int maxR = int.MinValue;
                int indL = i - 1;

                //Traversing from left to right
                for (int j = 0; j < k; j++)
                {
                    if (nums[indL] < maxL)
                    {
                        increasingLeft = false;
                        break;
                    }
                    else
                    {
                        maxL = nums[indL];
                    }
                    indL--;
                }
                //Traversing from right to left
                for (int j = 0; j < k; j++)
                {
                    if (nums[indR] < maxR)
                    {
                        increasingRight = false;
                        break;
                    }
                    else
                    {
                        maxR = nums[indR];
                    }
                    indR++;
                }

                if (increasingRight && increasingLeft)
                {
                    result.Add(i);
                }

                i++;
            }

            return result;
        }
    }
}
