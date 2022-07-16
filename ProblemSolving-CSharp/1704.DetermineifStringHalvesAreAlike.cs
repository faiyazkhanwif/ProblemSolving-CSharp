using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _1704
    {
        public bool HalvesAreAlike(string s)
        {
            int sLength = s.Length;

            int halfLength= sLength/2;

            //Split string using chunk method
            //var halves = s.Chunk(sLength / 2).Select(x => new string(x)).ToList();

            string firstHalf = "";
            string secondHalf = "";

            for (int i = 0; i < halfLength; i++)
            {
                firstHalf += s[i].ToString();
                secondHalf += s[i+halfLength].ToString();
            }
            
            HashSet<char> vowels = new HashSet<char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');
            vowels.Add('A');
            vowels.Add('E');
            vowels.Add('I');
            vowels.Add('O');
            vowels.Add('U');

            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < sLength/2; i++)
            {

                //string firstHalf = halves[0];
                //string secondHalf = halves[1];

                if (vowels.Contains(firstHalf[i]))
                {
                    count1++;
                }

                if (vowels.Contains(secondHalf[i]))
                {
                    count2++;
                }

            }

            if (count1!=count2)
            {
                return false;
            }

            return true;
        }
    }
}
