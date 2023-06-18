## Tug of War

You are given an array of positive integers. Your task is to implement the function `tugOfWar` that divides the given array into two subsets, such that the difference between the sums of elements in the two subsets is minimized.

Your function should return an array containing two subsets, each represented by an array of integers.

### Example

```js
tugOfWar([3, 4, 5, 6, 7]);
// Output: [[3, 5, 6], [4, 7]]
// The two subsets have sums of 14 and 11, respectively, with a difference of 3.

tugOfWar([1, 2, 3, 4, 5, 6]);
// Output: [[1, 2, 3, 6], [4, 5]]
// The two subsets have sums of 12 and 9, respectively, with a difference of 3.

tugOfWar([15, 12, 4, 8, 18, 7]);
// Output: [[15, 4, 7], [12, 8, 18]]
// The two subsets have sums of 26 and 38, respectively, with a difference of 12.
