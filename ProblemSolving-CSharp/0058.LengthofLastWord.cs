using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0058
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] words = s.Split(" ").ToArray();
            return words[words.Length - 1].Length;
        }
    }
}
