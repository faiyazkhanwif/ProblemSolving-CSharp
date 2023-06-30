using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
    internal class _0290
    {
        public bool WordPattern(string pattern, string s)
        {
            // Split the input string into an array of words
            string[] words = s.Split(' ');

            // Check if the number of words is different from the pattern length
            if (words.Length != pattern.Length)
            {
                // If they are different, the pattern cannot match the words
                return false;
            }

            // Create a dictionary to store character-word mappings
            Dictionary<char, string> charAndWord = new Dictionary<char, string>();

            // Iterate over each character in the pattern and its corresponding word
            for (int i = 0; i < pattern.Length; i++)
            {
                // If the character is not in the dictionary
                if (!charAndWord.ContainsKey(pattern[i]))
                {
                    // Check if the word is already mapped to another character
                    if (!charAndWord.ContainsValue(words[i]))
                    {
                        // If not, add the character-word mapping to the dictionary
                        charAndWord.Add(pattern[i], words[i]);
                    }
                    else
                    {
                        // If the word is already mapped to another character, the pattern is invalid
                        return false;
                    }
                }
                else
                {
                    // If the character is already in the dictionary,
                    // check if its mapped word is different from the current word
                    if (charAndWord[pattern[i]] != words[i])
                    {
                        // If they are different, the pattern is invalid
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
