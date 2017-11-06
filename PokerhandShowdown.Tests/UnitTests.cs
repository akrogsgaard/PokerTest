using System.Collections.Generic;
using PokerhandShowdown.Constants;
using PokerhandShowdown.Models;
using Xunit;

namespace PokerhandShowdown.Tests
{
    public class UnitTests
    {
        [Fact]
        public void HighCardWins()
        {
            var joe = new Player
            {
                Name = "Joe",
                Hand = new Hand
                    (
                    new Card(CardValue.Two, CardSuit.Clubs),
                    new Card(CardValue.Three, CardSuit.Hearts),
                    new Card(CardValue.Four, CardSuit.Diamonds),
                    new Card(CardValue.Five, CardSuit.Diamonds),
                    new Card(CardValue.Six, CardSuit.Hearts)
                    )
            };

            var jen = new Player
            {
                Name = "Jen",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Clubs),
                    new Card(CardValue.Four, CardSuit.Diamonds),
                    new Card(CardValue.Five, CardSuit.Hearts),
                    new Card(CardValue.Six, CardSuit.Spades),
                    new Card(CardValue.Seven, CardSuit.Spades)
                    )
            };

            var bob = new Player
            {
                Name = "Bob",
                Hand = new Hand
                    (
                    new Card(CardValue.Two, CardSuit.Hearts),
                    new Card(CardValue.Two, CardSuit.Clubs),
                    new Card(CardValue.Five, CardSuit.Spades),
                    new Card(CardValue.Ten, CardSuit.Clubs),
                    new Card(CardValue.Ace, CardSuit.Hearts)
                    )
            };

            var players = new List<Player> { joe, jen, bob };
            var pokerGame = new Game(players);

            var winner = pokerGame.GetWinner();

