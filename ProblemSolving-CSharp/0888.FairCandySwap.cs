using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0888
    {
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            int[] result = new int[2];  // Initialize the result array to store the boxes to exchange

            int aliceSum = aliceSizes.Sum();  // Calculate the sum of candies Alice has
            int bobSum = bobSizes.Sum();  // Calculate the sum of candies Bob has

            int diff = (bobSum - aliceSum) / 2;  // Calculate the difference of the sums and divide by 2

            HashSet<int> bobset = bobSizes.ToHashSet();  // Store Bob's candy box sizes in a HashSet for quick lookups

            // Iterate over Alice's candy box sizes
            foreach (int aliceVal in aliceSizes)
            {
                int valToLookFor = aliceVal + diff;  // Calculate the candy box size that will be looked for inside bob's set

                // Check if Bob's candy boxes contain the candy box size to exchange
                if (bobset.Contains(valToLookFor))
                {
                    result[0] = aliceVal;  // Set the candy box size of Alice to exchange
                    result[1] = valToLookFor;  // Set the candy box size of Bob to exchange
                    return result;  // Return the result
                }
            }

            return result;  // If no solution is found, return the result with zero values
        }

    }
}
