using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0013
    {
        static int RomanToInt(string s)
        {
            Dictionary<char, int> storage = new Dictionary<char, int>();

            storage.Add('I', 1);
            storage.Add('V', 5);
            storage.Add('X', 10);
            storage.Add('L', 50);
            storage.Add('C', 100);
            storage.Add('D', 500);
            storage.Add('M', 1000);

            int res = 0;
            char lastChar = 'R';

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (
                    (s[i].Equals('I') && (lastChar == 'V' || lastChar == 'X'))
                    || (s[i].Equals('X') && (lastChar == 'L' || lastChar == 'C'))
                    || (s[i].Equals('C') && (lastChar == 'D' || lastChar == 'M'))
                    )
                {
                    int val;
                    storage.TryGetValue(s[i], out val);
                    res -= val;
                }
                else
                {
                    int val;
                    storage.TryGetValue(s[i], out val);
                    res += val;

                }

                lastChar = s[i];

            }
            return res;

        }
    }
}
