
// Solution to the Longest Palindromic Subsequence challenge

function longestPalindromicSubsequence(s) {
  const n = s.length;
  const dp = new Array(n).fill(null).map(() => new Array(n).fill(0));

  for (let i = 0; i < n; i++) {
    dp[i][i] = 1;
  }

  for (let length = 2; length <= n; length++) {
    for (let start = 0; start < n - length + 1; start++) {
      const end = start + length - 1;
      if (s[start] === s[end] && length === 2) {
        dp[start][end] = 2;
      } else if (s[start] === s[end]) {
        dp[start][end] = dp[start + 1][end - 1] + 2;
      } else {
        dp[start][end] = Math.max(dp[start][end - 1], dp[start + 1][end]);
      }
    }
  }

  return dp[0][n - 1];
}

module.exports = longestPalindromicSubsequence;
