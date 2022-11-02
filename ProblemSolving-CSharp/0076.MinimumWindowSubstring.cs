using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0076
    {
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> table = new Dictionary<char, int>();

            // initialize frequency table for t
            foreach (char c in t)
            {
                if (table.ContainsKey(c))
                {
                    table[c]++;
                }
                else
                {
                    table.Add(c, 1);
                }
            }

            // initialize sliding window
            int begin = 0, end = 0;
            int counter = table.Count;
            int len = int.MaxValue;

            string ans = "";

            // start sliding window
            while (end < s.Length)
            {
                char endchar = s[end];

                // if current char found in table, decrement count
                if (table.ContainsKey(endchar))
                {
                    table[endchar]--;
                    if (table[endchar] == 0) counter--;
                }

                end++;
                while (counter == 0)
                {
                    if (end - begin < len)
                    {
                        len = end - begin;
                        ans = s.Substring(begin, end - begin);
                    }
                    char startchar = s[begin];

                    if (table.ContainsKey(startchar))
                    {
                        table[startchar]++;
                        if (table[startchar] > 0) counter++;
                    }

                    begin++;
                }
            }

            return ans;

        }
    }
}

