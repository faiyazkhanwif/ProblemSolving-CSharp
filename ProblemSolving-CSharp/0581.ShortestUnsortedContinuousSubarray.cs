using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0581
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int[] myarr = new int[nums.Length];
            nums.CopyTo(myarr, 0);

            Array.Sort(myarr);

            //for (int i = 0; i < myarr.Length; i++)
            //{
            //    Console.WriteLine(myarr[i]);
            //}
            int start = 0;
            int end = nums.Length - 1;
            bool needsorting = false;

            for (int i = 0; i < myarr.Length; i++)
            {
                if (myarr[i] != nums[i])
                {
                    needsorting = true;
                    start = i;
                    break;
                }
            }
            if (!needsorting)
            {
                return 0;
            }
            //Console.WriteLine("start - "+ start);

            for (int i = myarr.Length - 1; i >= 0; i--)
            {
                if (myarr[i] != nums[i])
                {
                    end = i;
                    break;
                }
            }
            //Console.WriteLine("end - " + end);
            return end - start + 1;
        }
    }
}
