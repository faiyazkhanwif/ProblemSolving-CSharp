using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6190
    {
        public IList<int> GoodIndices(int[] nums, int k)
        {
            IList<int> result = new List<int>();

            int i = k;

            while (i < (nums.Length - k))
            {
                Console.WriteLine("i: "+i);
                bool increasingRight = true;
                bool increasingLeft = true;
                int indR = i + 1;
                int indL = i - 1;

                while (indL-1>=0)
                {
                    if (nums[indL - 1] < nums[indL])
                    {
                        Console.WriteLine("NOTL");
                        increasingLeft = false;
                        break;
                    }
                    indL--;
                }

                while (indR+1<nums.Length)
                {
                    if (increasingLeft == false)
                    {
                        break;
                    }
                    if (nums[indR] > nums[indR+1])
                    {
                        Console.WriteLine("NOTR");
                        increasingRight = false;
                        break;
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
