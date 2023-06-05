## The Puzzle of Permutations

You are given an array `nums` containing `n` distinct integers. Your task is to implement the function `permutations` that finds all possible permutations of the elements in the array.

A permutation is an arrangement of elements in a specific order. Each permutation should be represented as an array of integers.

Your function should return a list of all valid permutations.

### Example

```js
permutations([1, 2, 3]);
// Output: [[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]]
// The array [1, 2, 3] can be arranged in 6 different orders.

permutations([5, 6, 7, 8]);
// Output: [[5, 6, 7, 8], [5, 6, 8, 7], [5, 7, 6, 8], ... (and many more)]
// The array [5, 6, 7, 8] can be arranged in 24 different orders.
