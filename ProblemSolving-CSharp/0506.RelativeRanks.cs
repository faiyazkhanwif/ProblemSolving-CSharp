using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0506
    {
        public string[] FindRelativeRanks(int[] score)
        {
            int[] scoreSorted = new int[score.Length];
            string[] ans = new string[score.Length];
            score.CopyTo(scoreSorted, 0);

            Array.Sort(scoreSorted);
            Array.Reverse(scoreSorted);
            Dictionary<int, string> scoreMap = new Dictionary<int, string>();

            for (int i = 0; i < scoreSorted.Length; i++)
            { 
                string val = "";
                if (i==0)
                {
                    val = "Gold Medal";
                }else if (i == 1)
                {
                    val = "Silver Medal";
                }else if(i == 2)
                {
                    val = "Bronze Medal";
                }
                else
                {
                    val = (i + 1).ToString();
                }
                scoreMap.Add(scoreSorted[i], val);
            }

            for (int i = 0; i < score.Length; i++)
            {
                ans[i] = scoreMap[score[i]];
            }
            return ans;
        }
    }
}
