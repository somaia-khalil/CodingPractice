Coding Challenge: Largest Rectangle in Histogram

Given an array `heights` representing the heights of bars in a histogram, find the area of the largest rectangle that can be formed by a continuous sequence of bars in the histogram.

Write a function that takes the following input:

Input:
- heights (List<int>): A list of integers representing the heights of bars in the histogram (1 <= heights.Length <= 10^5).
- Each integer `heights[i]` (0 <= heights[i] <= 10^6) represents the height of the i-th bar.

Output:
- maxArea (int): The area of the largest rectangle that can be formed in the histogram.

Example:
Input: heights = [2, 1, 5, 6, 2, 3]
Output: 10
Explanation: The largest rectangle can be formed by bars with heights [5, 6, 2, 3] and has an area of 10.

Input: heights = [1, 2, 3, 4, 5]
Output: 9
Explanation: The largest rectangle can be formed by bars with heights [3, 4, 5] and has an area of 9.

Notes:
- The width of each bar in the histogram is 1 unit.
- The bars cannot be rotated, and the rectangle formed must have its base on the lower boundary of the histogram (i.e., it must have a base on the x-axis).
- If there are multiple rectangles with the same maximum area, return any one of them.
