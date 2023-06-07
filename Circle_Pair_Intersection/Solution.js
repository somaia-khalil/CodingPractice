
// Solution to the Circle Pair Intersection challenge

function circlePairIntersection(circles) {
  function doCirclesIntersect(c1, c2) {
    const [x1, y1, r1] = c1;
    const [x2, y2, r2] = c2;
    const distanceSq = (x1 - x2) ** 2 + (y1 - y2) ** 2;
    const radiusSumSq = (r1 + r2) ** 2;
    return distanceSq < radiusSumSq;
  }

  const n = circles.length;
  let count = 0;

  for (let i = 0; i < n - 1; i++) {
    for (let j = i + 1; j < n; j++) {
      if (doCirclesIntersect(circles[i], circles[j])) {
        count++;
      }
    }
  }

  return count;
}

module.exports = circlePairIntersection;
