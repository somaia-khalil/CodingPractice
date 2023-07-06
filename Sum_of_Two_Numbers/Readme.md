Coding Challenge: Sum of Two Numbers

You are given an array of integers nums and an integer target. Your task is to find two distinct indices i and j such that nums[i] + nums[j] equals the target. Return these indices as an array.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Input:
- nums (int[]): An array of integers containing n elements (2 ≤ n ≤ 10^4).
- target (int): The target sum (−10^9 ≤ target ≤ 10^9).

Output:
- result (int[]): An array containing two distinct indices i and j such that nums[i] + nums[j] equals the target.

Example:
Input: nums = [2, 7, 11, 15], target = 9
Output: [0, 1]
Explanation: nums[0] + nums[1] equals 9 (2 + 7 = 9).

Input: nums = [3, 2, 4], target = 6
Output: [1, 2]
Explanation: nums[1] + nums[2] equals 6 (2 + 4 = 6).

Note:
- You may assume that the input array does not contain any duplicates.
