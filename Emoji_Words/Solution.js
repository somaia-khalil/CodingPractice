
// Solution to the Emoji Words challenge

function emojiWords(words) {
  const emojiMap = {};

  for (const word of words) {
    for (const emoji of word) {
      if (emoji in emojiMap) {
        emojiMap[emoji].push(word);
      } else {
        emojiMap[emoji] = [word];
      }
    }
  }

  return emojiMap;
}

module.exports = emojiWords;
