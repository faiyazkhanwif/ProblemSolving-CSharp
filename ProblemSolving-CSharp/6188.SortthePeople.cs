using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6188
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            string[] namesSorted = new string[names.Length];

            Dictionary<int, string> heightNames = new Dictionary<int, string>();
            for (int i = 0; i < heights.Length; i++)
            {
                heightNames.Add(heights[i], names[i]);
            }
            Array.Sort(heights);
            int ind = 0;
            for (int i = heights.Length-1; i >=0 ; i--)
            {
                namesSorted[ind] = heightNames[heights[i]];
                ind++;
            }

            return namesSorted;
        }
    }
}
