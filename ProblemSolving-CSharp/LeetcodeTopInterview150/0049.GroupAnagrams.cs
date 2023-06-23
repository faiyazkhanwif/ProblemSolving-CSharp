using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0049
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> answer = new List<IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] == "-")
                {
                    continue;
                }

                string word = strs[i];

                IList<string> anagrams = new List<string>();
                anagrams.Add(word);

                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (strs[j] == "-")
                    {
                        continue;
                    }
                    if (isAnagram(word, strs[j]))
                    {
                        anagrams.Add(strs[j]);
                        strs[j] = "-";
                    }
                }

                answer.Add(anagrams);
            }

            return answer;
        }

        bool isAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            Dictionary<char, int> charInt = new Dictionary<char, int>();

            foreach (char letter in word1)
            {
                if (charInt.ContainsKey(letter))
                {
                    charInt[letter]++;
                }
                else
                {
                    charInt.Add(letter, 1);
                }
            }

            foreach (char letter in word2)
            {
                if (!charInt.ContainsKey(letter))
                {
                    return false;
                }

                charInt[letter]--;

                if (charInt[letter] < 0)
                {
                    return false;
                }
            }

            return true;
        }
        public IList<IList<string>> GroupAnagramsOptimized(string[] strs)
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
                    keyAndWords.Add(key, newList);
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
