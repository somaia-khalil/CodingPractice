// Solution to The Performance-Critical Challenge

using System;
using System.Collections.Generic;
using System.Linq;

public class SentenceProcessor
{
    private List<string> Sentences;

    public SentenceProcessor(List<string> sentences)
    {
        Sentences = sentences;
    }

    public string LongestSentence()
    {
        string longestSentence = string.Empty;
        int maxWords = 0;

        foreach (string sentence in Sentences)
        {
            string[] words = sentence.Split(' ');
            int wordCount = words.Length;

            if (wordCount > maxWords)
            {
                maxWords = wordCount;
                longestSentence = sentence;
            }
        }

        return longestSentence;
    }

    public int CountOccurrences(string word)
    {
        int occurrences = 0;

        foreach (string sentence in Sentences)
        {
            string[] words = sentence.Split(' ');
            occurrences += words.Count(w => w == word);
        }

        return occurrences;
    }

    public List<string> MostFrequentWords(int k)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        foreach (string sentence in Sentences)
        {
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }
        }

        return wordFrequency.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).Take(k).ToList();
    }

    public int DistinctWordCount()
    {
        HashSet<string> uniqueWords = new HashSet<string>();

        foreach (string sentence in Sentences)
        {
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                uniqueWords.Add(word);
            }
        }

        return uniqueWords.Count;
    }
}
