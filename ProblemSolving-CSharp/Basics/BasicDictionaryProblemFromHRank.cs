using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Basics
{
    internal class BasicDictionaryProblemFromHRank
    {
        static void checkMagazine(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> wordCountStorage = new Dictionary<string, int>();

            for (int i = 0; i < magazine.Count; i++)
            {
                if (wordCountStorage.ContainsKey(magazine[i]))
                {
                    wordCountStorage[magazine[i]] = wordCountStorage[magazine[i]] + 1;
                }
                else
                {
                    wordCountStorage.Add(magazine[i], 1);
                }
            }

            Dictionary<string, int> wordCountStorage2 = new Dictionary<string, int>();

            for (int i = 0; i < note.Count; i++)
            {
                if (wordCountStorage2.ContainsKey(note[i]))
                {
                    wordCountStorage2[note[i]] = wordCountStorage2[note[i]] + 1;
                }
                else
                {
                    wordCountStorage2.Add(note[i], 1);
                }
            }

            bool okay = true;
            for (int i = 0; i < note.Count; i++)
            {
                if (!wordCountStorage.ContainsKey(note[i]) || (wordCountStorage2[note[i]] > wordCountStorage[note[i]]))
                {
                    okay = false;
                    break;
                }
            }

            if (okay)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
