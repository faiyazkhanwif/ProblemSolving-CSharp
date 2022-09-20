using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

        //O(n) 
        public int fibonacciDP(int n)
        {
            Dictionary<int, int> dpCache = new Dictionary<int, int>();
            return fib(n);
            //Creating a local function "fib" so that we don't need to create "dpCache" as a global variable.
            int fib(int n)
            {
                if (dpCache.ContainsKey(n))
                {
                    return dpCache[n];
                }
                else
                {
                    if (n == 0)
                    {
                        return 0;
                    }
                    else if (n == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        dpCache.TryAdd(n - 1, fib(n - 1));
                        dpCache.TryAdd(n - 2, fib(n - 2));
                        return dpCache[n - 1] + dpCache[n - 2];
                    }
                }

            }
        }
    }
}
