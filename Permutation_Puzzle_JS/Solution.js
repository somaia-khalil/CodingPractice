
// Solution to The Puzzle of Permutations challenge

function permutations(nums) {
  const n = nums.length;
  const used = new Array(n).fill(false);
  const currentPerm = [];
  const permutationsList = [];

  function backtrack() {
    if (currentPerm.length === n) {
      permutationsList.push([...currentPerm]);
      return;
    }

    for (let i = 0; i < n; i++) {
      if (!used[i]) {
        used[i] = true;
        currentPerm.push(nums[i]);
        backtrack();
        currentPerm.pop();
        used[i] = false;
      }
    }
  }

  backtrack();

  return permutationsList;
}

module.exports = permutations;
