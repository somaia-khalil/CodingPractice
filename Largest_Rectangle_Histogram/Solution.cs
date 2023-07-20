using System;
using System.Collections.Generic;

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int maxArea = 0;

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && heights[i] < heights[stack.Peek()])
            {
                int height = heights[stack.Pop()];
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, height * width);
            }

            stack.Push(i);
        }

        while (stack.Count > 0)
        {
            int height = heights[stack.Pop()];
            int width = stack.Count == 0 ? n : n - stack.Peek() - 1;
            maxArea = Math.Max(maxArea, height * width);
        }

        return maxArea;
    }
}
