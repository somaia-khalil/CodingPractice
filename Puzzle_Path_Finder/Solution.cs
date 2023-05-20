// Solution to The Puzzle Path Finder challenge

using System;
using System.Collections.Generic;

public class Program
{
    public static char[] FindPuzzlePath(char[][] maze)
    {
        int n = maze.Length;
        int m = maze[0].Length;

        int startX = 0;
        int startY = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (maze[i][j] == 'S')
                {
                    startX = i;
                    startY = j;
                }
            }
        }

        List<char> path = new List<char>();
        HashSet<(int, int)> visited = new HashSet<(int, int)>();

        if (FindPath(startX, startY, maze, visited, path))
        {
            return path.ToArray();
        }
        else
        {
            return new char[0];
        }
    }

    public static bool FindPath(int x, int y, char[][] maze, HashSet<(int, int)> visited, List<char> path)
    {
        int n = maze.Length;
        int m = maze[0].Length;

        if (x < 0 || x >= n || y < 0 || y >= m || maze[x][y] == '#' || visited.Contains((x, y)))
        {
            return false;
        }

        if (maze[x][y] == 'G')
        {
            return true;
        }

        visited.Add((x, y));

        if (FindPath(x - 1, y, maze, visited, path))
        {
            path.Add('U');
            return true;
        }
        if (FindPath(x + 1, y, maze, visited, path))
        {
            path.Add('D');
            return true;
        }
        if (FindPath(x, y - 1, maze, visited, path))
        {
            path.Add('L');
            return true;
        }
        if (FindPath(x, y + 1, maze, visited, path))
        {
            path.Add('R');
            return true;
        }

        return false;
    }

    static void Main()
    {
        char[][] maze = new char[][]
        {
            new char[] { '#', 'S', '.', '.', '.', '.' },
            new char[] { '.', '.', '#', '.', '#', '.' },
            new char[] { '.', '#', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '#', '.', '.' },
            new char[] { '.', '#', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '#', 'G' }
        };

        var path = FindPuzzlePath(maze);
        foreach (var move in path)
        {
            Console.Write(move + " ");
        }
    }
}
