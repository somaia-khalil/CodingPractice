## The Mind-Bending Recursive Sequence

You are given an integer `n`. Your task is to implement the function `recursiveSequence` that generates the `n-th` term of a sequence following a peculiar rule.

The sequence is defined as follows:
1. The first term is 1.
2. For any positive integer `k`, the `k-th` term is the sum of the `k` previous terms, excluding any terms that are perfect squares.

Your function should return the `n-th` term of the sequence.

### Example

```js
recursiveSequence(1);
// Output: 1
// The first term is 1.

recursiveSequence(6);
// Output: 11
// The 6th term is calculated as: 1 + 2 + 5 + 10 + 11 = 29. We exclude 4 (2^2) from the sum.

recursiveSequence(10);
// Output: 61
// The 10th term is calculated as: 1 + 2 + 5 + 10 + 11 + 16 + 27 + 38 + 39 + 61 = 210. We exclude 9 (3^2) and 25 (5^2) from the sum.
