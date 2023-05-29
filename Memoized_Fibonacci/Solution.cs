
// Solution to The Memoized Fibonacci Sequence challenge

using System.Collections.Generic;

public class Program
{
    private static Dictionary<int, long> memo = new Dictionary<int, long>();

    public static long Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        if (memo.ContainsKey(n))
        {
            return memo[n];
        }
        else
        {
            long result = Fibonacci(n - 1) + Fibonacci(n - 2);
            memo[n] = result;
            return result;
        }
    }

    static void Main()
    {
        int n = 10;
        long result = Fibonacci(n);
        System.Console.WriteLine(result); // Output: 55
    }
}
