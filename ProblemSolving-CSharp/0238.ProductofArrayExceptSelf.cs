using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0238
    {
        //O(n^2)
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int product = 1;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    product = product * nums[j];
                }

                result[i] = product;
            }

            return result;
        }


        //O(n) with extra space
        public int[] ProductExceptSelfOpti(int[] nums)
        {
            int[] result = new int[nums.Length];
            int[] leftProduct = new int[nums.Length];
            int[] rightProduct = new int[nums.Length];

            leftProduct[0] = 1;
            rightProduct[rightProduct.Length - 1] = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 == leftProduct.Length)
                {
                    break;
                }
                leftProduct[i + 1] = nums[i] * leftProduct[i];
            }

            for (int i = nums.Length-1; i >=0; i--)
            {
                if (i-1 < 0)
                {
                    break;
                }

                rightProduct[i-1] = nums[i] * rightProduct[i];
            }

            for (int i = 0; i < leftProduct.Length; i++)
            {
                result[i] = leftProduct[i] * rightProduct[i];
            }

            return result;
        }


        //O(n) without extra space
        public int[] ProductExceptSelfMostOpti(int[] nums)
        {
            int[] result = new int[nums.Length];

            result[0] = 1; 

            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 == result.Length)
                {
                    break;
                }
                result[i + 1] = nums[i] * result[i];
            }

            int rightProduct = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i - 1 < 0)
                {
                    break;
                }
                result[i] = result[i] * rightProduct;

                rightProduct = nums[i] * rightProduct;
            } 

            return result;
        }
    }
}
