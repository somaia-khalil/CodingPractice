## The Prime Spiral Path

You are given an integer `n` representing the size of a square grid. Your task is to implement the function `primeSpiralPath` that generates a path on the grid following a spiral pattern.

The path should start at the center of the grid and move in a clockwise spiral pattern towards the outer edges. In each step, you should move to the neighboring cell with the smallest prime number greater than the current position's prime number.

Your function should return a list of coordinates representing the path's order.

### Example

```js
primeSpiralPath(3);
// Output: [[1, 1], [1, 2], [2, 2], [2, 1], [2, 0], [1, 0], [0, 0], [0, 1], [0, 2]]
// The path for a 3x3 grid follows the sequence of smallest prime numbers greater than the current position: 1, 2, 3, 5, 7, 11, 13, 17, 19.

primeSpiralPath(5);
// Output: [[2, 2], [2, 3], [3, 3], [3, 2], [3, 1], [2, 1], [1, 1], [1, 2], [1, 3], [1, 4], [2, 4], [3, 4], [4, 4], [4, 3], [4, 2], [4, 1], [4, 0], [3, 0], [2, 0], [1, 0], [0, 0], [0, 1], [0, 2], [0, 3], [0, 4]]
// The path for a 5x5 grid follows the sequence of smallest prime numbers greater than the current position: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97.
