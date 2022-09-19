using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Basics
{
    internal class FindFactorial
    {
        public int FindFactorialRecursively(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * FindFactorialRecursively(n - 1);
        }

        public int FindFactorialIteratively(int n)
        {
            int ans = n;
            n = n - 1;
            while (n > 0)
            {
                ans = ans * (n);
                n--;
            }
            return ans;
        }
    }

}
