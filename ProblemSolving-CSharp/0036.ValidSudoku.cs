using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0036
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> sudokuChecker = new HashSet<string>();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }
                    if (!sudokuChecker.Add(board[i][j] + "- Row: " + i))
                    {
                        return false;
                    }
                    if (!sudokuChecker.Add(board[i][j] + "- Col: " + j))
                    {
                        return false;
                    } 

                    int boxRow = i / 3;
                    int boxCol = j / 3;

                    if (!sudokuChecker.Add(board[i][j].ToString() + "-" + boxRow.ToString() + "-" + boxCol.ToString()))
                    {
                        return false;
                    } 
                }
            }
            return true;
        }
    }
}
