## The Shifting Puzzle Challenge

You are given an n x n grid filled with numbers from 1 to n^2 in increasing order, with one cell missing (represented by 0). The goal is to transform the grid into a target configuration by shifting rows and columns. Each shift operation can be done in either of the following ways:

1. Row Shift: Move all elements in a row one step to the left or right.
2. Column Shift: Move all elements in a column one step up or down.

Write a function `IsPossibleToTarget` that determines if it is possible to transform the initial grid into the target configuration using the allowed shift operations.

### Input:

- `n`: An integer representing the size of the grid (1 <= n <= 4).
- `initial`: A 2-dimensional array representing the initial configuration of the grid.
- `target`: A 2-dimensional array representing the target configuration of the grid.

Both `initial` and `target` configurations will have distinct numbers from 1 to n^2, with one cell containing 0 (representing the missing cell).

### Output:

The function should return a boolean value:
- `true` if it is possible to transform the initial grid into the target configuration using the allowed shift operations.
- `false` otherwise.

### Example:

```csharp
using System;

class Program
{
    static void Main()
    {
        int n = 3;
        int[][] initial = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 0, 5},
            new int[] {6, 7, 8}
        };

        int[][] target = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 0},
            new int[] {6, 7, 8}
        };

        bool isPossible = IsPossibleToTarget(n, initial, target);
        Console.WriteLine(isPossible); // Output: true
    }

    public static bool IsPossibleToTarget(int n, int[][] initial, int[][] target)
    {
        // Implement your solution here
    }
}
