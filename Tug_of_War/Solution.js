
// Solution to the Tug of War challenge

function tugOfWar(nums) {
  const n = nums.length;
  const totalSum = nums.reduce((sum, num) => sum + num, 0);

  const dp = new Array(n + 1).fill(null).map(() => new Array(totalSum + 1).fill(false));

  for (let i = 0; i <= n; i++) {
    dp[i][0] = true;
  }

  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= totalSum; j++) {
      dp[i][j] = dp[i - 1][j];
      if (nums[i - 1] <= j) {
        dp[i][j] = dp[i][j] || dp[i - 1][j - nums[i - 1]];
      }
    }
  }

  let halfSum = Math.floor(totalSum / 2);
  while (!dp[n][halfSum]) {
    halfSum--;
  }

  const subset1 = [];
  let i = n;
  let sum1 = halfSum;
  while (i > 0 && sum1 >= 0) {
    if (dp[i - 1][sum1]) {
      i--;
    } else {
      subset1.push(nums[i - 1]);
      sum1 -= nums[i - 1];
      i--;
    }
  }

  const subset2 = nums.filter((num) => !subset1.includes(num));

  return [subset1, subset2];
}

module.exports = tugOfWar;
