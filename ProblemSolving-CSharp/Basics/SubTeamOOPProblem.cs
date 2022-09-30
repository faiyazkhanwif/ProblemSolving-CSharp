using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Basics
{
    internal class SubTeamOOPProblem
    {
        public class Team
        {
            public string teamName { get; set; }
            public int noOfPlayers { get; set; }

            public Team(string teamName, int noOfPlayers)
            {
                this.teamName = teamName;
                this.noOfPlayers = noOfPlayers;
            }

            void AddPlayer(int count)
            {
                noOfPlayers += count;
            }


            bool RemovePlayer(int count)
            {
                int temp = noOfPlayers - count;
                if (temp < 0)
                {
                    return false;
                }
                else
                {
                    noOfPlayers -= count;
                    return true;
                }

            }
        }

        public class Subteam : Team
        {
            public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
            {
            }

            void ChangeTeamName(string name)
            {
                teamName = name;
            }
        }
    }
}
