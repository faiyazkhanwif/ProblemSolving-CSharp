using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> mapMZ = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (mapMZ.ContainsKey(magazine[i]))
                {
                    mapMZ[magazine[i]]++;
                }
                else
                {
                    mapMZ.Add(magazine[i], 1);
                }
            }

            foreach (char alphabet in ransomNote)
            {
                if (!mapMZ.ContainsKey(alphabet))
                {
                    return false;
                }

                if (mapMZ[alphabet] <= 0)
                {
                    return false;
                }
                else
                {
                    mapMZ[alphabet]--;
                }
            }

            return true;
        }
    }
}
