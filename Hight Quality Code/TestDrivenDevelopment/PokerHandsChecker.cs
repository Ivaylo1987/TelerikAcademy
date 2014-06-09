using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand cannot be null!");
            }
            // group by ToString()
            var groupedByCard = hand.Cards.GroupBy(card => card.ToString());
            // take one element of each group
            var firstOfEachGroup = groupedByCard.Select(group => group.First());
            // If there are 5 groups => all cards are different.
            return firstOfEachGroup.Count() == 5;
        }

        public bool IsFlush(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand cannot be null!");
            }
            // if all cards have the suit of the first => we have a flush.
            return hand.Cards.All(c => c.Suit == hand.Cards.First().Suit);
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand cannot be null!");
            }
            // group by ToString()
            var groupedByCard = hand.Cards.GroupBy(card => card.Face);
            // see if any gorup is 4 elements long
            var isAnyFourInLength = groupedByCard.Any(g => g.Count() == 4);

            return isAnyFourInLength;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
