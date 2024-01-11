using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0122
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyingIndex = 0;

            int sellingIndex = 1;

            while (buyingIndex < prices.Length && sellingIndex < prices.Length)
            {
                if (prices[buyingIndex] > prices[sellingIndex])
                {
                    buyingIndex = sellingIndex;
                }
                else
                {
                    int profit = prices[sellingIndex] - prices[buyingIndex];
                    maxProfit += profit;

                    buyingIndex = sellingIndex + 1;
                }
                sellingIndex++;
            }

            return maxProfit;
        }
    }
}
