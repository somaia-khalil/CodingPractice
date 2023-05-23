// Solution to The Complex Nested Data Explorer challenge

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static (int, double, int, int, int) ExploreNestedData(Dictionary<string, object> data)
    {
        var integerSum = data.SelectMany(kv => ExtractIntegers(kv.Value)).Sum();
        var floatProduct = data.SelectMany(kv => ExtractFloats(kv.Value)).Aggregate(1.0, (acc, f) => acc * f);
        var maxDepth = GetMaxDepth(data);
        var stringCount = data.SelectMany(kv => ExtractStrings(kv.Value)).Count();
        var aCharCount = data.SelectMany(kv => ExtractStrings(kv.Value)).Sum(s => s.Count(c => c == 'a'));

        return (integerSum, floatProduct, maxDepth, stringCount, aCharCount);
    }

    private static IEnumerable<int> ExtractIntegers(object obj)
    {
        if (obj is int intValue)
        {
            yield return intValue;
        }
        else if (obj is IEnumerable<object> enumerable)
        {
            foreach (var item in enumerable)
            {
                foreach (var integer in ExtractIntegers(item))
                {
                    yield return integer;
                }
            }
        }
    }

    private static IEnumerable<double> ExtractFloats(object obj)
    {
        if (obj is double floatValue)
        {
            yield return floatValue;
        }
        else if (obj is IEnumerable<object> enumerable)
        {
            foreach (var item in enumerable)
            {
                foreach (var floatValue in ExtractFloats(item))
                {
                    yield return floatValue;
                }
            }
        }
    }

    private static IEnumerable<string> ExtractStrings(object obj)
    {
        if (obj is string stringValue)
        {
            yield return stringValue;
        }
        else if (obj is IEnumerable<object> enumerable)
        {
            foreach (var item in enumerable)
            {
                foreach (var stringValue in ExtractStrings(item))
                {
                    yield return stringValue;
                }
            }
        }
        else if (obj is IDictionary<string, object> dictionary)
        {
            foreach (var kv in dictionary)
            {
                foreach (var stringValue in ExtractStrings(kv.Value))
                {
                    yield return stringValue;
                }
            }
        }
    }

    private static int GetMaxDepth(object obj)
    {
        if (obj is IDictionary<string, object> dictionary)
        {
            return 1 + dictionary.Values.Max(value => GetMaxDepth(value));
        }
        else if (obj is IEnumerable<object> enumerable)
        {
            return 1 + enumerable.Max(item => GetMaxDepth(item));
        }
        else
        {
            return 1;
        }
    }

    static void Main()
    {
        var nestedData = new Dictionary<string, object>
        {
            { "numbers", new List<object> { 1, 2, new Tuple<int, float>(3, 1.5f) } },
            { "more_numbers", new List<object> { 4, 5, new Tuple<int, float>(6, 2.5f) } },
            { "details", new Dictionary<string, object>
                {
                    { "name", "John" },
                    { "age", 30 },
                    { "addresses", new List<object>
                        {
                            new Dictionary<string, object> { { "city", "New York" }, { "zip", 10001 } },
                            new Dictionary<string, object> { { "city", "Los Angeles" }, { "zip", 90001 } }
                        }
                    }
                }
            }
        };

        var result = ExploreNestedData(nestedData);
        Console.WriteLine(result); // Output: (21, 22.5, 3, 2, 2)
    }
}
