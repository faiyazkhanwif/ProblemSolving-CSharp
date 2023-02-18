using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _6359
    {
        public int MinMaxDifference(int num)
        {
            string numstr = num.ToString();

            int ind = 0;

            int maxVal = int.Parse(numstr);
            int minVal = int.Parse(numstr);

            //Find max
            while (ind < numstr.Length)
            {
                if (numstr[ind] != '9')
                {
                    string replacedNumStr = numstr.Replace(numstr[ind], '9');
                    maxVal = int.Parse(replacedNumStr);
                    break;
                }
                else
                {
                    ind++;
                }
            }
            //Console.WriteLine(maxVal);
            ind = 0;
            //Find min
            while (ind < numstr.Length)
            {
                if (numstr[ind] != '0')
                {
                    string replacedNumStr = numstr.Replace(numstr[ind], '0');
                    //Console.WriteLine("replacedNumStr min: "+replacedNumStr);
                    minVal = int.Parse(replacedNumStr);
                    break;
                }
                else
                {
                    ind++;
                }
            }
            //Console.WriteLine(minVal);
            return maxVal - minVal;
        }
    }
}
