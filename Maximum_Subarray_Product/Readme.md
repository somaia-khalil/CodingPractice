Coding Challenge: Maximum Subarray Product

Given an array of integers, find the contiguous subarray with the maximum product.

Write a function that takes the following input:

Input:
- nums (int[]): An array of integers. The array can have both positive and negative integers (-10^9 <= nums[i] <= 10^9).
- The length of the array nums is between 1 and 10^5.

Output:
- int: The maximum product of a contiguous subarray in the given array.

Example:
Input: nums = [2, 3, -2, 4]
Output: 6
Explanation: The contiguous subarray [2, 3] has the maximum product of 6.

Input: nums = [-2, 0, -1]
Output: 0
Explanation: The contiguous subarray [-2, 0, -1] has the maximum product of 0.

Notes:
- Your solution should have a time complexity of O(n), where n is the number of elements in the array nums.
- Your solution should have a space complexity of O(1).
- The maximum product can be negative, zero, or positive.
- The contiguous subarray must contain at least one element.
