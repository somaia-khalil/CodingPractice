// Solution to The LINQ Expression Explorer challenge

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static (int, int, int, int, string) ExploreData(List<int> numbers, List<string> strings)
    {
        var evenSum = numbers.Where(n => n % 2 == 0).Sum();
        var oddProduct = numbers.Where(n => n % 2 != 0).Aggregate(1, (acc, n) => acc * n);
        var countGreaterThanFive = strings.Count(s => s.Length > 5);
        var sumOfLengths = strings.Sum(s => s.Length);
        var distinctCharacters = strings.SelectMany(s => s).Distinct().OrderBy(c => c).ToString();

        return (evenSum, oddProduct, countGreaterThanFive, sumOfLengths, distinctCharacters);
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> strings = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

        var result = ExploreData(numbers, strings);
        Console.WriteLine(result); // Output: (30, 945, 3, 25, "aplebnchrdt")
    }
}
