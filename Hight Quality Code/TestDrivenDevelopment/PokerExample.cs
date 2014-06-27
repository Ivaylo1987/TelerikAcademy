//This homework is the poker game from test-driven development + Logger added to demonstrate logging with log4net
using System;
using System.Collections.Generic;
using log4net.Config;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Diamonds)
            });
            Console.WriteLine(hand);

            IPokerHandsChecker checker = new PokerHandsChecker();

            // logging
            Logger.Log.Info(checker.IsValidHand(hand));
            Logger.Log.Info(checker.IsFourOfAKind(hand));

            //Console.WriteLine(checker.IsOnePair(hand));
            //Console.WriteLine(checker.IsTwoPair(hand));
        }
    }
}
