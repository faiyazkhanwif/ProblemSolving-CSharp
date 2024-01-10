using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0121
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            if (prices.Length == 0)
            {
                return maxProfit;
            }

            int lowestPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (lowestPrice > prices[i])
                {
                    lowestPrice = prices[i];
                }
                else
                {
                    int profit = prices[i] - lowestPrice;
                    if (maxProfit < profit)
                    {
                        maxProfit = profit;
                    }
                }
                //Console.WriteLine(maxProfit);
            }

            return maxProfit;
        }
    }
}
