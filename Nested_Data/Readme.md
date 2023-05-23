## The Complex Nested Data Explorer

You are given a complex nested data structure represented as a combination of dictionaries, lists, and tuples. Your task is to implement the function `ExploreNestedData` that performs various operations on the input data structure to obtain specific results.

The function should return the following information:

1. The sum of all integers present in the data structure.
2. The product of all floating-point numbers present in the data structure.
3. The maximum depth of the nested data structure (depth of dictionaries, lists, and tuples).
4. The total count of all strings present in the data structure.
5. The number of occurrences of the character 'a' in all strings.

Your function should return a tuple with the above results in the order mentioned.

### Example

```csharp
using System;
using System.Collections.Generic;

class Program
{
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
        // Output: (21, 22.5, 3, 2, 2)
        // Explanation: 
        // - Sum of all integers: 1 + 2 + 3 + 4 + 5 + 6 + 30 + 10001 + 90001 = 21
        // - Product of all floats: 1.5 * 2.5 = 3.75, 3.75 * 22.5 = 84.375
        // - Maximum depth of the nested data structure: 3 (level of nesting of dictionaries, lists, and tuples)
        // - Total count of strings: 2 ("John", "New York", "Los Angeles")
        // - Number of occurrences of character 'a' in all strings: 2 ('John', 'New York')
    }

    public static (int, double, int, int, int) ExploreNestedData(Dictionary<string, object> data)
    {
        // Implement your solution here
    }
}
