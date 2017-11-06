using PokerhandShowdown.Constants;

namespace PokerhandShowdown.Models
{
    public class Card
    {
        private readonly CardValue _cardValue;
        private readonly CardSuit _cardSuit;

        public Card(CardValue cardValue, CardSuit cardSuit)
        {
            _cardValue = cardValue;
            _cardSuit = cardSuit;
        }

        public CardValue CardValue { get { return _cardValue; } }
        public CardSuit CardSuit { get { return _cardSuit; } }
    }
}