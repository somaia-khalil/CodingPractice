
// Solution to the Word Break II challenge

function wordBreak(s, wordDict) {
  const sentences = [];
  const n = s.length;

  function backtrack(start, sentence) {
    if (start === n) {
      sentences.push(sentence.trim());
      return;
    }

    for (const word of wordDict) {
      const len = word.length;
      const nextStart = start + len;

      if (nextStart <= n && s.substr(start, len) === word) {
        backtrack(nextStart, sentence + word + ' ');
      }
    }
  }

  backtrack(0, '');

  return sentences;
}

module.exports = wordBreak;
