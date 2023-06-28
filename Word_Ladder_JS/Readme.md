## Word Ladder

Given two words, `beginWord` and `endWord`, and a dictionary of words, find the length of the shortest transformation sequence from `beginWord` to `endWord`.

A transformation sequence consists of changing one character at a time in the word to create a new word, and all the intermediate words must exist in the dictionary. Each transformation step has a cost of 1.

Your task is to implement the function `wordLadder` that takes `beginWord`, `endWord`, and a dictionary of words as input, and returns the minimum number of steps required to transform `beginWord` into `endWord`. If it's not possible to form the transformation sequence, return -1.

### Example

```js
wordLadder("hit", "cog", ["hot", "dot", "dog", "lot", "log", "cog"]); // Output: 5
wordLadder("a", "b", ["c", "b", "a"]);                              // Output: 2
wordLadder("hot", "dog", ["hot", "dog"]);                           // Output: 0
