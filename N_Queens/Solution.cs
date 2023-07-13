using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> solutions = new List<IList<string>>();
        char[][] board = new char[n][];

        for (int i = 0; i < n; i++)
        {
            board[i] = new char[n];
            for (int j = 0; j < n; j++)
            {
                board[i][j] = '.';
            }
        }

        Backtrack(board, solutions, 0);
        return solutions;
    }

    private void Backtrack(char[][] board, IList<IList<string>> solutions, int row)
    {
        if (row == board.Length)
        {
            IList<string> solution = new List<string>();
            for (int i = 0; i < board.Length; i++)
            {
                solution.Add(new string(board[i]));
            }
            solutions.Add(solution);
            return;
        }

        for (int col = 0; col < board.Length; col++)
        {
            if (IsValid(board, row, col))
            {
                board[row][col] = 'Q';
                Backtrack(board, solutions, row + 1);
                board[row][col] = '.';
            }
        }
    }

    private bool IsValid(char[][] board, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            if (board[i][col] == 'Q')
                return false;
            int rowDiff = Math.Abs(row - i);
            int colDiff = Math.Abs(col - Array.IndexOf(board[i], 'Q'));
            if (rowDiff == colDiff)
                return false;
        }
        return true;
    }
}
