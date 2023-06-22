// Solution to the Unique Prefix Finder challenge

function uniquePrefixFinder(words) {
  const prefixMap = {};

  for (const word of words) {
    let prefix = '';
    for (let i = 1; i <= word.length; i++) {
      prefix = word.slice(0, i);
      if (!words.some((w) => w !== word && w.startsWith(prefix))) {
        break;
      }
    }

    prefixMap[word] = prefix;
  }

  return prefixMap;
}

module.exports = uniquePrefixFinder;
