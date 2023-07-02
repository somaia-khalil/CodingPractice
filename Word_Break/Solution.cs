using System.Collections.Generic;

public class Solution
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        List<string> result = new List<string>();
        WordBreakHelper(s, wordDict, new HashSet<string>(), new List<string>(), result);
        return result;
    }

    private void WordBreakHelper(string s, IList<string> wordDict, HashSet<string> wordSet, List<string> path, List<string> result)
    {
        if (s.Length == 0)
        {
            result.Add(string.Join(" ", path));
            return;
        }

        foreach (string word in wordDict)
        {
            if (s.StartsWith(word) && !wordSet.Contains(word))
            {
                wordSet.Add(word);
                path.Add(word);
                WordBreakHelper(s.Substring(word.Length), wordDict, wordSet, path, result);
                path.RemoveAt(path.Count - 1);
                wordSet.Remove(word);
            }
        }
    }
}
