## The LINQ Expression Explorer

You are given a list of integers and a list of strings. Your task is to implement the function `ExploreData` that performs various LINQ operations on the input lists to obtain specific results.

The function should return the following information:

1. The sum of all even numbers in the list of integers.
2. The product of all odd numbers in the list of integers.
3. The count of strings that have length greater than 5.
4. The sum of the lengths of all strings.
5. The distinct characters present in all strings.

Your function should return a tuple with the above results in the order mentioned.

### Example

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> strings = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

        var result = ExploreData(numbers, strings);
        // Output: (30, 945, 3, 25, "aplebnchrdt")
        // Explanation: 
        // - The sum of even numbers: 2 + 4 + 6 + 8 + 10 = 30
        // - The product of odd numbers: 1 * 3 * 5 * 7 * 9 = 945
        // - Number of strings with length > 5: 3 ("banana", "cherry", "elderberry")
        // - Sum of string lengths: 5 + 6 + 6 + 4 + 11 = 25
        // - Distinct characters: "a", "p", "l", "e", "b", "n", "c", "h", "r", "d", "t"
    }

    public static (int, int, int, int, string) ExploreData(List<int> numbers, List<string> strings)
    {
        // Implement your solution here
    }
}
