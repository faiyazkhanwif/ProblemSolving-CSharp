using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0438
    {
        //TLE
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> list = new List<int>();
            int pLen = p.Length;
            if (pLen > s.Length)
            {
                return list;
            }
            Dictionary<char, int> pCharFreq = new Dictionary<char, int>();
            for (int i = 0; i < pLen; i++)
            {
                if (pCharFreq.ContainsKey(p[i]))
                {
                    pCharFreq[p[i]]++;
                }
                else
                {
                    pCharFreq.Add(p[i], 1);
                }
            }

            int wStartInd = 0;
            int wEndInd = pLen - 1;

            while (wEndInd < s.Length)
            {
                Dictionary<char, int> windoCharFreq = new Dictionary<char, int>();
                bool validWindow = true;
                for (int j = wStartInd; j <= wEndInd; j++)
                {
                    if (windoCharFreq.ContainsKey(s[j]))
                    {
                        windoCharFreq[s[j]]++;
                    }
                    else
                    {
                        windoCharFreq.Add(s[j], 1);
                    }
                }

                for (int j = wStartInd; j <= wEndInd; j++)
                {

                    if (!(pCharFreq.ContainsKey(s[j])) || (pCharFreq.ContainsKey(s[j]) && windoCharFreq[s[j]] != pCharFreq[s[j]]))
                    {
                        validWindow = false;
                        break;
                    }
                }

                if (validWindow)
                {
                    list.Add(wStartInd);
                }
                wEndInd++;
                wStartInd++;
            }

            return list;

        }


        public IList<int> FindAnagramsOpti(string s, string p)
        {
            IList<int> list = new List<int>();
            int pLen = p.Length;
            if (pLen > s.Length)
            {
                return list;
            }
            Dictionary<char, int> pCharFreq = new Dictionary<char, int>();
            for (int i = 0; i < pLen; i++)
            {
                if (pCharFreq.ContainsKey(p[i]))
                {
                    pCharFreq[p[i]]++;
                }
                else
                {
                    pCharFreq.Add(p[i], 1);
                }
            }

            int wStartInd = 0;
            int wEndInd = pLen - 1;

            Dictionary<char, int> windoCharFreq = new Dictionary<char, int>();
            for (int j = wStartInd; j <= wEndInd; j++)
            {
                if (windoCharFreq.ContainsKey(s[j]))
                {
                    windoCharFreq[s[j]]++;
                }
                else
                {
                    windoCharFreq.Add(s[j], 1);
                }
            }


            while (wEndInd < s.Length)
            {
                bool validWindow = true;

                for (int j = wStartInd; j <= wEndInd; j++)
                {

                    if (!(pCharFreq.ContainsKey(s[j])) || (pCharFreq.ContainsKey(s[j]) && windoCharFreq[s[j]] != pCharFreq[s[j]]))
                    {
                        validWindow = false;
                        break;
                    }
                }

                if (validWindow)
                {
                    list.Add(wStartInd);
                }

                wEndInd++;
                if (wEndInd < s.Length)
                {
                    if (windoCharFreq.ContainsKey(s[wEndInd]))
                    {
                        windoCharFreq[s[wEndInd]]++;
                    }
                    else
                    {
                        windoCharFreq.Add(s[wEndInd], 1);
                    }
                }
                else
                {
                    break;
                }


                windoCharFreq[s[wStartInd]]--;

                if (windoCharFreq[s[wStartInd]] <= 0)
                {
                    windoCharFreq.Remove(s[wStartInd]);
                }
                wStartInd++;
            }

            return list;

        }
    }
}

