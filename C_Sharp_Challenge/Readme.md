## The C# Knowledge Challenge

You are given a C# class named `KnowledgeChallenge` with some incomplete methods and properties. Your task is to complete these methods and properties using your extensive C# knowledge.

### Class: KnowledgeChallenge

#### Properties:

1. `Numbers` (int[]): A private array of integers that will hold a collection of numbers.

#### Methods:

1. `Sum`: A public method that calculates and returns the sum of all the numbers in the `Numbers` array.

2. `Product`: A public method that calculates and returns the product of all the numbers in the `Numbers` array.

3. `Average`: A public method that calculates and returns the average of all the numbers in the `Numbers` array.

4. `Reverse`: A public method that reverses the order of elements in the `Numbers` array and returns the reversed array.

5. `FindMax`: A public method that finds and returns the maximum value in the `Numbers` array.

6. `FindMin`: A public method that finds and returns the minimum value in the `Numbers` array.

7. `IsSorted`: A public method that checks if the `Numbers` array is sorted in ascending order and returns a boolean value indicating the result.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 2, 5, 1, 8, 4 };
        KnowledgeChallenge challenge = new KnowledgeChallenge(numbers);

        int sum = challenge.Sum(); // Output: 20
        int product = challenge.Product(); // Output: 160
        double average = challenge.Average(); // Output: 4.0
        int[] reversed = challenge.Reverse(); // Output: [4, 8, 1, 5, 2]
        int max = challenge.FindMax(); // Output: 8
        int min = challenge.FindMin(); // Output: 1
        bool isSorted = challenge.IsSorted(); // Output: false
    }
}

// Solution to The C# Knowledge Challenge

using System;

public class KnowledgeChallenge
{
    private int[] Numbers;

    public KnowledgeChallenge(int[] numbers)
    {
        Numbers = numbers;
    }

    public int Sum()
    {
        // Implement the method to calculate and return the sum of all the numbers in the Numbers array.
        return 0;
    }

    public int Product()
    {
        // Implement the method to calculate and return the product of all the numbers in the Numbers array.
        return 0;
    }

    public double Average()
    {
        // Implement the method to calculate and return the average of all the numbers in the Numbers array.
        return 0;
    }

    public int[] Reverse()
    {
        // Implement the method to reverse the order of elements in the Numbers array and return the reversed array.
        return null;
    }

    public int FindMax()
    {
        // Implement the method to find and return the maximum value in the Numbers array.
        return 0;
    }

    public int FindMin()
    {
        // Implement the method to find and return the minimum value in the Numbers array.
        return 0;
    }

    public bool IsSorted()
    {
        // Implement the method to check if the Numbers array is sorted in ascending order and return a boolean value indicating the result.
        return false;
    }
}
