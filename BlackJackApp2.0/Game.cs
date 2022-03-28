using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackApp2._0
{
    public class Game
    {
        public static List<Game> m_games = new List<Game>();

        private static int gameNum = 0;

        private int m_gameId;
        private Deck m_gameDeck;
        private Dealer m_dealer;
        private int m_turnById;
        private Player? m_player1; // should this be int?
        private Player? m_player2;
        private Player? m_player3;
        private Player? m_player4;

        public Game(Player player1)
        {
            
            gameNum++;
            m_gameId = gameNum;
            Dealer aDealer = new Dealer(m_gameId);
            m_gameDeck = Deck.getMainDeck();
            m_dealer = aDealer;
            m_player1 = player1;
            m_turnById = player1.getId();
            m_player2 = null;
            m_player3 = null;
            m_player4 = null;

            m_games.Add(this);
        }

        public int getID()
        {
            return m_gameId;
        }
        public Deck getGameDeck()
        {
            return m_gameDeck;
        }
        public int getTurnById()
        {
            return m_turnById;
        }
        public Player? getPlayer1()
        {
            return m_player1;
        }
        public void setPlayer1(Player player1)
        {
            m_player1 = player1;
        }
        public Player? getPlayer2()
        {
            return m_player2;
        }
        public void setPlayer2(Player player2)
        {
            m_player2 = player2;
        }
        public Player? getPlayer3()
        {
            return m_player3;
        }
        public void setPlayer3(Player player3)
        {
            m_player3 = player3;
        }
        public Player? getPlayer4()
        {
            return m_player4;
        }
        public void setPlayer4(Player player4)
        {
            m_player4 = player4;
        }
        public void reShoeDeck()
        {
            Deck aDeck = Deck.getMainDeck();
            m_gameDeck = aDeck;
        }
    }
}
