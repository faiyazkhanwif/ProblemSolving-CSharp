using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0169
    {
        public int MajorityElement(int[] nums)
        {
            int n = nums.Length;
            int element = 0;
            Dictionary<int, int> elementCounts = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (elementCounts.ContainsKey(i))
                {
                    elementCounts[i]++;
                }
                else
                {
                    elementCounts[i] = 1;
                }
                if (elementCounts[i] > n / 2)
                {
                    element = i;
                    break;
                }
            }
            return element;
        }
    }
}
