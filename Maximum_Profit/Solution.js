
// Solution to the Maximum Profit with K Transactions challenge

function maxProfitWithKTransactions(prices, k) {
  const n = prices.length;

  if (n <= 1 || k === 0) {
    return 0;
  }

  if (k >= n / 2) {
    // If k is greater than or equal to half of the number of days,
    // we can perform unlimited transactions to maximize profit.
    let maxProfit = 0;
    for (let i = 1; i < n; i++) {
      maxProfit += Math.max(0, prices[i] - prices[i - 1]);
    }
    return maxProfit;
  }

  const dp = new Array(k + 1).fill(null).map(() => new Array(n).fill(0));

  for (let i = 1; i <= k; i++) {
    let maxDiff = -prices[0];
    for (let j = 1; j < n; j++) {
      dp[i][j] = Math.max(dp[i][j - 1], prices[j] + maxDiff);
      maxDiff = Math.max(maxDiff, dp[i - 1][j] - prices[j]);
    }
  }

  return dp[k][n - 1];
}

module.exports = maxProfitWithKTransactions;
