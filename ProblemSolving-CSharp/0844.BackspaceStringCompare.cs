using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0844
    {
        public bool BackspaceCompare(string s, string t)
        {
            string resS = strbuilder(s);
            string resT = strbuilder(t);

            return resS.Equals(resT);

        }

        public string strbuilder(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('#'))
                {
                    if (res.Length != 0)
                    {
                        //Console.WriteLine("Dhukbena");
                        res = res.Remove(res.Length - 1);
                    }
                }
                else
                {
                    res += s[i];
                    //Console.WriteLine(res);
                }
            }

            return res;
        }
    }
}
