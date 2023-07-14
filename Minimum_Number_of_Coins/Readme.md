Coding Challenge: Minimum Number of Coins for Change

You are given an array of positive integers representing different coin denominations, and a target amount. Your task is to write a function that returns the minimum number of coins needed to make up the target amount. If it's impossible to make up the target amount using the given denominations, return -1.

Input:
- denominations (int[]): An array of positive integers representing the coin denominations. You may assume that the array does not contain duplicates, and it is sorted in ascending order.
- targetAmount (int): The target amount that needs to be made up using the coins.

Output:
- minCoins (int): The minimum number of coins needed to make up the target amount. If it's impossible to make up the target amount, return -1.

Example:
Input: denominations = [1, 2, 5], targetAmount = 11
Output: 3
Explanation: The minimum number of coins needed to make up the amount 11 is 3 (1 coin of 5, 2 coins of 2).

Input: denominations = [2, 5, 10], targetAmount = 7
Output: -1
Explanation: It's impossible to make up the amount 7 using the given denominations.

Note:
- You may assume that the targetAmount will be a positive integer greater than or equal to 1.
- You may assume that there will be at least one coin denomination available to make up the target amount.
