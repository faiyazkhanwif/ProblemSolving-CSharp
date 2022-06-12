using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _1351
    {
        public int CountNegatives(int[][] grid)
        {
            int m = grid.Length;
            int count = 0;

            for (int i = 0; i < m; i++)
            {
                int tempN = grid[i].Length - 1;
                while (tempN >= 0 && grid[i][tempN] < 0)
                {
                    //Console.WriteLine("Val: "+grid[i][tempN]);
                    count++;
                    tempN--;
                }

            }

            return count;
        }
    }
}
