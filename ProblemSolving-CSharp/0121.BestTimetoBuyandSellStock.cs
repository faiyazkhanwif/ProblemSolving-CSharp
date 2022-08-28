using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0121
    {
        //O(n)^2
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] < prices[j])
                    {
                        int profit = prices[j] - prices[i];
                        if (profit > maxProfit)
                        {
                            maxProfit = profit;
                        }
                    }
                }
            }
            return maxProfit;
        }

        //O(n)
        public int MaxProfitOpt(int[] prices)
        {
            int maxProfit = 0;
            int currStock = int.MinValue;

            for (int i = prices.Length - 1; i >= 0; i--)
            {
                if (prices[i] > currStock)
                {
                    currStock = prices[i];
                }
                else if (prices[i] < currStock)
                {
                    int profit = currStock - prices[i];

                    if (maxProfit < profit)
                    {
                        maxProfit = profit;
                    }
                }


            }

            return maxProfit;
        }
    }
}
