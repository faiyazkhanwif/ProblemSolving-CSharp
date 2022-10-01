using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0392
    {
        //O(n)
        public bool IsSubsequence(string s, string t)
        {
            int ti = t.Length - 1;
            int si = s.Length - 1;

            while (si >= 0 && ti >= 0)
            {
                if (s[si] == t[ti])
                {
                    si--;
                }

                //Console.WriteLine("si: "+si);
                ti--;
            }

            return si < 0;
        }
    }
}
