using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0074
    {
        //Brute force - O(mn)
        public bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == target)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool SearchMatrixOpti(int[][] matrix, int target) //O(m*n)
        {
            // Iterate through each row of the matrix.
            for (int i = 0; i < matrix.Length; i++)
            {
                // If the last element in the current row is smaller than the target, skip to the next row.
                if (matrix[i][matrix[i].Length - 1] < target)
                {
                    continue;
                }
                // Otherwise, search the current row for the target element.
                else
                {
                    // Iterate through each element in the current row, starting from the last element.
                    for (int j = matrix[i].Length - 1; j >= 0; j--)
                    {
                        // If the current element is the target, return true.
                        if (matrix[i][j] == target)
                        {
                            return true;
                        }
                    }
                }
            }

            // If the element was not found, return false.
            return false;
        }

        public bool SearchMatrixBinary(int[][] matrix, int target) // O(log(m * n))
        {
            // Set the start and end indices of the rows and columns.
            int rowStart = 0;
            int rowEnd = matrix.Length - 1;
            int colStart = 0;
            int colEnd = matrix[0].Length - 1;

            // Continue searching until the start and end indices meet or cross.
            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                // Calculate the middle indices.
                int rowMid = rowStart + (rowEnd - rowStart) / 2;
                int colMid = colStart + (colEnd - colStart) / 2;

                // If the element at the middle indices is the target, return true.
                if (matrix[rowMid][colMid] == target)
                {
                    return true;
                }

                /*If the element at the middle indices is smaller than the target, check if the last element of the current row is smaller or not. 
                If the element is smaller we search from the next row. Otherwise, we stay in the current row and start searching from the next element.*/
                if (matrix[rowMid][colMid] < target)
                {
                    if (matrix[rowMid][colEnd] < target)
                    {
                        rowStart = rowMid + 1;
                    }
                    else
                    {
                        colStart = colMid + 1;
                    }
                }
                /* If the element at the middle indices is larger than the target, check if the first element of the current row is bigger or not. 
                If the element is bigger our search space shrinks till the last row. Otherwise, we stay in the current row and start searching till the element before our mid element.*/
                else
                {
                    if (matrix[rowMid][colStart] > target)
                    {
                        rowEnd = rowMid - 1;
                    }
                    else
                    {
                        colEnd = colMid - 1;
                    }
                }
            }

            // If the element was not found, return false.
            return false;
        }
    }
}
