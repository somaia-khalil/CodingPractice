## Largest Subarray with Equal 0s and 1s

You are given an array of integers containing only 0s and 1s. Your task is to implement the function `largestEqualSubarray` that finds the largest contiguous subarray with an equal number of 0s and 1s.

Your function should return the starting and ending indices of the largest subarray that meets the requirement.

### Example

```js
largestEqualSubarray([0, 1, 1, 0, 1, 0, 1]);
// Output: [1, 6]
// The subarray [1, 1, 0, 1, 0, 1] has an equal number of 0s and 1s.

largestEqualSubarray([0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1]);
// Output: [3, 10]
// The subarray [0, 0, 1, 1, 0, 0, 1, 1, 1] has an equal number of 0s and 1s.

largestEqualSubarray([1, 0, 1, 0, 1]);
// Output: [0, 1]
// The subarray [1, 0] has an equal number of 0s and 1s.

largestEqualSubarray([1, 1, 1, 0, 0, 0]);
// Output: [0, 2] or [1, 3] or [2, 4]
// There are multiple subarrays with an equal number of 0s and 1s.
