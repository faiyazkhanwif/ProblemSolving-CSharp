using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _5234
    {
        public IList<string> RemoveAnagrams(string[] words)
        {
            IList<string> ans = new List<string>();
            int prevInd = 0;
            int currInd = 1;
            while (currInd < words.Length)
            {
                string prevWord = words[prevInd];
                string currWord = words[currInd];

                if (isAnagram(prevWord, currWord))
                {
                    words[currInd] = "-";
                }
                else
                {
                    prevInd = currInd;
                }
                currInd++;
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Equals("-"))
                {
                    ans.Add(words[i]);
                }
            }
            return ans;
        }

        bool isAnagram(String a, String b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (map.ContainsKey(a[i]))
                {
                    map[a[i]] = map[a[i]] + 1;
                }
                else
                {
                    map.Add(a[i], 1);
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (map.ContainsKey(b[i]))
                {
                    map[b[i]] = map[b[i]] - 1;
                }
            }
            var keys = map.Keys;
            foreach (char key in keys)
            {
                if (map[key] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
