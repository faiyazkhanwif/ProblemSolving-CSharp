using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0456
    {
        //Unoptimized, passes 94/102
        public bool Find132pattern(int[] nums)
        {
            int len = nums.Length;
            if (len < 3)
            {
                return false;
            }

            for (int i = 0; i < len; i++)
            {
                int one = nums[i];

                for (int j = i + 1; j < len; j++)
                {
                    int three = nums[j];

                    for (int k = j + 1; k < len; k++)
                    {

                        int two = nums[k];

                        if (one < three && three > two && one < two)
                        {
                            return true;
                        }
                    }
                }

            }

            return false;
        }

        //Optimized, passes all test cases

        public bool Find132patternOpti(int[] nums)
        {
            Stack<int> myStack = new Stack<int>();

            int len = nums.Length;

            if (len < 3)
            {
                return false;
            }

            int two = int.MinValue;
            for (int i = len - 1; i >= 0; i--)
            {
                //Console.WriteLine("Checking: "+nums[i]);
                if (myStack.Count == 0)
                {
                    myStack.Push(nums[i]);
                }
                else
                {

                    if (myStack.Peek() > nums[i])
                    {
                        if (nums[i] < two)
                        {
                            return true;
                        }
                        myStack.Push(nums[i]);

                    }
                    else if (nums[i] > myStack.Peek())
                    {
                        while (myStack.Count != 0 && nums[i] > myStack.Peek())
                        {
                            int temp = myStack.Pop();

                            if (temp > two)
                            {
                                two = temp;
                            }
                        }

                        myStack.Push(nums[i]);

                    }
                }

            }
            return false;
        }
    }
}
