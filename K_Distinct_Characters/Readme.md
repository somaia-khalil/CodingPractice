## Longest Substring with At Most K Distinct Characters

You are given a string `s` and an integer `k`. Your task is to implement the function `longestSubstringWithKDistinct` that finds the length of the longest substring of `s` containing at most `k` distinct characters.

Your function should return an integer representing the length of the longest valid substring.

### Example

```js
longestSubstringWithKDistinct("eceba", 2);
// Output: 3
// The longest substring with at most 2 distinct characters is "ece".

longestSubstringWithKDistinct("aaabbb", 3);
// Output: 6
// The entire string "aaabbb" has at most 3 distinct characters.

longestSubstringWithKDistinct("abcabcabcabc", 2);
// Output: 6
// The longest substring with at most 2 distinct characters is "abcabc".
