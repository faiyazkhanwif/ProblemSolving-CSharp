using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0049
    {
        //O(n*klogk)
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();

            Dictionary<string, List<string>> keyAndWords = new Dictionary<string, List<string>>(); 

            for (int i = 0; i < strs.Length; i++)
            {
                string key = strs[i].ToLower();

                key = SortString(key);

                if (keyAndWords.ContainsKey(key))
                {
                    keyAndWords[key].Add(strs[i]);
                }
                else
                {
                    List<string> newList = new List<string>();
                    newList.Add(strs[i]);
                    keyAndWords.Add(key,newList); 
                }
            }

            foreach (List<string> listofWords in keyAndWords.Values)
            {
                result.Add(listofWords);
            }


            return result;
        }

        static string SortString(string input) // Using this to create keys to check anagram status
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
