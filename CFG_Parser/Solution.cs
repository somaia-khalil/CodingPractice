// Solution to The Context-Free Grammar Parser challenge

using System;
using System.Collections.Generic;

public class Program
{
    private static Dictionary<char, List<string>> productionRules = new Dictionary<char, List<string>>();

    public static bool ParseGrammar(List<string> grammar, string input)
    {
        productionRules.Clear();
        foreach (var rule in grammar)
        {
            char nonTerminal = rule[0];
            string expression = rule.Substring(4);
            if (!productionRules.ContainsKey(nonTerminal))
            {
                productionRules[nonTerminal] = new List<string>();
            }
            productionRules[nonTerminal].Add(expression);
        }

        return IsGenerated('S', input);
    }

    public static bool IsGenerated(char nonTerminal, string input)
    {
        if (input == "")
        {
            return productionRules[nonTerminal].Contains("epsilon");
        }

        foreach (var rule in productionRules[nonTerminal])
        {
            if (rule[0] == input[0])
            {
                if (IsGenerated(rule[0], input.Substring(1)))
                {
                    return true;
                }
            }
            else if (char.IsUpper(rule[0]))
            {
                foreach (var production in productionRules[rule[0]])
                {
                    string newInput = production + input;
                    if (IsGenerated(nonTerminal, newInput))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

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

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}
