using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (t.Length != s.Length)
            {
                return false;
            }

            Dictionary<char, char> charmap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!charmap.ContainsKey(s[i]))
                {
                    if (!charmap.ContainsValue(t[i]))
                    {
                        charmap.Add(s[i], t[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (charmap[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
