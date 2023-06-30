using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0202
    {
        public bool IsHappy(int n)
        {
            string valueStr = n.ToString();
            bool happy = true;
            HashSet<int> allValues = new HashSet<int>();

            while (happy)
            {

                int sum = 0;

                foreach (char x in valueStr)
                {
                    sum += int.Parse(x.ToString()) * int.Parse(x.ToString());
                }

                if (sum == 1)
                {
                    return happy;
                }
                else if (allValues.Contains(sum))
                {
                    //Cyclic, so not happy
                    happy = false;
                }
                else
                {
                    allValues.Add(sum);
                    valueStr = sum.ToString();
                }
            }

            return happy;

        }
    }
}
