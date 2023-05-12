// Solution to The Cryptic Cipher Challenge

using System;
using System.Text;

public class Program
{
    public static string DecipherMessage(string message)
    {
        StringBuilder decipheredMessage = new StringBuilder();
        int currentIndex = 0;

        while (currentIndex < message.Length)
        {
            char currentChar = message[currentIndex];

            switch (currentChar)
            {
                case 'R':
                    decipheredMessage = decipheredMessage.Length > 0 ? new StringBuilder(decipheredMessage.ToString().Reverse()) : decipheredMessage;
                    break;

                case 'S':
                    char lastChar = decipheredMessage.Length > 0 ? decipheredMessage[decipheredMessage.Length - 1] : '\0';
                    decipheredMessage.Remove(decipheredMessage.Length - 1, 1);
                    decipheredMessage.Insert(0, lastChar);
                    break;

                case 'D':
                    if (currentIndex + 1 < message.Length)
                    {
                        char charToDelete = message[currentIndex + 1];
                        int charIndex = decipheredMessage.Length > 0 ? decipheredMessage.ToString().IndexOf(charToDelete) : -1;
                        if (charIndex != -1)
                        {
                            decipheredMessage.Remove(charIndex, 1);
                        }
                        currentIndex++;
                    }
                    break;

                case 'X':
                    if (currentIndex + 1 < message.Length && Char.IsDigit(message[currentIndex + 1]))
                    {
                        int repeatCount = int.Parse(message[currentIndex + 1].ToString());
                        for (int i = 0; i < repeatCount; i++)
                        {
                            string lastDecipheredMessage = decipheredMessage.ToString();
                            decipheredMessage = new StringBuilder(DecipherMessage(lastDecipheredMessage));
                        }
                        currentIndex++;
                    }
                    break;

                default:
                    decipheredMessage.Append(currentChar);
                    break;
            }

            currentIndex++;
        }

        return decipheredMessage.ToString();
    }

    static void Main()
    {
        string encryptedMessage = "RSDX2";
        string originalMessage = DecipherMessage(encryptedMessage);
        Console.WriteLine(originalMessage);
    }
}
