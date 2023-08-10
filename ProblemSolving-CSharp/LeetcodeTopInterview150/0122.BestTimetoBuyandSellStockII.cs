using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0122
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            int buyingIndex = 0;
            int sellingIndex = 1;

            while (buyingIndex < sellingIndex && sellingIndex < prices.Length)
            {
                if (prices[buyingIndex] < prices[sellingIndex])
                {
                    maxProfit += prices[sellingIndex] - prices[buyingIndex];
                    buyingIndex++;
                    sellingIndex++;
                }
                else
                {
                    buyingIndex = sellingIndex;
                    sellingIndex++;
                }

            }

            return maxProfit;
        }
    }
}
