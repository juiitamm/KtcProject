using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KtcProject1.Models
{
    public class Game
    {
        private const int MIN_PLAYERS = 2;

        [ScaffoldColumn(false)]
        public int Match { get; set; }
        
        [ScaffoldColumn(false)]
        public int Round { get; set; }

        public List<Player> Players { get; set; }

        public Game()
            :this(MIN_PLAYERS)
        {

        }

        public Game(int playerCount)
        {
            if (playerCount < 2) throw new Exception("Cannot be less than two players in a game");

            AddPlayers(playerCount);
            Round = 1;
            Match = 1;
        }

        private void AddPlayers(int playerCount)
        {
            Players = new List<Player>();
            for (int i = 0; i < playerCount; i++)
            {
                Players.Add(new Player());
            }
        }
    }
}