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
            int buyingDay = 0;
            int sellingDay = 1;

            while (sellingDay < prices.Length)
            {
                if (prices[buyingDay] > prices[sellingDay])
                {
                    buyingDay++;
                    sellingDay=buyingDay+1;
                }
                else
                { 
                    int profit = prices[sellingDay] - prices[buyingDay];
                    if (profit>maxProfit)
                    {
                        maxProfit = profit;
                    }
                    sellingDay++;
                }
            }
            return maxProfit;
        }
    }
}
