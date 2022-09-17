using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _2410
    { 
        public int MatchPlayersAndTrainersOpti(int[] players, int[] trainers)
        {
            Array.Sort(players);
            Array.Sort(trainers);

            int maxCount = 0;
            int trainerIndex = trainers.Length - 1;
            for (int i = players.Length - 1; i >= 0; i--)
            {
                if (players[i] <= trainers[trainerIndex])
                {
                    maxCount++;
                    trainerIndex--;
                }

                if (trainerIndex < 0)
                {
                    break;
                }
            }
            return maxCount;

        }
    }
}
