Coding Challenge: Palindrome Pairs

You are given a list of unique words. Your task is to write a function that finds all pairs of words in the list that can be concatenated to form a palindrome.

A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).

Input:
- words (string[]): A list of unique words (lowercase alphabets only). The length of the list will not exceed 10^4.

Output:
- palindromePairs (int[][]): A list of pairs represented as integer arrays [i, j], where i and j are the indices of the words in the input list that can be concatenated to form a palindrome.

Example:
Input: words = ["race", "car", "hello", "olleh"]
Output: [[0, 1], [1, 0], [2, 3], [3, 2]]
Explanation: The pairs ["race", "car"] and ["hello", "olleh"] can be concatenated to form palindromes.

Input: words = ["abc", "de", "ed", "cba"]
Output: [[0, 3], [1, 2], [2, 1], [3, 0]]
Explanation: The pairs ["abc", "cba"] and ["de", "ed"] can be concatenated to form palindromes.

Note:
- The order of the elements in the output does not matter.
- Each word in the input list will have a length between 1 and 100.
- You may assume that the input list `words` will not be empty.
