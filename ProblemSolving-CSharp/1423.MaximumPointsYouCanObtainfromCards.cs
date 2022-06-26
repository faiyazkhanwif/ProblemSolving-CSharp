using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _1423
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            int notInUseSubArrLen = cardPoints.Length - k;

            int highestSum = int.MinValue;

            Dictionary<int, int> cardSums = new Dictionary<int, int>();

            int totalCardSum = 0;

            for (int i = 0; i < cardPoints.Length; i++)
            {
                totalCardSum += cardPoints[i];
                cardSums.Add(i, totalCardSum);
            }

            if (k == cardPoints.Length)
            {
                highestSum = totalCardSum;
            }

            int startInd = 0;
            int endInd = notInUseSubArrLen - 1;

            while (endInd >= 0 && endInd < cardPoints.Length)
            {
                int notInUseSubArrSum = cardSums[endInd];

                if (startInd > 0)
                {
                    notInUseSubArrSum = notInUseSubArrSum - cardSums[startInd - 1];
                }

                int cardSum = totalCardSum - notInUseSubArrSum;
                if (cardSum > highestSum)
                {
                    highestSum = cardSum;
                }

                startInd++;
                endInd++;
            }
            return highestSum;
        }
    }
}
