
// Solution to the Largest Subarray with Equal 0s and 1s challenge

function largestEqualSubarray(nums) {
  const n = nums.length;
  const prefixSumMap = new Map();
  prefixSumMap.set(0, -1);

  let maxLen = 0;
  let count = 0;
  let start = -1;
  let end = -1;

  for (let i = 0; i < n; i++) {
    count += nums[i] === 1 ? 1 : -1;

    if (prefixSumMap.has(count)) {
      if (i - prefixSumMap.get(count) > maxLen) {
        maxLen = i - prefixSumMap.get(count);
        start = prefixSumMap.get(count) + 1;
        end = i;
      }
    } else {
      prefixSumMap.set(count, i);
    }
  }

  return [start, end];
}

module.exports = largestEqualSubarray;
