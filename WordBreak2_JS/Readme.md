## Word Break II

You are given a string `s` and a list of words `wordDict`. Your task is to implement the function `wordBreak` that finds all possible sentences formed by breaking the string `s` into words from the given dictionary `wordDict`.

A word break is valid if it can be formed by concatenating the words from `wordDict` in any order and without using any word more than once.

Your function should return a list of all valid sentences formed by word break.

### Example

```js
wordBreak("catsanddog", ["cat", "cats", "and", "sand", "dog"]);
// Output: ["cat sand dog", "cats and dog"]
// The string "catsanddog" can be broken into "cat sand dog" and "cats and dog".

wordBreak("pineapplepenapple", ["apple", "pen", "applepen", "pine", "pineapple"]);
// Output: ["pine apple pen apple", "pineapple pen apple", "pine applepen apple"]
// The string "pineapplepenapple" can be broken into three valid sentences.
