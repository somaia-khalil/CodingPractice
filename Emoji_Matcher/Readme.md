## Text Emoji Matcher

You are given a list of text messages, each containing a combination of emojis. Your task is to implement the function `emojiMatcher` that takes the list of messages as input and returns a dictionary containing emojis as keys and the number of occurrences of each emoji as values.

### Example

```js
emojiMatcher([
  'I love 🍕 and 🍦!',
  'Having a great time with friends! 😃🎉',
  'Feeling sick today 🤒😢'
]);
// Output: {
//   '🍕': 1,
//   '🍦': 1,
//   '😃': 1,
//   '🎉': 1,
//   '🤒': 1,
//   '😢': 1
// }
