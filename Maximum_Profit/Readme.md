## Maximum Profit with K Transactions

You are given an array of stock prices for a single stock over a period of `n` days. Your task is to implement the function `maxProfitWithKTransactions` that finds the maximum profit you can obtain by buying and selling the stock at most `k` times.

Each element in the array represents the stock price for that day. You can buy and sell the stock multiple times, but you can't make multiple transactions on the same day.

Your function should return the maximum profit possible.

### Example

```js
maxProfitWithKTransactions([3, 4, 5, 0, 8, 6], 2);
// Output: 10
// Buy on day 1 (price = 4) and sell on day 2 (price = 5) for a profit of 1.
// Buy on day 4 (price = 0) and sell on day 5 (price = 8) for a profit of 8.
// Total profit = 1 + 8 = 10.

maxProfitWithKTransactions([1, 2, 4, 2, 5, 7, 2, 4, 9, 0], 3);
// Output: 13
// Buy on day 1 (price = 2) and sell on day 4 (price = 5) for a profit of 3.
// Buy on day 7 (price = 2) and sell on day 8 (price = 9) for a profit of 7.
// Buy on day 9 (price = 0) and sell on day 10 (price = 0) for a profit of 0.
// Total profit = 3 + 7 + 0 = 13.
