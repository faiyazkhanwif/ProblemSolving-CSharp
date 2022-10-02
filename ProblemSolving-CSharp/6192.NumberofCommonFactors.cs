using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6192
    {
        //O(n)
        public int CommonFactors(int a, int b)
        {
            int max = Math.Max(a,b);
            int count = 0;

            for (int i = 1; i <= max; i++)
            {
                if (a%i==0 && b%i==0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
