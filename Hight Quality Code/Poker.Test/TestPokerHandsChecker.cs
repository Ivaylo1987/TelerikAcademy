namespace Poker.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class TestPokerHandsChecker
    {
        [TestMethod]
        public void Test_IsValudHand()
        {
            var cards = new List<ICard>(){
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsValidHand(hand));
        }
    }
}
