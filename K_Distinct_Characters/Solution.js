
// Solution to the Longest Substring with At Most K Distinct Characters challenge

function longestSubstringWithKDistinct(s, k) {
  const n = s.length;
  const charCount = new Map();
  let left = 0;
  let maxLen = 0;

  for (let right = 0; right < n; right++) {
    const rightChar = s[right];
    charCount.set(rightChar, (charCount.get(rightChar) || 0) + 1);

    while (charCount.size > k) {
      const leftChar = s[left];
      charCount.set(leftChar, charCount.get(leftChar) - 1);
      if (charCount.get(leftChar) === 0) {
        charCount.delete(leftChar);
      }
      left++;
    }

    maxLen = Math.max(maxLen, right - left + 1);
  }

  return maxLen;
}

module.exports = longestSubstringWithKDistinct;
