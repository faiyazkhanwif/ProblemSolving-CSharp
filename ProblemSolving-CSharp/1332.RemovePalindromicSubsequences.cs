using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _1332
    {
        public int RemovePalindromeSub(string s)
        {
            if (s.Equals(""))
            {
                //If any string is empty, then we don't need to do anything and return 0.
                return 0;
            }
            else
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                string revS = new string(charArray);
                if (revS.Equals(s))
                {
                    //If a string is a palindrome then we can delete the whole string in a single operation as a string is also a subsequence of itself. For such case, we need to return 1.
                    return 1;
                }
                else
                {
                    //As the string can contain only 'a' or 'b' only. So if the string is not palindrome then I can delete all the 'a's in the first pass then all the 'b's in the second pass, so the max operations we need is 2 if the string is not a palindrome.
                    return 2;
                }
            }

        }
    }
}
