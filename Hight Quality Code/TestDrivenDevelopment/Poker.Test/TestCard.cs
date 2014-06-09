using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class TestCard
    {
        [TestMethod]
        public void TestCard_ToString10OfSpades()
        {
            var tenOfSpades = new Card(CardFace.Ten, CardSuit.Spades);
            Assert.AreEqual("10♠", tenOfSpades.ToString());
        }

        [TestMethod]
        public void TestCard_ToStringKingOfClubs()
        {
            var tenOfClubs = new Card(CardFace.King, CardSuit.Clubs);
            Assert.AreEqual("K♣", tenOfClubs.ToString());
        }

        [TestMethod]
        public void TestCard_ToString2OfHearts()
        {
            var twoOfHerts = new Card(CardFace.Two, CardSuit.Hearts);
            Assert.AreEqual("2♥", twoOfHerts.ToString());
        }

        [TestMethod]
        public void TestCard_ToStringJackOfDiamonds()
        {
            var jackOfDiamonds = new Card(CardFace.Jack, CardSuit.Diamonds);
            Assert.AreEqual("J♦", jackOfDiamonds.ToString());
        }
    }
}
