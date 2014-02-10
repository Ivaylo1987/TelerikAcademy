using System;

class CardDeck
{
    /*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
      * The cards should be printed with their English names. Use nested for loops and switch-case.
      */

    static void Main()
    {
        string[] suits = { "Clubs", "Diamonds", "Spades", "Hearts" };
        string[] rank = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "eight", "Nine", "Ten", "Jack", "Queen", "King" };

        foreach (var suit in suits)
        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("{0} of {1}", rank[i], suit);
            }
        }

    }
}
