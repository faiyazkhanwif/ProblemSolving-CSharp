using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6197
    {
        public class LUPrefix
        {

            string[] server;
            int longestPref = 0;
            public LUPrefix(int n)
            {
                server = new string[n + 1];
            }

            public void Upload(int video)
            {
                server[video] = "Video";

                //Recalculate longest prefix
                int tempLen = 0;
                for (int i = 1; i < server.Length; i++)
                {
                    if (server[i] == "Video")
                    {
                        tempLen += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tempLen > longestPref)
                {
                    longestPref = tempLen;
                }
            }

            public int Longest()
            {
                return longestPref;
            }
        }

        /**
         * Your LUPrefix object will be instantiated and called as such:
         * LUPrefix obj = new LUPrefix(n);
         * obj.Upload(video);
         * int param_2 = obj.Longest();
         */
    }

}

