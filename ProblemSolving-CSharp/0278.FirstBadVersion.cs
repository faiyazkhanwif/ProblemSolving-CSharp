using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0278
    {
        public int FirstBadVersion(int n)
        {
            int start = 1;
            int end = n;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (IsBadVersion(mid))
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;

                }
            }

            return end + 1;
        }


        //Provided by leetcode
        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }
    }
}
