## Combinations with Target Sum

You are given a list of positive integers `nums` and a target integer `target`. Your task is to implement the function `combinationsWithTargetSum` that finds all possible combinations of elements from the list `nums` that add up to the target.

Each combination should be represented as an array of integers, and the elements in the combination can be used multiple times if needed.

Your function should return a list of all valid combinations.

### Example

```js
combinationsWithTargetSum([2, 3, 5], 8);
// Output: [[2, 2, 2, 2], [2, 3, 3], [3, 5]]
// The target sum is 8, and the possible combinations are [2, 2, 2, 2], [2, 3, 3], and [3, 5].

combinationsWithTargetSum([1, 2, 3, 4, 5], 7);
// Output: [[1, 1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 2], [1, 1, 1, 2, 2], [1, 1, 2, 2, 1], [1, 2, 2, 2], [1, 1, 1, 1, 3], ...]
// The target sum is 7, and there are multiple possible combinations.
