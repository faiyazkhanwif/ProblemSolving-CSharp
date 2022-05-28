using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _6083
    {

        public bool DigitCount(string num)
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            for (int i = 0; i < num.Length; i++)
            {
                occurrences.Add(i, 0);
            }


            for (int i = 0; i < num.Length; i++)
            {
                if (!occurrences.ContainsKey(Int32.Parse(num[i].ToString())))
                {
                    return false;
                }
                occurrences[Int32.Parse(num[i].ToString())]++;
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (occurrences[i] != Int32.Parse(num[i].ToString()))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
