namespace Poker.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class TestPokerHandsChecker
    {
        [TestMethod]
        public void TestIsValudHand_Valid()
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

        [TestMethod]
        public void TestIsValudHand_NotValid()
        {
            var cards = new List<ICard>(){
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs)
            };

            var hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestIsFlush_Valid()
        {
            var cards = new List<ICard>(){
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs)
            };

            var hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsFlush_NotValid()
        {
            var cards = new List<ICard>(){
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs)
            };

            var hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsFourOfAKind_Valid()
        {
            var cards = new List<ICard>(){
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs)
            };

            var hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }
    }
}
