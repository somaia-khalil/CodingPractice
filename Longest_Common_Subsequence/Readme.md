Coding Challenge: Longest Common Subsequence

You are given two strings, `str1` and `str2`. Your task is to write a function that finds the length of the longest common subsequence (LCS) between the two strings.

A subsequence is a sequence of characters that appears in the same order in both strings, but not necessarily consecutively.

For example, given the input strings `str1 = "ABCD"` and `str2 = "ACDF"`, the longest common subsequence is "ACD", and its length is 3.

Input:
- str1 (string): The first input string.
- str2 (string): The second input string.

Output:
- length (int): The length of the longest common subsequence between the two strings.

Example:
Input: str1 = "ABCD", str2 = "ACDF"
Output: 3
Explanation: The longest common subsequence is "ACD", and its length is 3.

Input: str1 = "AGGTAB", str2 = "GXTXAYB"
Output: 4
Explanation: The longest common subsequence is "GTAB", and its length is 4.

Note:
- You may assume that the input strings `str1` and `str2` will contain only uppercase and lowercase letters.
- The length of the input strings will not exceed 1000 characters each.
