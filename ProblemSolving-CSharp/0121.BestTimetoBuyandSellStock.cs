using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0121
    {
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
    }
}
