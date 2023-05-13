## The Challenging Card Game

You are designing a two-player card game called "Challenging Card Game." The game is played with a standard deck of 52 playing cards (no jokers). Each card has a rank and a suit.

**Card Ranks:** Ace (A), 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack (J), Queen (Q), King (K).

**Card Suits:** Hearts (H), Diamonds (D), Clubs (C), Spades (S).

The objective of the game is to win rounds and collect points. Each round consists of multiple sub-rounds, and the player who wins the majority of the sub-rounds wins the round. The game continues until a player accumulates a predetermined number of points to be declared the winner.

### Game Rules:

1. At the start of each round, the deck is shuffled and divided equally between the two players. Each player holds a set of cards (initially hidden from the opponent).
2. In each sub-round, both players reveal the top card from their hand simultaneously.
3. The player with the higher-ranked card wins the sub-round and scores one point.
4. If the two cards have the same rank, a "war" occurs. Each player draws an additional card face down (still hidden from the opponent) and another card face up. The face-up cards are then compared, and the player with the higher-ranked face-up card wins the war, scoring three points instead of one.
5. The cards used in the sub-round or war are discarded from the players' hands.
6. The game continues with a new sub-round until one player wins a majority of the sub-rounds or until all cards have been played.
7. If a player accumulates the predetermined number of points, they are declared the winner of the round and receive additional bonus points.

Your task is to implement the function `PlayChallengingCardGame` that takes the following inputs:

- An integer `roundPoints` representing the number of points required to win a round (e.g., 10).
- An integer `bonusPoints` representing the additional bonus points awarded to the winner of the round (e.g., 5).

The function should simulate the "Challenging Card Game" between two players and return a string indicating the winner of the round and the final scores for each player.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        int roundPoints = 10;
        int bonusPoints = 5;
        string result = PlayChallengingCardGame(roundPoints, bonusPoints);
        Console.WriteLine(result);
        // Output: "Player 1 wins the round! Final Scores: Player 1 (15), Player 2 (9)"
    }

    public static string PlayChallengingCardGame(int roundPoints, int bonusPoints)
    {
        // Implement your solution here
    }
}
