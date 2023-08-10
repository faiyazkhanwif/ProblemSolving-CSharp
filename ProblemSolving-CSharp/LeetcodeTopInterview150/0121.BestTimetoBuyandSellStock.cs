using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0121
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            int buyingDayIndex = 0;
            int sellingDayIndex = 1;

            while (buyingDayIndex<sellingDayIndex && buyingDayIndex<prices.Length)
            {
                if (sellingDayIndex >= prices.Length)
                {
                    return maxProfit;
                }

                if (prices[buyingDayIndex] > prices[sellingDayIndex])
                {
                    buyingDayIndex = sellingDayIndex;
                }
                else
                {
                    int profit = prices[sellingDayIndex] - prices[buyingDayIndex];

                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }

                } 

                sellingDayIndex++;
            }

            return maxProfit;
        }
    }
}
