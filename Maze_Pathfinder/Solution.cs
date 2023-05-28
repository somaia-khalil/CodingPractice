// Solution to The Maze Path Finder - C# Edition challenge

using System;
using System.Collections.Generic;

public class Program
{
    public static List<int[]> FindPath(int[][] maze)
    {
        int n = maze.Length;
        int m = maze[0].Length;
        bool[,] visited = new bool[n, m];

        List<int[]> path = new List<int[]>();
        DFS(maze, 0, 0, n - 1, m - 1, visited, path);

        return path;
    }

    public static bool IsValidMove(int[][] maze, int x, int y, bool[,] visited)
    {
        int n = maze.Length;
        int m = maze[0].Length;

        return x >= 0 && x < n && y >= 0 && y < m && maze[x][y] == 0 && !visited[x, y];
    }

    public static bool DFS(int[][] maze, int x, int y, int destX, int destY, bool[,] visited, List<int[]> path)
    {
        if (x == destX && y == destY)
        {
            path.Add(new int[] { x, y });
            return true;
        }

        if (IsValidMove(maze, x, y, visited))
        {
            visited[x, y] = true;
            path.Add(new int[] { x, y });

            if (DFS(maze, x + 1, y, destX, destY, visited, path) ||
                DFS(maze, x - 1, y, destX, destY, visited, path) ||
                DFS(maze, x, y + 1, destX, destY, visited, path) ||
                DFS(maze, x, y - 1, destX, destY, visited, path))
            {
                return true;
            }

            path.RemoveAt(path.Count - 1);
            visited[x, y] = false;
        }

        return false;
    }

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
        foreach (var point in path)
        {
            Console.Write($"[{point[0]}, {point[1]}] ");
        }
    }
}
