using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0003
    {
        //O(n) - LinkedList
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            int longestSubstringLength = 0;
            LinkedList<char> window = new LinkedList<char>();

            window.AddLast(s[0]);
            longestSubstringLength++;

            if (s.Length == 1)
            {
                return longestSubstringLength;
            }

            int runningLength = 1;
            for (int i = 1; i < s.Length; i++)
            {
                while (window.Count != 0 && window.Contains(s[i]))
                {
                    window.RemoveFirst();
                    runningLength--;

                }
                window.AddLast(s[i]);
                runningLength++;
                if (runningLength > longestSubstringLength)
                {
                    longestSubstringLength = runningLength;
                }
            }

            return longestSubstringLength;
        }

        //O(n) - Dictionary
        public int LengthOfLongestSubstringOpti(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            int longestSubstringLength = 0;
            Dictionary<char, int> window = new Dictionary<char, int>();

            window.Add(s[0], 1);
            longestSubstringLength++;

            if (s.Length == 1)
            {
                return longestSubstringLength;
            }

            int runningLength = 1;
            int startInd = 0;
            for (int i = 1; i < s.Length; i++)
            {
                while (window.Count != 0 && window.ContainsKey(s[i]))
                {
                    window[s[startInd]] -= 1;
                    if (window[s[startInd]] == 0)
                    {
                        window.Remove(s[startInd]);
                    }
                    startInd++;
                    runningLength--;

                }
                window.Add(s[i], 1);
                runningLength++;
                if (runningLength > longestSubstringLength)
                {
                    longestSubstringLength = runningLength;
                }
            }

            return longestSubstringLength;
        }
    }
}
