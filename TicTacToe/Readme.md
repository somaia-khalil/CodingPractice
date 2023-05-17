## The Ultimate Tic Tac Toe Challenge

You are given a Tic Tac Toe board represented as a 3x3 array. The board is initialized with some X's and O's, and some empty cells.

Your task is to implement the function `PlayUltimateTicTacToe` that allows two players to play the game until it reaches a win, draw, or incomplete state. The game follows the standard rules of Tic Tac Toe, but with a twist:

1. The first player is always X, and the second player is always O.
2. Each move should be a tuple `(row, column)` representing the cell where the current player wants to place their symbol (X or O).
3. The game is played on an "ultimate" board, which consists of nine individual 3x3 Tic Tac Toe boards.
4. A player's move determines the board where the next player must make their move. For example, if player X places their symbol in the top-right cell of the center board, player O must make their move in the board located at the top-right position of the ultimate board.
5. If a player wins a small Tic Tac Toe board (one of the individual 3x3 boards), they "control" that board, and the next player can place their symbol in any open cell of that board.
6. If a player's move sends the next player to a board that is already controlled or has no open cells, the next player can make their move in any open board of the ultimate board.
7. The game continues until one player wins the ultimate board, or the entire ultimate board is filled (draw).

Your function should take the following inputs:

- A 3x3 array representing the current state of the ultimate board. It contains characters 'X' for X's moves, 'O' for O's moves, and ' ' (a space) for empty cells.

The function should return a string indicating the result of the game: "X wins", "O wins", or "Draw".

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        char[][] ultimateBoard = new char[3][]
        {
            new char[] { 'X', ' ', 'O' },
            new char[] { 'O', 'X', 'X' },
            new char[] { ' ', 'O', ' ' }
        };

        string result = PlayUltimateTicTacToe(ultimateBoard);
        Console.WriteLine(result); // Output: "X wins"
    }

    public static string PlayUltimateTicTacToe(char[][] ultimateBoard)
    {
        // Implement your solution here
    }
}
