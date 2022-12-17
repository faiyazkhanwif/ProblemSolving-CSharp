using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0432
    {
        //TLE
        public class AllOne
        {
            Dictionary<string, int> map; 

            public AllOne()
            {
                map = new Dictionary<string, int>(); 
            }

            public void Inc(string key)
            {
                if (map.ContainsKey(key))
                {
                    map[key]++;
                }
                else
                {
                    map.Add(key, 1);
                }
            }

            public void Dec(string key)
            {
                if (map.ContainsKey(key))
                {
                    map[key]--;
                    if (map[key] <= 0)
                    {
                        map.Remove(key);
                    }
                }
            }

            public string GetMaxKey()
            {
                if (map.Count != 0)
                {
                    return map.MaxBy(keyValuePair => keyValuePair.Value).Key;
                }
                else
                {
                    return "";
                }
            }

            public string GetMinKey()
            {
                if (map.Count != 0)
                {
                    return map.MinBy(keyValuePair => keyValuePair.Value).Key;
                }
                else
                {
                    return "";
                }
            }
        }

    }
}
