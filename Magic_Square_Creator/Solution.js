// Solution to the Magic Square Creator challenge

function magicSquareCreator(n) {
  const square = new Array(n).fill(null).map(() => new Array(n).fill(0));
  const total = (n * (n * n + 1)) / 2;

  let num = 1;
  let row = 0;
  let col = Math.floor(n / 2);

  while (num <= n * n) {
    square[row][col] = num;

    const nextRow = (row - 1 + n) % n;
    const nextCol = (col + 1) % n;

    if (square[nextRow][nextCol] === 0) {
      row = nextRow;
      col = nextCol;
    } else {
      row = (row + 1) % n;
    }

    num++;
  }

  return square;
}

module.exports = magicSquareCreator;
