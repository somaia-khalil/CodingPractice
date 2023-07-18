using System;
using System.Collections.Generic;

public class Solution
{
    public int LongestConsecutiveSequence(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestSequence = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentSequence = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentSequence++;
                }

                longestSequence = Math.Max(longestSequence, currentSequence);
            }
        }

        return longestSequence;
    }
}
