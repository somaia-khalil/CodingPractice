function wordLadder(beginWord, endWord, wordList) {
  const wordSet = new Set(wordList);
  if (!wordSet.has(endWord)) return -1;

  const queue = [];
  queue.push(beginWord);
  let steps = 0;

  while (queue.length > 0) {
    const size = queue.length;

    for (let i = 0; i < size; i++) {
      const word = queue.shift();
      if (word === endWord) return steps;

      for (let j = 0; j < word.length; j++) {
        for (let k = 97; k <= 122; k++) {
          const newWord = word.slice(0, j) + String.fromCharCode(k) + word.slice(j + 1);
          if (wordSet.has(newWord)) {
            queue.push(newWord);
            wordSet.delete(newWord);
          }
        }
      }
    }

    steps++;
  }

  return -1;
}

module.exports = wordLadder;
