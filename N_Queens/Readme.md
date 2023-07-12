Coding Challenge: N-Queens Problem

The N-Queens problem is a classic puzzle of placing N queens on an N x N chessboard such that no two queens threaten each other. A queen can move horizontally, vertically, and diagonally on the chessboard.

Your task is to write a function that takes an integer N as input and returns all possible solutions to the N-Queens problem.

Input:
- N (int): An integer representing the size of the chessboard and the number of queens to be placed.

Output:
- result (List[List[str]]): A list of lists, where each list represents a valid solution to the N-Queens problem. Each element in the list represents a row in the chessboard, and the character 'Q' represents the queen, while '.' represents an empty cell.

Example:
Input: 4
Output: [
    [".Q..", "...Q", "Q...", "..Q."],
    ["..Q.", "Q...", "...Q", ".Q.."]
]

Note:
- The input N will be a positive integer greater than or equal to 1.
- You may assume that there will be at least one valid solution for each N.
