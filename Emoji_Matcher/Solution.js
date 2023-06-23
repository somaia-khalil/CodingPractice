
// Solution to the Text Emoji Matcher challenge

function emojiMatcher(messages) {
  const emojiMap = {};

  for (const message of messages) {
    const emojis = message.match(/[\uD800-\uDBFF][\uDC00-\uDFFF]|\p{Emoji_Presentation}/gu);
    
    for (const emoji of emojis) {
      if (emoji in emojiMap) {
        emojiMap[emoji]++;
      } else {
        emojiMap[emoji] = 1;
      }
    }
  }

  return emojiMap;
}

module.exports = emojiMatcher;
