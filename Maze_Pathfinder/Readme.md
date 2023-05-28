## The Maze Path Finder - C# Edition

You are given a maze represented as a 2D array `maze` where 0 represents an empty cell and 1 represents an obstacle. The maze is surrounded by walls.

Your task is to implement the function `FindPath` that finds a path from the top-left corner of the maze (cell [0, 0]) to the bottom-right corner (cell [n-1, m-1]), if one exists. A valid path can only move horizontally or vertically, and cannot cross through obstacles.

Your function should return a list of coordinates representing the path from the start to the end. If no path is found, return an empty list.

### Example

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[][] maze = new int[][]
        {
            new int[] { 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 1 },
            new int[] { 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 0 }
        };

        List<int[]> path = FindPath(maze);
        // Output: [[0, 0], [1, 0], [2, 0], [2, 1], [3, 1], [3, 2], [3, 3]]
        // A valid path from (0, 0) to (3, 3) is found.
    }

    public static List<int[]> FindPath(int[][] maze)
    {
        // Implement your solution here
    }
}
