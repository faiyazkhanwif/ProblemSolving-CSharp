using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0005
    {
        //TLE
        public string LongestPalindrome(string s)
        { 
            string res = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    int len = j - i + 1;
                    string subString = s.Substring(i, len);

                    char[] charArray = subString.ToCharArray();
                    Array.Reverse(charArray);
                    string revsubString = new string(charArray);

                    if (subString.Equals(revsubString) && subString.Length > res.Length)
                    {
                        res = subString;
                    }
                }
            }

            return res;
        }

        public string LongestPalindromeOpti(string s)
        {
            string res = "";
            int subStart = 0;
            int subEnd = 0;
            int maxLen = 0;

            for (int i = 0; i < s.Length; i++)
            {

                //Odd Palindrome
                int start = i;
                int end = i;
                while (end<s.Length && start>=0 && s[start] == s[end])
                {
                    int tempLen = end - start + 1;
                    if (maxLen<(tempLen))
                    {
                        subStart = start;
                        subEnd = end;
                        maxLen = tempLen;
                    }
                    start--;
                    end++;
                }

                //Even Palindrome
                start = i;
                end = i+1;
                while (end < s.Length && start >= 0 && s[start] == s[end])
                {
                    int tempLen = end - start + 1;
                    if (maxLen < (tempLen))
                    {
                        subStart = start;
                        subEnd = end;
                        maxLen = tempLen;
                    }
                    start--;
                    end++;
                }
            }

            return s.Substring(subStart, subEnd - subStart + 1);;
        }
    }
}
