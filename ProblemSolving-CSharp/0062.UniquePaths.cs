using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0062
    {
        //O(2^n) Recursion, passes 41 / 63 test cases.
        public int UniquePaths(int m, int n)
        {
            return go(m - 1, n - 1); //bottom-right corner (i.e., grid[m - 1][n - 1]).

            int go(int m, int n)
            {
                if (m == 0 || n == 0) //If any one of the indices is zero, that means we have only one way to that path; so we return 1;
                {
                    return 1;
                }

                return go(m, n - 1) + go(m - 1, n);
            }
        }

        //O(n) DP Top down with Memoization
        public int UniquePathsDPTD(int m, int n)
        {
            Dictionary<string, int> dpCache = new Dictionary<string, int>();
            return go(m - 1, n - 1); //bottom-right corner (i.e., grid[m - 1][n - 1]).

            int go(int m, int n)
            {
                if (dpCache.ContainsKey(m.ToString() + ", " + n.ToString()))
                {
                    return dpCache[m.ToString() + ", " + n.ToString()];
                }
                else
                {
                    if (m == 0 || n == 0) //If any one of the indices is zero, that means we have only one way to that path; so we return 1;
                    {
                        return 1;
                    }
                    dpCache[m.ToString() + ", " + n.ToString()] = go(m, n - 1) + go(m - 1, n);
                    return dpCache[m.ToString() + ", " + n.ToString()];
                }
            }
        }

        //O(n) DP Bottom Up
        public int UniquePathsDPBU(int m, int n)
        {
            int[,] dpArr = new int[m, n];
            dpArr[0, 0] = 1;

            for (int i = 0; i <= m - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    if (i == 0 || j == 0) //If any one of the indices is zero, that means we have only one way to that path; so we store 1;
                    {
                        dpArr[i, j] = 1;
                    }
                    else
                    { 
                        dpArr[i, j] = dpArr[i, j - 1] + dpArr[i - 1, j];
                    }
                }
            }
            return dpArr[m - 1, n - 1];
        }
    }
}
