Coding Challenge: Word Break II

Given a non-empty string `s` and a dictionary of non-empty words `wordDict`, find all possible word break arrangements of the string `s` using the words from the dictionary.

Write a function that takes the following input:

Input:
- s (string): The non-empty string to be broken (1 <= s.Length <= 300).
- wordDict (List<string>): A list of non-empty words that can be used for word breaking (1 <= wordDict.Length <= 1000).
- Each word `wordDict[i]` (1 <= wordDict[i].Length <= 20) is a valid English word without any leading or trailing spaces.

Output:
- List<string>: A list of all possible word break arrangements of the string `s`. Each arrangement is formed by concatenating words from the dictionary and separating them with a single space. The order of arrangements in the output list does not matter.

Example:
Input: s = "catsanddog", wordDict = ["cat", "cats", "and", "sand", "dog"]
Output: ["cat sand dog", "cats and dog"]
Explanation: The string "catsanddog" can be broken into two valid sentences: "cat sand dog" and "cats and dog".

Input: s = "pineapplepenapple", wordDict = ["apple", "pen", "applepen", "pine", "pineapple"]
Output: ["pine apple pen apple", "pineapple pen apple", "pine applepen apple"]
Explanation: The string "pineapplepenapple" can be broken into three valid sentences: "pine apple pen apple", "pineapple pen apple", and "pine applepen apple".

Notes:
- You may assume that the dictionary does not contain duplicate words.
- The same word in the dictionary may be reused multiple times in the word break arrangement.
- The words in the output should be separated by a single space.
- If there are no possible word break arrangements, return an empty list.
