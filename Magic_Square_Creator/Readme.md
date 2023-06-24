## Magic Square Creator

A magic square is a square matrix in which the sum of the numbers in each row, column, and both main diagonals is the same. Your task is to implement the function `magicSquareCreator` that takes an integer `n` as input and returns a 2D array representing a magic square of size `n x n`.

### Example

```js
magicSquareCreator(3);
// Output:
// [
//   [2, 9, 4],
//   [7, 5, 3],
//   [6, 1, 8]
// ]

magicSquareCreator(5);
// Output:
// [
//   [17, 24, 1, 8, 15],
//   [23, 5, 7, 14, 16],
//   [4, 6, 13, 20, 22],
//   [10, 12, 19, 21, 3],
//   [11, 18, 25, 2, 9]
// ]
