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
        int sum = 0;
        foreach (int num in Numbers)
        {
            sum += num;
        }
        return sum;
    }

    public int Product()
    {
        int product = 1;
        foreach (int num in Numbers)
        {
            product *= num;
        }
        return product;
    }

    public double Average()
    {
        if (Numbers.Length == 0)
        {
            return 0;
        }

        return (double)Sum() / Numbers.Length;
    }

    public int[] Reverse()
    {
        int[] reversed = new int[Numbers.Length];
        for (int i = 0; i < Numbers.Length; i++)
        {
            reversed[i] = Numbers[Numbers.Length - i - 1];
        }
        return reversed;
    }

    public int FindMax()
    {
        if (Numbers.Length == 0)
        {
            throw new InvalidOperationException("The array is empty.");
        }

        int max = Numbers[0];
        for (int i = 1; i < Numbers.Length; i++)
        {
            if (Numbers[i] > max)
            {
                max = Numbers[i];
            }
        }
        return max;
    }

    public int FindMin()
    {
        if (Numbers.Length == 0)
        {
            throw new InvalidOperationException("The array is empty.");
        }

        int min = Numbers[0];
        for (int i = 1; i < Numbers.Length; i++)
        {
            if (Numbers[i] < min)
            {
                min = Numbers[i];
            }
        }
        return min;
    }

    public bool IsSorted()
    {
        if (Numbers.Length <= 1)
        {
            return true;
        }

        for (int i = 1; i < Numbers.Length; i++)
        {
            if (Numbers[i] < Numbers[i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
