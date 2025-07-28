using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp._2024.TopInterview150LC
{
    internal class _0202
    {
        public bool IsHappy(int n)
        {
            HashSet<int> visited = new HashSet<int>();
            visited.Add(n);

            bool happy = false;

            while (!happy)
            {
                string nStr = n.ToString();

                int sumOfSquares = 0;
                foreach (char digitChar in nStr)
                {
                    int digit = int.Parse(digitChar.ToString());
                    sumOfSquares += digit * digit;
                }
                //Console.WriteLine(sumOfSquares);
                if (sumOfSquares == 1)
                {
                    happy = true;
                    break;
                }
                else
                {
                    if (visited.Contains(sumOfSquares))
                    {
                        happy = false;
                        break;
                    }
                    else
                    {
                        visited.Add(sumOfSquares);
                        n = sumOfSquares;
                    }
                }
            }
            return happy;
        }
    }
}
