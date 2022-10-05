using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0989
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            string kStr = k.ToString();

            List<int> result = new List<int>();

            int numInd = num.Length - 1;
            int kInd = kStr.Length - 1;
            int carry = 0;

            while (kInd>=0 || numInd>=0)
            {
                if (kInd<0 && numInd>=0)
                {
                    int tempAns = carry +  int.Parse(num[numInd].ToString());
                    result.Add(tempAns % 10);
                    carry = tempAns / 10;
                    numInd--;
                }
                else if (numInd<0 && kInd>=0)
                {
                    int tempAns = carry + int.Parse(kStr[kInd].ToString());
                    result.Add(tempAns % 10);
                    carry = tempAns / 10;
                    kInd--;
                }
                else
                { 
                    int tempAns = carry + int.Parse(kStr[kInd].ToString()) + int.Parse(num[numInd].ToString());
                    result.Add(tempAns % 10);
                    carry = tempAns / 10;
                    kInd--;
                    numInd--;
                }
            }

            if (carry!=0)
            {
                result.Add(carry);
            }


            result.Reverse();

            return result;
        }
    }
}
