
// Solution to the Combinations with Target Sum challenge

function combinationsWithTargetSum(nums, target) {
  const combinations = [];

  function backtrack(start, currentSum, currentCombination) {
    if (currentSum === target) {
      combinations.push([...currentCombination]);
      return;
    }

    if (currentSum > target || start === nums.length) {
      return;
    }

    for (let i = start; i < nums.length; i++) {
      currentCombination.push(nums[i]);
      backtrack(i, currentSum + nums[i], currentCombination);
      currentCombination.pop();
    }
  }

  backtrack(0, 0, []);

  return combinations;
}

module.exports = combinationsWithTargetSum;
