using System;
using System.Collections.Generic;

public class Solution
{
    public int MinimumOperations(string initialString, string targetString)
    {
        if (initialString.Length != targetString.Length)
            return -1;

        int n = initialString.Length;
        int minOperations = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                for (int k = 1; k <= n; k++)
                {
                    string transformedString = TransformString(initialString, i, j, k);
                    if (transformedString == targetString)
                    {
                        int operations = CountOperations(i, j, k);
                        minOperations = Math.Min(minOperations, operations);
                    }
                }
            }
        }

        return (minOperations == int.MaxValue) ? -1 : minOperations;
    }

    private string TransformString(string str, int reverseStart, int reverseEnd, int shiftPositions)
    {
        char[] chars = str.ToCharArray();

        // Reverse the string
        Array.Reverse(chars, reverseStart, reverseEnd - reverseStart + 1);

        // Shift the string
        Reverse(chars, 0, shiftPositions - 1);
        Reverse(chars, shiftPositions, str.Length - 1);
        Reverse(chars, 0, str.Length - 1);

        return new string(chars);
    }

    private void Reverse(char[] arr, int start, int end)
    {
        while (start < end)
        {
            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    private int CountOperations(int reverseStart, int reverseEnd, int shiftPositions)
    {
        int operations = 0;

        if (reverseStart != reverseEnd)
            operations++; // Reverse operation

        if (shiftPositions != 0)
            operations++; // Shift operation

        if (reverseStart != reverseEnd && shiftPositions != 0)
            operations++; // Swap operation

        return operations;
    }
}
