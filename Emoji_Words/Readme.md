## Emoji Words

You are given a list of words, each represented by an emoji character. Your task is to implement the function `emojiWords` that takes the list of words as input and returns a dictionary containing emojis as keys and a list of words represented by that emoji as values.

### Example

```js
emojiWords(['🍎', '🚗', '🍎🚗', '🚗🍎', '🍎🍎']);
// Output: {
//   '🍎': ['🍎', '🍎🚗', '🚗🍎', '🍎🍎'],
//   '🚗': ['🚗', '🍎🚗', '🚗🍎']
// }
