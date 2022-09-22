using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0070
    {
        //O(2*n) Recursion - Passes 21 / 45
        public int ClimbStairs(int n)
        {
            return climb(n);

            int climb(int stepsLeft)
            {
                if (stepsLeft < 0)
                {
                    return 0;
                }

                if (stepsLeft == 0)
                {
                    return 1;
                }

                return climb(stepsLeft - 1) + climb(stepsLeft - 2);

            }
        }

        //O(n) Top down DP with Memoization
        public int ClimbStairsDP(int n)
        {
            Dictionary<int, int> dpCache = new Dictionary<int, int>();
            return climb(n);

            int climb(int stepsLeft)
            {
                if (dpCache.ContainsKey(stepsLeft))
                {
                    return dpCache[stepsLeft];
                }
                else
                {
                    if (stepsLeft < 0)
                    {
                        return 0;
                    }

                    if (stepsLeft == 0)
                    {
                        return 1;
                    }

                    dpCache[stepsLeft] = climb(stepsLeft - 1) + climb(stepsLeft - 2);

                    return dpCache[stepsLeft];

                }
            }
        }

        //O(n) Bottom up DP
        public int ClimbStairsDPBT(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            return climb(n);

            int climb(int stepsLeft)
            {
                for (int i = 2; i <= n; i++)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }
                return dp[stepsLeft];
            }
        }
    }
}

