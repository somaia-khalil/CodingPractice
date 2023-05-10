// Solution to The Shifting Puzzle Challenge

using System;

public class Program
{
    public static bool IsPossibleToTarget(int n, int[][] initial, int[][] target)
    {
        // Implement your solution here to check if it is possible to transform the initial grid into the target configuration.

        return false;
    }

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
        Console.WriteLine(isPossible);
    }
}
