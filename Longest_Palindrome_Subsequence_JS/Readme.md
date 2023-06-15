## Longest Palindromic Subsequence

You are given a string `s`. Your task is to implement the function `longestPalindromicSubsequence` that finds the length of the longest palindromic subsequence in the given string.

A subsequence is a sequence of characters obtained by deleting zero or more characters from the original string, without changing the relative order of the remaining characters.

A palindromic subsequence is a subsequence that reads the same forward and backward.

Your function should return the length of the longest palindromic subsequence.

### Example

```js
longestPalindromicSubsequence("banana");
// Output: 5
// The longest palindromic subsequence is "anana" with a length of 5.

longestPalindromicSubsequence("babad");
// Output: 3
// The longest palindromic subsequence is "bab" or "aba" with a length of 3.
