// Solution to The Cryptic Code Challenge

using System;

public class Program
{
    public static void Main()
    {
        string crypticCode = "ftqsknlx";
        string message = DecryptCode(crypticCode);
        Console.WriteLine("Hidden Message: " + message);
    }

    public static string DecryptCode(string code)
    {
        // Decryption logic:
        // This code is a simple Caesar cipher, where each character is shifted 1 position to the left.
        // Convert each character back to its original form.

        string message = "";
        foreach (char c in code)
        {
            message += (char)(c - 1);
        }
        return message;
    }
}
