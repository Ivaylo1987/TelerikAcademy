using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class TestHand
    {
        [TestMethod]
        public void TestToString_DifferentSuits()
        {
            var cards = new List<ICard>(){
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades)
            };

            var result = new Hand(cards);

            Assert.AreEqual("A♣ 8♦ Q♥ 5♠", result.ToString());
        }

        [TestMethod]
        public void TestToString_OneSuit()
        {
            var cards = new List<ICard>(){
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs)
            };

            var result = new Hand(cards);

            Assert.AreEqual("A♣ 8♣ Q♣ 5♣", result.ToString());
        }
    }
}
