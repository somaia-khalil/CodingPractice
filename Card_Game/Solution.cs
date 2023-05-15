// Solution to The Challenging Card Game

using System;
using System.Collections.Generic;

public class Program
{
    public static string PlayChallengingCardGame(int roundPoints, int bonusPoints)
    {
        int player1Score = 0;
        int player2Score = 0;
        int totalRounds = 0;

        while (player1Score < roundPoints && player2Score < roundPoints)
        {
            totalRounds++;

            // Initialize and shuffle the deck
            List<string> deck = InitializeDeck();
            Shuffle(deck);

            // Split the deck between two players
            List<string> player1Hand = new List<string>();
            List<string> player2Hand = new List<string>();
            SplitDeck(deck, player1Hand, player2Hand);

            int subRound = 1;

            while (player1Hand.Count > 0 && player2Hand.Count > 0)
            {
                string card1 = player1Hand[0];
                string card2 = player2Hand[0];

                Console.WriteLine($"Round {totalRounds}, Sub-round {subRound}: Player 1 ({card1}) vs. Player 2 ({card2})");

                player1Hand.RemoveAt(0);
                player2Hand.RemoveAt(0);

                int result = CompareCards(card1, card2);

                if (result > 0)
                {
                    player1Score++;
                    Console.WriteLine("Player 1 wins the sub-round!");
                }
                else if (result < 0)
                {
                    player2Score++;
                    Console.WriteLine("Player 2 wins the sub-round!");
                }
                else
                {
                    Console.WriteLine("It's a war!");
                    if (player1Hand.Count >= 2 && player2Hand.Count >= 2)
                    {
                        // War
                        string hiddenCard1 = player1Hand[0];
                        string hiddenCard2 = player2Hand[0];
                        player1Hand.RemoveAt(0);
                        player2Hand.RemoveAt(0);

                        string faceUpCard1 = player1Hand[0];
                        string faceUpCard2 = player2Hand[0];

                        Console.WriteLine($"Player 1's hidden card: {hiddenCard1}, Face up card: {faceUpCard1}");
                        Console.WriteLine($"Player 2's hidden card: {hiddenCard2}, Face up card: {faceUpCard2}");

                        int warResult = CompareCards(faceUpCard1, faceUpCard2);

                        if (warResult > 0)
                        {
                            player1Score += bonusPoints;
                            Console.WriteLine("Player 1 wins the war!");
                        }
                        else if (warResult < 0)
                        {
                            player2Score += bonusPoints;
                            Console.WriteLine("Player 2 wins the war!");
                        }
                    }
                }

                subRound++;
            }
        }

        string winner = player1Score > player2Score ? "Player 1" : "Player 2";
        return $"{winner} wins the round! Final Scores: Player 1 ({player1Score}), Player 2 ({player2Score})";
    }

    private static List<string> InitializeDeck()
    {
        List<string> deck = new List<string>();

        foreach (char suit in new[] { 'H', 'D', 'C', 'S' })
        {
            foreach (string rank in new[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" })
            {
                deck.Add(rank + suit);
            }
        }

        return deck;
    }

    private static void Shuffle(List<string> deck)
    {
        Random rng = new Random();
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }

    private static void SplitDeck(List<string> deck, List<string> player1Hand, List<string> player2Hand)
    {
        int halfSize = deck.Count / 2;
        player1Hand.AddRange(deck.GetRange(0, halfSize));
        player2Hand.AddRange(deck.GetRange(halfSize, halfSize));
    }

    private static int CompareCards(string card1, string card2)
    {
        string rank1 = card1.Substring(0, card1.Length - 1);
        string rank2 = card2.Substring(0, card2.Length - 1);

        Dictionary<string, int> rankOrder = new Dictionary<string, int>
        {
            {"A", 14},
            {"2", 2},
            {"3", 3},
            {"4", 4},
            {"5", 5},
            {"6", 6},
            {"7", 7},
            {"8", 8},
            {"9", 9},
            {"10", 10},
            {"J", 11},
            {"Q", 12},
            {"K", 13}
        };

        int rankComparison = rankOrder[rank1].CompareTo(rankOrder[rank2]);

        if (rankComparison != 0)
        {
            return rankComparison;
        }

        char suit1 = card1[card1.Length - 1];
        char suit2 = card2[card2.Length - 1];

        return suit1.CompareTo(suit2);
    }

    static void Main()
    {
        int roundPoints = 10;
        int bonusPoints = 5;
        string result = PlayChallengingCardGame(roundPoints, bonusPoints);
        Console.WriteLine(result);
    }
}
    