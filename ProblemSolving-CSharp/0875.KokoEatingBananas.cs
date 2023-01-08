using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0378
    {
        //Brute Force - O(max(piles)*piles.Length)
        public int MinEatingSpeed(int[] piles, int h)
        {
            int currSpeed = 1;

            int resSpeed = 1;

            int totalHoursTaken = 0;

            int i = 0;

            while (i < piles.Length)
            {
                double dbAns = (double)piles[i] / currSpeed;
                decimal decAns = Convert.ToDecimal(dbAns);
                //Console.WriteLine(dbAns + " -> "+decAns);

                int hoursTakenForPile = (int)Math.Ceiling(decAns);

                //Console.WriteLine("Hours Taken for pile: "+hoursTakenForPile);

                totalHoursTaken += hoursTakenForPile;

                if (totalHoursTaken > h)
                {
                    currSpeed++;
                    totalHoursTaken = 0;
                    i = 0;
                    //Console.WriteLine("----------NEW SPEED--------- " + currSpeed);
                    continue;
                }
                if (totalHoursTaken <= h && i == piles.Length - 1)
                {
                    resSpeed = currSpeed;
                }
                i++;
            }

            return resSpeed;
        }

        //O(log(max(piles))*piles.Length)
        public int MinEatingSpeedBinary(int[] piles, int h)
        {
            // Find the maximum number of bananas in any pile
            int maxPile = -1;
            for (int i = 0; i < piles.Length; i++)
            {
                if (maxPile < piles[i])
                {
                    maxPile = piles[i];
                }
            }

            // Set the lower bound and upper bound for the binary search
            int startInd = 0;
            int endInd = maxPile - 1;
            int resSpeed = 0;

            // Binary search for the minimum eating speed
            while (startInd <= endInd)
            {
                int midInd = startInd + ((endInd - startInd) / 2);
                int currSpeed = midInd + 1;
                int totalHoursTaken = 0;
                int i = 0;
                while (i < piles.Length)
                {
                    // Calculate the number of hours taken to eat the current pile at the current speed
                    int hoursTakenForPile = (int)Math.Ceiling((double)piles[i] / currSpeed);
                    totalHoursTaken += hoursTakenForPile;
                    // If the total hours taken is greater than h, the current speed is too slow
                    // so we increase the lower bound for the binary search
                    if (totalHoursTaken > h)
                    {
                        startInd = midInd + 1;
                        break;
                    }
                    // If the total hours taken is less than or equal to h and we have processed all piles,
                    // the current speed is sufficient so we update the result and decrease the upper bound for the binary search
                    if (totalHoursTaken <= h && i == piles.Length - 1)
                    {
                        resSpeed = currSpeed;
                        endInd = midInd - 1;
                    }
                    i++;
                }
            }

            // Return the result
            return resSpeed;
        }

    }
}

