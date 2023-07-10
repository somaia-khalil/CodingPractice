using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> FindPalindromePairs(string[] words)
    {
        IList<IList<int>> palindromePairs = new List<IList<int>>();
        Dictionary<string, int> wordIndexMap = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            wordIndexMap[ReverseString(words[i])] = i;
        }

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            int wordLen = word.Length;

            for (int j = 0; j <= wordLen; j++)
            {
                string left = word.Substring(0, j);
                string right = word.Substring(j);

                if (IsPalindrome(left) && wordIndexMap.ContainsKey(right) && wordIndexMap[right] != i)
                {
                    palindromePairs.Add(new List<int> { wordIndexMap[right], i });
                }

                if (j != wordLen && IsPalindrome(right) && wordIndexMap.ContainsKey(left) && wordIndexMap[left] != i)
                {
                    palindromePairs.Add(new List<int> { i, wordIndexMap[left] });
                }
            }
        }

        return palindromePairs;
    }

    private string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}