            Assert.Equal(bob, winner);
        }

        [Fact]
        public void PairWins()
        {
            var joe = new Player
            {
                Name = "Joe",
                Hand = new Hand
                    (
                    new Card(CardValue.Six, CardSuit.Hearts),
                    new Card(CardValue.Eight, CardSuit.Diamonds),
                    new Card(CardValue.Jack, CardSuit.Clubs),
                    new Card(CardValue.Jack, CardSuit.Diamonds),
                    new Card(CardValue.Queen, CardSuit.Hearts)
                    )
            };

            var jen = new Player
            {
                Name = "Jen",
                Hand = new Hand
                    (
                    new Card(CardValue.Two, CardSuit.Clubs),
                    new Card(CardValue.Nine, CardSuit.Diamonds),
                    new Card(CardValue.Jack, CardSuit.Hearts),
                    new Card(CardValue.Jack, CardSuit.Spades),
                    new Card(CardValue.Queen, CardSuit.Spades)
                    )
            };

            var bob = new Player
            {
                Name = "Bob",
                Hand = new Hand
                    (
                    new Card(CardValue.Two, CardSuit.Hearts),
                    new Card(CardValue.Two, CardSuit.Clubs),
                    new Card(CardValue.Five, CardSuit.Spades),
                    new Card(CardValue.Ten, CardSuit.Clubs),
                    new Card(CardValue.Ace, CardSuit.Hearts)
                    )
            };

            var players = new List<Player> { joe, jen, bob };
            var pokerGame = new Game(players);

            var winner = pokerGame.GetWinner();

            Assert.Equal(joe, winner);
        }

        [Fact]
        public void ThreeOfAKindWins()
        {
            var joe = new Player
                {
                    Name = "Joe",
                    Hand = new Hand
                        (
                        new Card(CardValue.Three, CardSuit.Hearts),
                        new Card(CardValue.Six, CardSuit.Hearts),
                        new Card(CardValue.Eight, CardSuit.Hearts),
                        new Card(CardValue.Jack, CardSuit.Spades),
                        new Card(CardValue.King, CardSuit.Clubs)
                        )
                };

            var jen = new Player
                {
                    Name = "Jen",
                    Hand = new Hand
                        (
                        new Card(CardValue.Three, CardSuit.Clubs),
                        new Card(CardValue.Three, CardSuit.Diamonds),
                        new Card(CardValue.Three, CardSuit.Spades),
                        new Card(CardValue.Eight, CardSuit.Clubs),
                        new Card(CardValue.Ten, CardSuit.Diamonds)
                        )
                };

            var bob = new Player
                {
                    Name = "Bob",
                    Hand = new Hand
                        (
                        new Card(CardValue.Two, CardSuit.Hearts),
                        new Card(CardValue.Five, CardSuit.Clubs),
                        new Card(CardValue.Seven, CardSuit.Spades),
                        new Card(CardValue.Ten, CardSuit.Clubs),
                        new Card(CardValue.Ace, CardSuit.Clubs)
                        )
                };

            var players = new List<Player> {joe, jen, bob};
            var pokerGame = new Game(players);

            var winner = pokerGame.GetWinner();

            Assert.Equal(jen, winner);
        }

        [Fact]
        public void ThreeOfAKindTie()
        {
            var joe = new Player
            {
                Name = "Joe",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Clubs),
                    new Card(CardValue.Three, CardSuit.Diamonds),
                    new Card(CardValue.Three, CardSuit.Spades),
                    new Card(CardValue.Jack, CardSuit.Hearts),
                    new Card(CardValue.King, CardSuit.Hearts)
                    )
            };

            var jen = new Player
            {
                Name = "Jen",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Clubs),
                    new Card(CardValue.Three, CardSuit.Diamonds),
                    new Card(CardValue.Three, CardSuit.Spades),
                    new Card(CardValue.Eight, CardSuit.Hearts),
                    new Card(CardValue.Two, CardSuit.Hearts)
                    )
            };

            var bob = new Player
            {
                Name = "Bob",
                Hand = new Hand
                    (
                    new Card(CardValue.Two, CardSuit.Hearts),
                    new Card(CardValue.Five, CardSuit.Clubs),
                    new Card(CardValue.Seven, CardSuit.Spades),
                    new Card(CardValue.Ten, CardSuit.Clubs),
                    new Card(CardValue.Ace, CardSuit.Clubs)
                    )
            };

            var players = new List<Player> { joe, jen, bob };
            var pokerGame = new Game(players);

            var winner = pokerGame.GetWinner();

            Assert.Equal(joe, winner);
        }

        [Fact]
        public void FlushWins()
        {
            var joe = new Player
            {
                Name = "Joe",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Hearts),
                    new Card(CardValue.Six, CardSuit.Hearts),
                    new Card(CardValue.Eight, CardSuit.Hearts),
                    new Card(CardValue.Jack, CardSuit.Hearts),
                    new Card(CardValue.King, CardSuit.Hearts)
                    )
            };

            var jen = new Player
            {
                Name = "Jen",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Clubs),
                    new Card(CardValue.Three, CardSuit.Diamonds),
                    new Card(CardValue.Three, CardSuit.Spades),
                    new Card(CardValue.Eight, CardSuit.Clubs),
                    new Card(CardValue.Ten, CardSuit.Diamonds)
                    )
            };

            var bob = new Player
            {
                Name = "Bob",
                Hand = new Hand
                    (
                    new Card(CardValue.Two, CardSuit.Hearts),
                    new Card(CardValue.Five, CardSuit.Clubs),
                    new Card(CardValue.Seven, CardSuit.Spades),
                    new Card(CardValue.Ten, CardSuit.Clubs),
                    new Card(CardValue.Ace, CardSuit.Clubs)
                    )
            };

            var players = new List<Player> { joe, jen, bob };
            var pokerGame = new Game(players);

            var winner = pokerGame.GetWinner();

            Assert.Equal(joe, winner);
        }

        [Fact]
        public void FlushTie()
        {
            var joe = new Player
            {
                Name = "Joe",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Hearts),
                    new Card(CardValue.Six, CardSuit.Hearts),
                    new Card(CardValue.Eight, CardSuit.Hearts),
                    new Card(CardValue.Jack, CardSuit.Hearts),
                    new Card(CardValue.King, CardSuit.Hearts)
                    )
            };

            var jen = new Player
            {
                Name = "Jen",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Clubs),
                    new Card(CardValue.Seven, CardSuit.Clubs),
                    new Card(CardValue.Ten, CardSuit.Clubs),
                    new Card(CardValue.Ace, CardSuit.Clubs),
                    new Card(CardValue.King, CardSuit.Clubs)
                    )
            };

            var bob = new Player
            {
                Name = "Bob",
                Hand = new Hand
                    (
                    new Card(CardValue.Two, CardSuit.Hearts),
                    new Card(CardValue.Five, CardSuit.Clubs),
                    new Card(CardValue.Seven, CardSuit.Spades),
                    new Card(CardValue.Ten, CardSuit.Clubs),
                    new Card(CardValue.Ace, CardSuit.Clubs)
                    )
            };

            var players = new List<Player> { joe, jen, bob };
            var pokerGame = new Game(players);

            var winner = pokerGame.GetWinner();

            Assert.Equal(jen, winner);
        }

        [Fact]
        public void Stefan_pair_breaks_tie_based_on_pair_value_first()
        {
            var aaron = new Player
            {
                Name = "Aaron",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Hearts),
                    new Card(CardValue.Three, CardSuit.Diamonds),
                    new Card(CardValue.Ace, CardSuit.Clubs),
                    new Card(CardValue.King, CardSuit.Diamonds),
                    new Card(CardValue.Queen, CardSuit.Hearts)
                    )
            };

            var stefan = new Player
            {
                Name = "Stefan",
                Hand = new Hand
                    (
                    new Card(CardValue.Five, CardSuit.Clubs),
                    new Card(CardValue.Five, CardSuit.Diamonds),
                    new Card(CardValue.Two, CardSuit.Hearts),
                    new Card(CardValue.Three, CardSuit.Spades),
                    new Card(CardValue.Four, CardSuit.Spades)
                    )
            };

            var players = new List<Player> { aaron, stefan };
            var pokerGame = new Game(players);

            var winner = pokerGame.GetWinner();

            Assert.Equal(stefan, winner);
        }

        [Fact]
        public void Stefan_all_same_value_cards_results_in_tie()
        {
            var aaron = new Player
            {
                Name = "Aaron",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Hearts),
                    new Card(CardValue.Three, CardSuit.Diamonds),
                    new Card(CardValue.Ace, CardSuit.Clubs),
                    new Card(CardValue.King, CardSuit.Diamonds),
                    new Card(CardValue.Queen, CardSuit.Hearts)
                    )
            };

            var stefan = new Player
            {
                Name = "Stefan",
                Hand = new Hand
                    (
                    new Card(CardValue.Three, CardSuit.Clubs),
                    new Card(CardValue.Three, CardSuit.Diamonds),
                    new Card(CardValue.Ace, CardSuit.Hearts),
                    new Card(CardValue.King, CardSuit.Spades),
                    new Card(CardValue.Queen, CardSuit.Spades)
                    )
            };

            var players = new List<Player> { aaron, stefan };
            var pokerGame = new Game(players);

            //var winners = pokerGame.GetWinners();

            //Assert.Equal(2, winners.Count());
            //Assert.Contains(aaron, winners);
            //Assert.Contains(stefan, winners);
        }
    }
}
