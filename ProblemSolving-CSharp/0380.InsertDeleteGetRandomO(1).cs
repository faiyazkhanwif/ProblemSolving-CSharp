using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0380
    {
        public class RandomizedSet
        {
            static Random rnd = new Random();
            Dictionary<int, int> indVal;
            List<int> list;

            public RandomizedSet()
            {
                indVal = new Dictionary<int, int>();
                list = new List<int>();
            }

            public bool Insert(int val)
            {
                if (indVal.ContainsKey(val))
                {
                    return false;
                }
                list.Add(val);
                indVal.Add(val, list.Count - 1);
                return true;
            }

            public bool Remove(int val)
            {
                if (!indVal.ContainsKey(val))
                {
                    return false;
                }

                int index = indVal[val]; 
                int valToBeDeleted = list[index];
                list[index] = list[list.Count - 1];
                indVal[list[index]] = index;
                list[list.Count - 1] = valToBeDeleted;
                list.RemoveAt(list.Count - 1);
                indVal.Remove(val);
                return true;
            }

            public int GetRandom()
            {
                return list[rnd.Next(list.Count)];
            }
        }
    }
}
