using System;

public class Solution
{
    public string ShortestCommonSupersequence(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        // Initialize the dp array to store the lengths of the shortest common supersequences
        int[,] dp = new int[m + 1, n + 1];

        // Fill the dp array using bottom-up dynamic programming
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0)
                    dp[i, j] = j;
                else if (j == 0)
                    dp[i, j] = i;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                else
                    dp[i, j] = 1 + Math.Min(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        // Reconstruct the shortest common supersequence from the dp array
        int index = dp[m, n];
        char[] scs = new char[index + 1];
        scs[index] = '\0'; // Null-terminate the char array

        int x = m, y = n;
        while (x > 0 && y > 0)
        {
            if (str1[x - 1] == str2[y - 1])
            {
                scs[index - 1] = str1[x - 1];
                x--;
                y--;
                index--;
            }
            else if (dp[x - 1, y] < dp[x, y - 1])
            {
                scs[index - 1] = str1[x - 1];
                x--;
                index--;
            }
            else
            {
                scs[index - 1] = str2[y - 1];
                y--;
                index--;
            }
        }

        // Append the remaining characters from str1 or str2, if any
        while (x > 0)
        {
            scs[index - 1] = str1[x - 1];
            x--;
            index--;
        }

        while (y > 0)
        {
            scs[index - 1] = str2[y - 1];
            y--;
            index--;
        }

        return new string(scs);
    }
}
