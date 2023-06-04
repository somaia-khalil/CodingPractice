
// Solution to The Enigmatic Cipher challenge

function findUniqueSubstring(s) {
  const n = s.length;
  let start = 0;
  let end = 0;
  let maxLength = 0;
  const charCount = new Map();

  while (end < n) {
    const endChar = s[end];
    charCount.set(endChar, (charCount.get(endChar) || 0) + 1);

    while (charCount.get(endChar) > 1) {
      const startChar = s[start];
      charCount.set(startChar, charCount.get(startChar) - 1);
      start++;
    }

    maxLength = Math.max(maxLength, end - start + 1);
    end++;
  }

  return maxLength;
}

function decode(msg, encoded) {
  const n = msg.length;
  let decoded = msg;

  while (true) {
    const maxUniqueLen = findUniqueSubstring(decoded);
    const uniqueSubstr = decoded.substr(0, maxUniqueLen);

    if (encoded.includes(uniqueSubstr)) {
      const encodedSubstr = encoded.substring(
        encoded.indexOf(uniqueSubstr),
        encoded.indexOf(uniqueSubstr) + maxUniqueLen
      );

      decoded = decoded.replace(new RegExp(uniqueSubstr, 'g'), encodedSubstr);
    } else {
      break;
    }
  }

  return decoded;
}

module.exports = decode;
