using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6193
    {
        public int MaxSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            if (m < 3 || n < 3)
            {
                return 0;
            }

            int maxSum = int.MinValue;

            for (int i = 0; i < m - 2; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    int sum = (grid[i][j] + grid[i][j + 1] + grid[i][j + 2])
                                + (grid[i + 1][j + 1])
                                + (grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2]);
                    maxSum = Math.Max(maxSum, sum);
                }
            }

            return maxSum;
        }
    }
}
