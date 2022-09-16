using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _1944
    {
        //O(n^2) Passes 40/42
        public int[] CanSeePersonsCount(int[] heights)
        {
            for (int i = 0; i < heights.Length; i++)
            {
                int maxHeightInFront = int.MinValue;
                int visibleCount = 0;
                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (maxHeightInFront < heights[j])
                    {
                        maxHeightInFront = heights[j];
                        visibleCount++;
                    }
                    if (maxHeightInFront > heights[i])
                    {
                        break;
                    }
                }
                heights[i] = visibleCount;
            }
            return heights;
        }

        //O(n) passes all
        public int[] CanSeePersonsCountOpti(int[] heights)
        {
            int[] ans = new int[heights.Length];

            Stack<int> heightsStack = new Stack<int>();
            heightsStack.Push(heights[heights.Length-1]);
            ans[ans.Length - 1] = 0;

            for (int i = heights.Length-2; i >=0; i--)
            { 
                int visibleCount = 0;
                while (heightsStack.Count!=0)
                {
                    visibleCount++;
                    if (heights[i]>heightsStack.Peek())
                    {
                        heightsStack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
                ans[i] = visibleCount;
                heightsStack.Push(heights[i]);
            }
            return ans;
        }
    }
}
