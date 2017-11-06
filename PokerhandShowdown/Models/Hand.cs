using System;
using System.Collections.Generic;
using System.Linq;
using PokerhandShowdown.Constants;

namespace PokerhandShowdown.Models
{
    public class Hand
    {
        private readonly IHandEvaluator _handEvaluator;

        public Hand(Card card1, Card card2, Card card3, Card card4, Card card5)
        {
            _handEvaluator = new HandEvaluator();
            Cards = new List<Card> { card1, card2, card3, card4, card5, };
            Type = GetHandType();
            Value = GetHandValue();
        }

        public IReadOnlyCollection<Card> Cards { get; private set; }
        public HandType Type { get; private set; }
        public int Value { get; set; }

        private HandType GetHandType()
        {
            return _handEvaluator.GetHandType(Cards.ToList());
        }

        private int GetHandValue()
        {
            return _handEvaluator.GetHandValue(Type, Cards.ToList());
        }

    }
}