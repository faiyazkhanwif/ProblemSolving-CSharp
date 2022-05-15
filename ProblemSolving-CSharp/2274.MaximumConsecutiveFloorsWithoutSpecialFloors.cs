using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _2274
    {
        //unoptimized
        int MaxConsecutive(int bottom, int top, int[] special)
        {
            int specialInd = 0;
            int floorCount = 0;
            int maxflCnt = 0;
            Array.Sort(special);

            for (int i = bottom; i <= top; i++)
            {
                if (specialInd < special.Length && i == special[specialInd])
                {
                    if (maxflCnt < floorCount)
                    {
                        maxflCnt = floorCount;
                    }
                    floorCount = 0;
                    specialInd++;
                }
                else
                {
                    floorCount++;
                    if (i == top && floorCount > maxflCnt)
                    {
                        maxflCnt = floorCount;
                    }
                }
            }
            return maxflCnt;
        }
        //Optimized
        int MaxConsecutiveOpt(int bottom, int top, int[] special)
        {
            int maxflCnt = 0;
            Array.Sort(special);

            for (int i = 0; i < special.Length; i++)
            {
                int temp = (special[i] - bottom);
                if (temp > maxflCnt)
                {
                    maxflCnt = temp;
                }
                bottom = special[i] + 1;
            }
            int cornercase = top - special[special.Length - 1];
            if (cornercase > maxflCnt)
            {
                maxflCnt = cornercase;
            }
            return maxflCnt;

        }
    }

}
