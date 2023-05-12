## The Cryptic Cipher Challenge

You have come across a mysterious encrypted message that you need to decipher. The message is encrypted using a cryptic cipher algorithm, and your task is to implement the function `DecipherMessage` to decode the message and reveal its meaning.

The cryptic cipher algorithm uses the following rules:

1. The message is represented as a string containing uppercase letters and numbers only.
2. Each character in the message represents an action that needs to be performed.
3. The actions are applied sequentially to decode the message.

**Actions:**
- Letters: The letters in the message represent specific operations to be performed on the original message. The operations are defined as follows:
  - 'R': Reverse the entire message.
  - 'S': Shift each character in the message one position to the right. The last character becomes the first.
  - 'D': Delete the first occurrence of the character immediately following the letter 'D' in the message.
  - 'X': If the character immediately following the letter 'X' is a number, repeat the previous operation 'X' number of times. Otherwise, ignore 'X'.

**Examples:**
- "RS" means to first reverse the message and then shift each character one position to the right.
- "DX3" means to delete the first occurrence of '3' in the message and then repeat the previous operation two more times.

Your task is to implement the function `DecipherMessage` that takes the following input:

- A string `message` representing the encrypted message.

The function should return the original message after applying all the actions according to the cryptic cipher algorithm.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        string encryptedMessage = "RSDX2";

        string originalMessage = DecipherMessage(encryptedMessage);
        Console.WriteLine(originalMessage); // Output: "RSD"
    }

    public static string DecipherMessage(string message)
    {
        // Implement your solution here
    }
}
