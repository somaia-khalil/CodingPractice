// Solution to the Matrix Chain Multiplication challenge

function matrixChainMultiplication(dims) {
  const n = dims.length - 1;
  const dp = new Array(n).fill(null).map(() => new Array(n).fill(0));

  for (let len = 2; len <= n; len++) {
    for (let i = 0; i < n - len + 1; i++) {
      const j = i + len - 1;
      dp[i][j] = Number.MAX_SAFE_INTEGER;
      for (let k = i; k < j; k++) {
        const cost = dp[i][k] + dp[k + 1][j] + dims[i] * dims[k + 1] * dims[j + 1];
        dp[i][j] = Math.min(dp[i][j], cost);
      }
    }
  }

  return dp[0][n - 1];
}

module.exports = matrixChainMultiplication;
