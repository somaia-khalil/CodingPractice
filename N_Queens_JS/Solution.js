
// Solution to the N-Queens Solver challenge

function solveNQueens(n) {
  const solutions = [];

  function isSafe(board, row, col) {
    // Check if there is a queen in the same column
    for (let i = 0; i < row; i++) {
      if (board[i][col] === 'Q') {
        return false;
      }
    }

    // Check if there is a queen in the left diagonal
    for (let i = row, j = col; i >= 0 && j >= 0; i--, j--) {
      if (board[i][j] === 'Q') {
        return false;
      }
    }

    // Check if there is a queen in the right diagonal
    for (let i = row, j = col; i >= 0 && j < n; i--, j++) {
      if (board[i][j] === 'Q') {
        return false;
      }
    }

    return true;
  }

  function backtrack(board, row) {
    if (row === n) {
      const solution = board.map((row) => row.join(''));
      solutions.push(solution);
      return;
    }

    for (let col = 0; col < n; col++) {
      if (isSafe(board, row, col)) {
        board[row][col] = 'Q';
        backtrack(board, row + 1);
        board[row][col] = '.';
      }
    }
  }

  const emptyBoard = new Array(n).fill(null).map(() => new Array(n).fill('.'));
  backtrack(emptyBoard, 0);

  return solutions;
}

module.exports = solveNQueens;
