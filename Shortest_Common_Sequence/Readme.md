Coding Challenge: Shortest Common Supersequence

Given two strings `str1` and `str2`, your task is to find the shortest string that has both `str1` and `str2` as subsequences. In other words, you need to find the shortest string that contains both `str1` and `str2` as sub-sequences in the same order but not necessarily consecutively.

Write a function that takes the following inputs:

Input:
- str1 (string): The first input string (1 <= len(str1) <= 1000).
- str2 (string): The second input string (1 <= len(str2) <= 1000).

Output:
- shortestSupersequence (string): The shortest common supersequence of `str1` and `str2`.

Example:
Input: str1 = "ABABC", str2 = "BABC"
Output: "ABABCB"
Explanation: The shortest common supersequence is "ABABCB" since it contains both "ABABC" and "BABC" as subsequences.

Input: str1 = "AGGTAB", str2 = "GXTXAYB"
Output: "AGGXTXAYB"
Explanation: The shortest common supersequence is "AGGXTXAYB" since it contains both "AGGTAB" and "GXTXAYB" as subsequences.

Notes:
- The output should be case-sensitive, i.e., it should maintain the same case as the input strings.
- If there are multiple valid shortest common supersequences, return any one of them.
