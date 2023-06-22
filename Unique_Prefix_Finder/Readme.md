## Unique Prefix Finder

You are given a list of words. Your task is to implement the function `uniquePrefixFinder` that takes the list of words as input and returns a dictionary containing the words as keys and their unique prefixes as values.

A unique prefix of a word is a prefix that is not a prefix of any other word in the list.

### Example

```js
uniquePrefixFinder(['apple', 'apricot', 'banana', 'bat']);
// Output: {
//   'apple': 'appl',
//   'apricot': 'apri',
//   'banana': 'ban',
//   'bat': 'bat'
// }
