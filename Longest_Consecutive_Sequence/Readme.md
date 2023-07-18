Coding Challenge: Longest Consecutive Sequence

You are given an unsorted array of integers. Your task is to write a function that finds the longest consecutive sequence of elements in the array.

A consecutive sequence is a sequence of numbers where each number appears exactly once and follows the previous number in the array.

Input:
- nums (int[]): An unsorted array of integers.

Output:
- longestSequence (int): The length of the longest consecutive sequence found in the array.

Example:
Input: nums = [100, 4, 200, 1, 3, 2]
Output: 4
Explanation: The longest consecutive sequence is [1, 2, 3, 4], which has a length of 4.

Input: nums = [9, 1, 4, 7, 3, 2, 5, 8, 6]
Output: 9
Explanation: The longest consecutive sequence is [1, 2, 3, 4, 5, 6, 7, 8, 9], which has a length of 9.

Note:
- The elements in the input array `nums` may not be distinct.
- You may assume that the input array `nums` will not be empty.
- The length of the input array will not exceed 10^5.
