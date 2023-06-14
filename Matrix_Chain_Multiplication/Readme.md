## Matrix Chain Multiplication

You are given an array `dims` containing the dimensions of `n` matrices, where the dimensions of the `i-th` matrix are stored as `dims[i] x dims[i + 1]` for `0 <= i < n - 1`.

Your task is to implement the function `matrixChainMultiplication` that finds the minimum number of scalar multiplications needed to multiply all the matrices together.

You can assume that the matrices can be multiplied in any order.

### Example

```js
matrixChainMultiplication([10, 30, 5, 60]);
// Output: 4500
// The matrices can be multiplied as follows:
// (Matrix1 x Matrix2) x (Matrix3 x Matrix4) -> 1500 scalar multiplications
// Matrix1 x (Matrix2 x (Matrix3 x Matrix4)) -> 4500 scalar multiplications
// The second option requires fewer scalar multiplications.

matrixChainMultiplication([5, 10, 3, 12, 5, 50, 6]);
// Output: 2010
// The matrices can be multiplied as follows:
// ((Matrix1 x Matrix2) x (Matrix3 x Matrix4)) x ((Matrix5 x Matrix6) x Matrix7) -> 2010 scalar multiplications
// The above option requires the minimum number of scalar multiplications.
