## The Context-Free Grammar Parser

You are given a context-free grammar represented as a list of production rules. Each rule is in the form of `NonTerminal -> Expression`, where `NonTerminal` is a single uppercase letter representing the non-terminal symbol, and `Expression` is a string representing the production expression.

Your task is to implement the function `parseGrammar` that parses the given context-free grammar and determines whether a given string `input` can be generated from the grammar.

Your function should return a boolean value indicating whether the input string can be generated or not.

### Example

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> grammar = new List<string>
        {
            "S -> aSb",
            "S -> SS",
            "S -> epsilon"
        };

        bool result1 = ParseGrammar(grammar, "aabb"); // Output: true
        bool result2 = ParseGrammar(grammar, "ab");   // Output: true
        bool result3 = ParseGrammar(grammar, "aab");  // Output: false
    }

    public static bool ParseGrammar(List<string> grammar, string input)
    {
        // Implement your solution here
    }
}
