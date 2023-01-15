using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0011
    {
        //O(n)
        public int MaxArea(int[] height)
        {
            int startInd = 0;
            int endInd = height.Length - 1;
            int maxArea = 0;


            while(startInd < endInd)
            {
                int m = Math.Min(height[startInd], height[endInd]);
                int n = endInd - startInd;

                if (m*n>maxArea)
                {
                    maxArea = m * n;
                }

                if (height[startInd] < height[endInd])
                {
                    startInd++;
                }
                else
                {
                    endInd--;
                }
            }
            return maxArea;
        }
    }
}
