using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int left = 0;
        int right = 0;
        HashSet<char> charSet = new HashSet<char>();

        while (right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }

        return maxLength;
    }
}
