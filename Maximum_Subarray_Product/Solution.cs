using System;

public class Solution
{
    public int MaxProductSubarray(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            throw new ArgumentException("The input array is empty.");

        int n = nums.Length;
        int maxProduct = nums[0];
        int currentMax = nums[0];
        int currentMin = nums[0];

        for (int i = 1; i < n; i++)
        {
            if (nums[i] < 0)
            {
                int temp = currentMax;
                currentMax = currentMin;
                currentMin = temp;
            }

            currentMax = Math.Max(nums[i], currentMax * nums[i]);
            currentMin = Math.Min(nums[i], currentMin * nums[i]);

            maxProduct = Math.Max(maxProduct, currentMax);
        }

        return maxProduct;
    }
}
