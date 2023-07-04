Coding Challenge: Trapping Rain Water

You are given an array of non-negative integers representing the heights of walls. Each element in the array represents the height of a wall of unit width. Your task is to write a function that calculates the total amount of rainwater that can be trapped between the walls.

Input:
- heights (int[]): An array of non-negative integers representing the heights of walls. You may assume that the array contains at least three elements.

Output:
- totalWater (int): The total amount of rainwater that can be trapped between the walls.

Example:
Input: heights = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]
Output: 6
Explanation: The total amount of rainwater that can be trapped between the walls is 6 units. Water is trapped at indices 2, 4, 5, 6, 8, and 10.

Input: heights = [4, 2, 0, 3, 2, 5]
Output: 9
Explanation: The total amount of rainwater that can be trapped between the walls is 9 units. Water is trapped at indices 2, 3, 4, and 5.

Note:
- You may assume that the input array `heights` will contain only non-negative integers.
- The length of the input array will not exceed 10^4.
