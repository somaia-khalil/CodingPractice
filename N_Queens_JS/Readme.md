## N-Queens Solver

The N-Queens problem is a classical puzzle in which you are given an N x N chessboard. Your task is to place N queens on the board such that no two queens attack each other.

Queens can attack horizontally, vertically, and diagonally.

Your task is to implement the function `solveNQueens` that takes an integer `n` as input and returns a list of all possible solutions to the N-Queens problem.

Each solution should be represented as an array of strings, where each string represents a row of the chessboard, and 'Q' denotes the position of a queen, and '.' denotes an empty cell.

### Example

```js
solveNQueens(4);
// Output: [
//   [
//     '.Q..',
//     '...Q',
//     'Q...',
//     '..Q.'
//   ],
//   [
//     '..Q.',
//     'Q...',
//     '...Q',
//     '.Q..'
//   ]
// ]
// There are two possible solutions for the 4-Queens problem.

solveNQueens(8);
// Output: [
//   [
//     'Q.......',
//     '....Q...',
//     '.......Q',
//     '...Q....',
//     '.......',
//     '.....Q..',
//     '..Q.....',
//     '.......'
//   ],
//   [
//     'Q.......',
//     '.....Q..',
//     '.......Q',
//     '...Q....',
//     '.......',
//     '.......Q',
//     '..Q.....',
//     '.......'
//   ],
//   ... (other possible solutions)
// ]
// There are multiple possible solutions for the 8-Queens problem.
