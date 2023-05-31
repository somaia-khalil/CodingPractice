
// Solution to The Prime Spiral Path challenge

function isPrime(num) {
  if (num < 2) return false;
  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) return false;
  }
  return true;
}

function primeSpiralPath(n) {
  const directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];
  const grid = new Array(n).fill(null).map(() => new Array(n).fill(0));
  let x = Math.floor(n / 2);
  let y = Math.floor(n / 2);
  let direction = 0;
  let num = 1;

  while (num <= n * n) {
    if (isPrime(num)) {
      grid[x][y] = num;
    }

    const nextX = x + directions[direction][0];
    const nextY = y + directions[direction][1];

    if (
      nextX >= 0 &&
      nextX < n &&
      nextY >= 0 &&
      nextY < n &&
      grid[nextX][nextY] === 0
    ) {
      x = nextX;
      y = nextY;
    } else {
      direction = (direction + 1) % 4;
      x += directions[direction][0];
      y += directions[direction][1];
    }

    num++;
  }

  const path = [];
  for (let i = 0; i < n; i++) {
    for (let j = 0; j < n; j++) {
      if (grid[i][j] > 0) {
        path.push([i, j]);
      }
    }
  }

  return path;
}

module.exports = primeSpiralPath;
