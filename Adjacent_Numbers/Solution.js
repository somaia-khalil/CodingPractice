// Solution to the Largest Sum of Non-Adjacent Numbers challenge

function largestNonAdjacentSum(nums) {
  if (!nums || nums.length === 0) {
    return 0;
  }

  const n = nums.length;

  if (n === 1) {
    return Math.max(0, nums[0]);
  }

  let inclusiveSum = Math.max(0, nums[0]);
  let exclusiveSum = 0;

  for (let i = 1; i < n; i++) {
    const temp = inclusiveSum;
    inclusiveSum = Math.max(inclusiveSum, exclusiveSum + nums[i]);
    exclusiveSum = temp;
  }

  return Math.max(inclusiveSum, exclusiveSum);
}

module.exports = largestNonAdjacentSum;
