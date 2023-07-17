using System;

public class Solution
{
    public int MaximalRectangle(int[][] matrix)
    {
        int m = matrix.Length;
        if (m == 0) return 0;

        int n = matrix[0].Length;
        int[] heights = new int[n];
        int maxArea = 0;

        for (int i = 0; i < m; i++)
        {
            // Update the heights array based on the current row of 1's
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                    heights[j] = 0;
                else
                    heights[j]++;
            }

            // Calculate the maximum area of the rectangle containing only 1's in the current row
            maxArea = Math.Max(maxArea, LargestRectangleArea(heights));
        }

        return maxArea;
    }

    private int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int[] stack = new int[n + 1]; // Use a stack to store the indices of increasing heights
        int top = -1;
        int maxArea = 0;

        for (int i = 0; i <= n; i++)
        {
            // Get the height of the current bar (heights[i] for i < n, and 0 for i = n)
            int height = (i == n) ? 0 : heights[i];

            // While the current height is less than the height at the top of the stack, calculate the area
            while (top >= 0 && height < heights[stack[top]])
            {
                int h = heights[stack[top]];
                top--;

                // Calculate the width of the rectangle (width = i - stack[top] - 1)
                int width = (top < 0) ? i : (i - stack[top] - 1);

                // Calculate the area of the rectangle and update the maximum area
                maxArea = Math.Max(maxArea, h * width);
            }

            // Push the current index to the stack
            top++;
            stack[top] = i;
        }

        return maxArea;
    }
}
