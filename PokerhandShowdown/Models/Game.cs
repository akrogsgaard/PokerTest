using System;
using System.Collections.Generic;

namespace PokerhandShowdown.Models
{
    public class Game
    {
        private readonly List<Player> _players;

        public Game(List<Player> players)
        {
            if (players == null) throw new ArgumentNullException("players");
            _players = players;
        }

        public List<Player> Players { get { return _players; } }

        public Player GetWinner()
        {
            Player winner = null;
            foreach (var player in _players)
            {
                if (winner == null)
                    winner = player;

                if (player.Hand.Value >= winner.Hand.Value)
                    winner = player;
            }

            return winner;
        }
    }
}
