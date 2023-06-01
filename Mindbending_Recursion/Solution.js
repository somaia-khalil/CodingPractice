
// Solution to The Mind-Bending Recursive Sequence challenge

function isPerfectSquare(num) {
  const sqrtNum = Math.sqrt(num);
  return Math.floor(sqrtNum) ** 2 === num;
}

function recursiveSequence(n) {
  if (n === 1) {
    return 1;
  }

  let sum = 0;
  let previousTerm = 1;
  let currentTerm = 1;

  for (let i = 2; i <= n; i++) {
    const newTerm = previousTerm + currentTerm;

    if (!isPerfectSquare(newTerm)) {
      sum += newTerm;
    }

    previousTerm = currentTerm;
    currentTerm = newTerm;
  }

  return sum;
}

module.exports = recursiveSequence;
