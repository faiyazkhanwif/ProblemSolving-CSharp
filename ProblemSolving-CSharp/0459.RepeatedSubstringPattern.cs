using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0459
    {
        //O(n^2)
        public bool RepeatedSubstringPattern(string s)
        {
            for (int i = s.Length / 2; i >= 1; i--)
            {
                if (s.Length % i == 0) //This means we can create a string of same length by appending substring s.length/i times
                {
                    int timesToBeAppended = s.Length / i;

                    string substr = s.Substring(0, i);

                    string tempres = "";
                    for (int j = 0; j < timesToBeAppended; j++)
                    {
                        tempres += substr;
                    }

                    if (tempres.Equals(s))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
