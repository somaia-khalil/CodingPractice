Coding Challenge: Maximal Rectangle

You are given a 2D binary matrix filled with 0's and 1's. Your task is to write a function to find the area of the largest rectangle containing only 1's.

Matrix Rules:
- The matrix is represented as a 2D array of integers, where 1 represents a cell with a value of 1, and 0 represents an empty cell.
- The rectangle must be formed by connecting adjacent 1's horizontally or vertically.

Write a function that takes the following input:

Input:
- matrix (2D array of integers): A 2D binary matrix filled with 0's and 1's. Each row in the matrix has the same number of columns.

Output:
- int: Returns the area of the largest rectangle containing only 1's.

Function Signature:
public int MaximalRectangle(int[][] matrix)

Example:
Input:
[
  [1, 0, 1, 0, 0],
  [1, 0, 1, 1, 1],
  [1, 1, 1, 1, 1],
  [1, 0, 0, 1, 0]
]

Output: 6 (The largest rectangle containing only 1's is formed by the 1's in the last three rows and the first two columns.)

Notes:
- You may use any programming language to solve the problem.
- Provide test cases to demonstrate the correctness of your solution.
- The function should have an efficient time complexity to handle large matrices.
- The function should be able to find the largest rectangle even in challenging cases with complex shapes.
- There will always be at least one 1 in the matrix, and the matrix will have at least one row and one column.
