using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0028
    {
        //O(m*n)
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    bool matched = true;
                    int ind = i;
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (ind > haystack.Length - 1 || haystack[ind] != needle[j])
                        {
                            matched = false;
                            break;
                        }
                        ind++;
                    }
                    if (matched)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
