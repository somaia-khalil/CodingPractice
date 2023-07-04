public class Solution
{
    public int TrapRainWater(int[] heights)
    {
        int n = heights.Length;
        if (n < 3) return 0;

        int[] leftMax = new int[n];
        int[] rightMax = new int[n];
        int totalWater = 0;

        leftMax[0] = heights[0];
        for (int i = 1; i < n; i++)
        {
            leftMax[i] = Math.Max(leftMax[i - 1], heights[i]);
        }

        rightMax[n - 1] = heights[n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            rightMax[i] = Math.Max(rightMax[i + 1], heights[i]);
        }

        for (int i = 1; i < n - 1; i++)
        {
            int trappedWater = Math.Min(leftMax[i], rightMax[i]) - heights[i];
            if (trappedWater > 0)
            {
                totalWater += trappedWater;
            }
        }

        return totalWater;
    }
}
