using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0867
    {
        public int[][] Transpose(int[][] matrix)
        {
            int rowlen = matrix[0].Length;
            int collen = matrix.Length;
            int[][] ans = new int[rowlen][];
            for (int i = 0; i < rowlen; i++)
            {
                ans[i] = new int[collen];
            }
            
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    ans[j][i] = matrix[i][j];
                }
            }
            return ans;
            
        }
    }
}
