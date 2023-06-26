## Matrix Spiral Traversal

Given a matrix of m x n elements (m rows, n columns), write a function `spiralTraversal` to traverse the matrix in a spiral order (clockwise).

Your task is to implement the function `spiralTraversal` that takes the matrix as input and returns a one-dimensional array containing the elements visited in spiral order.

### Example

```js
spiralTraversal([  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9]
]);
// Output: [1, 2, 3, 6, 9, 8, 7, 4, 5]

spiralTraversal([
  [1, 2, 3, 4],
  [5, 6, 7, 8],
  [9, 10, 11, 12]
]);
// Output: [1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7]
