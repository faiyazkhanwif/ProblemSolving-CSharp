using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0125
    {
        public bool isPalindrome(string s)
        {
            s = s.ToLower().Replace("[^A-Za-z0-9]", "");
            int i = 0;
            int j = s.Length - 1;
            while (i <= j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
