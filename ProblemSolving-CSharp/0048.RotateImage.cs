using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0048
    {
        public void Rotate(int[][] matrix)
        {
            //Reverse the matrix from top to bottom
            for (int columnInd = 0; columnInd < matrix[0].Length; columnInd++)
            {
                int startInd = 0;
                int endInd = matrix.Length - 1;
                while (startInd < endInd)
                {
                    int temp = matrix[startInd][columnInd];
                    matrix[startInd][columnInd] = matrix[endInd][columnInd];
                    matrix[endInd][columnInd] = temp;
                    startInd++;
                    endInd--;
                }
            }

            //Create transpose of the reversed matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }

    }
}
