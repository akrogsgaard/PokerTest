using System.Collections.Generic;
using System.Linq;
using PokerhandShowdown.Constants;
using PokerhandShowdown.Models;

namespace PokerhandShowdown
{
    public interface IHandEvaluator
    {
        HandType GetHandType(List<Card> cards);
        int GetHandValue(HandType type, List<Card> cards);
    }

    public class HandEvaluator : IHandEvaluator
    {
        public HandType GetHandType(List<Card> cards)
        {
            if (IsFlush(cards))
                return HandType.Flush;

            if(IsThreeOfAKind(cards))
                return HandType.ThreeOfAKind;

            if (IsOnePair(cards))
                return HandType.OnePair;

            return HandType.HighCard;
        }

        public int GetHandValue(HandType type, List<Card> cards)
        {
            return (int) type + cards.Sum(card => (int) card.CardValue);
        }


        private static bool IsFlush(IEnumerable<Card> cards)
        {
            var flush = cards.GroupBy(card => card.CardSuit)
                           .Select(group => new { SortValue = group.Key, Count = group.Count() })
                           .Where(group => group.Count == 5);

            return flush.Any();
        }

        private static bool IsThreeOfAKind(IEnumerable<Card> cards)
        {
            var threeOfAKind = cards.GroupBy(card => card.CardValue)
                           .Select(group => new { SortValue = @group.Key, Count = @group.Count() })
                           .Where(group => @group.Count == 3);

            return threeOfAKind.Any();
        }

        private static bool IsOnePair(IEnumerable<Card> cards)
        {

            var onePair = cards.GroupBy(card => card.CardValue)
                           .Select(group => new { SortValue = @group.Key, Count = @group.Count() })
                           .Where(group => @group.Count == 2);

            return onePair.Any();
        }

    }
}