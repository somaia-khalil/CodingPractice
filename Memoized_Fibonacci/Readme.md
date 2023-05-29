## The Memoized Fibonacci Sequence

You are given an integer `n`. Your task is to implement the function `fibonacci` that calculates the `n-th` term of the Fibonacci sequence using memoization to optimize the computation.

The Fibonacci sequence is defined as follows:
- The first term is 0.
- The second term is 1.
- The `k-th` term is the sum of the `k-1-th` and `k-2-th` terms.

Your function should return the `n-th` term of the Fibonacci sequence.

### Example

```js
fibonacci(5);
// Output: 5
// The 5th term of the Fibonacci sequence is 5 (0, 1, 1, 2, 3, 5).

fibonacci(10);
// Output: 55
// The 10th term of the Fibonacci sequence is 55 (0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55).
