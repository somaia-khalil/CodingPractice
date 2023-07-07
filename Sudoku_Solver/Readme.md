Coding Challenge: Sudoku Solver

Write a function to solve a Sudoku puzzle.

Sudoku is a logic-based number placement puzzle. The objective is to fill a 9x9 grid with digits so that each column, each row, and each of the nine 3x3 subgrids that compose the grid contains all of the digits from 1 to 9.

Your task is to write a function that takes a 9x9 Sudoku puzzle board as input, where the empty cells are represented by '.' and filled cells are represented by digits 1 to 9, and return the solved Sudoku board.

Input:
- board (char[][]): A 9x9 Sudoku puzzle board represented as a 2D array of characters.

Output:
- result (char[][]): The solved Sudoku board.

Example:
Input:
board = [    ["5","3",".",".","7",".",".",".","."],
    ["6",".",".","1","9","5",".",".","."],
    [".","9","8",".",".",".",".","6","."],
    ["8",".",".",".","6",".",".",".","3"],
    ["4",".",".","8",".","3",".",".","1"],
    ["7",".",".",".","2",".",".",".","6"],
    [".","6",".",".",".",".","2","8","."],
    [".",".",".","4","1","9",".",".","5"],
    [".",".",".",".","8",".",".","7","9"]
]

Output:
result = [    ["5","3","4","6","7","8","9","1","2"],
    ["6","7","2","1","9","5","3","4","8"],
    ["1","9","8","3","4","2","5","6","7"],
    ["8","5","9","7","6","1","4","2","3"],
    ["4","2","6","8","5","3","7","9","1"],
    ["7","1","3","9","2","4","8","5","6"],
    ["9","6","1","5","3","7","2","8","4"],
    ["2","8","7","4","1","9","6","3","5"],
    ["3","4","5","2","8","6","1","7","9"]
]

Note:
- The input board will always have a valid solution.
- You may assume that there will be only one unique solution for each puzzle.
- The input board will have a size of 9x9 (9 rows and 9 columns).
