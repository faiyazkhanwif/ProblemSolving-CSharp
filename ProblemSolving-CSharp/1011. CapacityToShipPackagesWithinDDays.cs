using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _1011
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            // Initialize the minimum and maximum weight capacities for the ship
            int minCapacity = weights.Max();
            int maxCapacity = weights.Sum();

            // Initialize the current capacity to an invalid value
            int currCap = -1;

            // Perform binary search between minimum and maximum capacities to find the least capacity
            // that can ship all the packages within D days
            while (minCapacity <= maxCapacity)
            {
                // Calculate the middle capacity between the minimum and maximum capacities
                int mid = minCapacity + (maxCapacity - minCapacity) / 2;

                // Check if we can ship all the packages within D days using the middle capacity
                if (canShip(mid, weights, days))
                {
                    // If yes, update the current capacity and continue searching towards smaller capacities
                    currCap = mid;
                    maxCapacity = mid - 1;
                }
                else
                {
                    // If no, increase the minimum capacity and continue searching towards larger capacities
                    minCapacity = mid + 1;
                }
            }

            // Return the least capacity that can ship all the packages within D days
            return currCap;
        }

        public bool canShip(int capacity, int[] weights, int days)
        {
            // Initialize the current capacity to the input capacity
            int currCap = capacity;

            // Iterate through each package and check if it can be loaded onto the ship
            foreach (int weight in weights)
            {
                if (currCap - weight >= 0)
                {
                    // If the package can be loaded onto the ship, update the current capacity
                    currCap -= weight;
                }
                else
                {
                    // If the package cannot be loaded onto the ship, we need to use another day to ship it
                    days--;
                    currCap = capacity - weight;
                }
            }

            // Return true if we can ship all the packages within D days using the input capacity
            return days > 0;
        }

    }
}

