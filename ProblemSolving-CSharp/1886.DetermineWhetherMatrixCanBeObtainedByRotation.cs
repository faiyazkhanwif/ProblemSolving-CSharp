using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _1886
    {
        //O(n^2) Brute Force
        public bool FindRotation(int[][] mat, int[][] target)
        {
            for (int i = 0; i < 4; i++)
            {
                int[][] tempMat = new int[mat.Length][]; //Temp matrix to store rotated matrix
                int nalt = 0;
                bool matched = true;

                //Start rotation
                for (int m = 0; m < mat.Length; m++)
                {
                    int malt = mat.Length - 1;
                    tempMat[m] = new int[mat[malt].Length];
                    for (int n = 0; n < mat[0].Length; n++)
                    {
                        tempMat[m][n] = mat[malt][nalt];
                        malt--;

                        //We check if the element at [m,n] is equal to the target[m,n] or not,
                        //If the elements are not the same, that means the arrays will not be same in this rotation
                        if (tempMat[m][n] != target[m][n])
                        {
                            matched = false;
                        }
                    }
                    nalt++;
                }

                if (matched)
                {
                    return true;
                }
                else
                {
                    mat = tempMat; //We store the rotated temp matrix in "mat" for next rotation 
                }

            }
            return false;
        }
    }
}