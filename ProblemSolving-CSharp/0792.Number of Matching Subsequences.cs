using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0792
    {
        //Unoptimized solution using a Custom Object
        class Cobject
        {
            public int Index { get; set; }
            public bool Used { get; set; }
        }
        public int NumMatchingSubseq(string s, string[] words)
        {
            int cnt = 0;

            foreach (string word in words)
            {
                Dictionary<char, List<Cobject>> keyValuePairs = new Dictionary<char, List<Cobject>>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (keyValuePairs.ContainsKey(s[i]))
                    {
                        keyValuePairs[s[i]].Add(new Cobject() { Index = i, Used = false });
                    }
                    else
                    {
                        keyValuePairs.Add(s[i], new List<Cobject>() { new Cobject() { Index = i, Used = false } });
                    }
                }

                bool subsequence = true;
                int cInd = 0;
                int prevSInd = -1;


                foreach (char c in word)
                {
                    if (!s.Contains(c))
                    {
                        subsequence = false;
                        break;
                    }

                    List<Cobject> indexes = keyValuePairs[c];
                    bool found = false;

                    foreach (Cobject index in indexes)
                    {
                        if (index.Used == false && index.Index > prevSInd)
                        {
                            index.Used = true;
                            prevSInd = index.Index;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        subsequence = false;
                        break;
                    }
                }

                if (subsequence)
                {
                    cnt++;
                }

            }
            return cnt;
        }


        //Brute Force
        public int NumMatchingSubseqII(string s, string[] words)
        {
            int res = 0;
            foreach (string word in words)
            {
                //Console.WriteLine(word);
                bool subsequence = false;
                int pointerForW = 0;
                int pointerForS = 0;
                while (pointerForS < s.Length)
                {
                    if (pointerForW >= word.Length)
                    {
                        break;
                    }
                    if (s[pointerForS].Equals(word[pointerForW]))
                    {
                        pointerForW++;
                        pointerForS++;
                    }
                    else
                    {
                        pointerForS++;
                    }
                }
                if (pointerForW >= word.Length)
                {
                    subsequence = true;
                }

                if (subsequence)
                {
                    res++;
                }
            }
            return res;
        }


        //Dictionary
        public int NumMatchingSubseqIII(string s, string[] words)
        {
            Dictionary<char, List<int>> charIndexes = new Dictionary<char, List<int>>();

            int ind = 0;
            foreach (char c in s)
            {
                if (charIndexes.ContainsKey(c))
                {
                    charIndexes[c].Add(ind);
                }
                else
                {
                    charIndexes.Add(c, new List<int>() { ind });
                }
                ind++;
            }
            int res = 0;
            foreach (string word in words)
            {
                bool sub = true;
                int lastInd = -1;

                Dictionary<char, int> lastUsedInd = new Dictionary<char, int>();

                foreach (char c in word)
                {
                    if (charIndexes.ContainsKey(c))
                    {  
                        List<int> indexes = charIndexes[c];
                        bool found = false;

                        int i = 0;
                        if (lastUsedInd.ContainsKey(c))
                        {
                            i = lastUsedInd[c]+1;
                        } 

                        while (i < indexes.Count)
                        {
                            if (indexes[i]>lastInd)
                            {
                                found = true;
                                lastInd = indexes[i];
                                if (!lastUsedInd.ContainsKey(c))
                                {
                                    lastUsedInd.Add(c, i);
                                }
                                else
                                { 
                                    lastUsedInd[c] = i;
                                }
                                break;
                            }
                            i++;
                        }

                        if (!found)
                        {
                            sub = false;
                        }
                          
                    }
                    else
                    {
                        sub = false;
                    }

                    if (!sub)
                    {
                        break;
                    }
                     
                }

                if (sub)
                {
                    res++;
                }
            }
            return res;
        }

    }
}
