using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0509
    {
        //O(2*n)
        public int fibonacciRecursive(int n)
        {

            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);

        }

        //O(n)
        public int fibonacciIterative(int n)
        {
            int a = 0;
            int b = 1;

            if (n == 0)
            {
                return a;
            }

            if (n == 1)
            {
                return b;

            }

            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
