using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> freqDic = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (freqDic.ContainsKey(t[i]))
                {
                    freqDic[t[i]]++;
                }
                else
                {
                    freqDic.Add(t[i], 1);
                }
            } 
            for (int i = 0; i < s.Length; i++)
            {
                if (freqDic.ContainsKey(s[i]) && freqDic[s[i]]>0)
                {
                    freqDic[s[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
