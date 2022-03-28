using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackApp2._0
{
    public class Dealer
    {
        public static List<Dealer> m_dealers = new List<Dealer>();
        private static int dealerNum = 0;
        private static List<Card> emptyHand = new List<Card>();

        private int m_id;
        private int m_gameId;
        private List<Card> m_hand;
        private bool m_standing;

        public Dealer(int gameId)
        {
            dealerNum++;
            m_id = dealerNum;
            m_gameId = gameId;
            m_hand = new List<Card>();
            m_dealers.Add(this);
            m_standing = false;
        }

        // DEALER GETTERS
        public int getGameId()
        {
            return m_gameId;
        }

        public List<Card> getHand()
        {
            return m_hand;
        }

        // GAME UTILITIES
        public void reShoeDeck()
        {
            GameById(m_gameId).reShoeDeck();
        }

        public void shuffleDeck()
        {
            GameById(m_gameId).getGameDeck().Shuffle();
        }

        public int playerTotal(Player player)
        {
            return PlayerById(player.getId()).getHandTotal();
        }

        public int dealerTotal()
        {
            int handTotalA = 0;
            int handTotalB = 0;

            foreach (Card card in m_hand)
            {
                if (card.getNumber() == 1)
                {
                    handTotalA += 1;
                    handTotalB += 10;
                }
                else
                {
                    handTotalA += ((int)card.getNumber() - 1);
                    handTotalB += ((int)card.getNumber() - 1);
                }
            }

            if (handTotalA == 21 || (handTotalA < 21 && handTotalA >= handTotalB))
            {
                return handTotalA;
            }
            else if (handTotalB == 21 || (handTotalB < 21 && handTotalB >= handTotalA))
            {
                return handTotalB;
            }
            else
            {
                return handTotalA;
            }
        }

        // GAME LOGIC FUNCTIONS
        public bool checkBet(Player player, int bet)
        {
            int playerChips = GameById(m_gameId).getPlayer1().getChips();
            
            if (playerChips >= bet)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }

        public void takeBet(Player player, int bet)
        {
            int playerChips = 0;
            int newChipTotal = 0;

            // if playerX is not null and their ID matches the parameter then take their bet
            if (GameById(m_gameId).getPlayer1() != null && GameById(m_gameId).getPlayer1().getId() == player.getId())
            {
                playerChips = GameById(m_gameId).getPlayer1().getChips();
                newChipTotal = playerChips - bet;
                GameById(m_gameId).getPlayer1().setChipsBet(bet);
                GameById(m_gameId).getPlayer1().setChips(newChipTotal);
            }
            if (GameById(m_gameId).getPlayer2() != null && GameById(m_gameId).getPlayer2().getId() == player.getId())
            {
                playerChips = GameById(m_gameId).getPlayer2().getChips();
                newChipTotal = playerChips - bet;
                GameById(m_gameId).getPlayer2().setChipsBet(bet);
                GameById(m_gameId).getPlayer1().setChips(newChipTotal);
            }
            if (GameById(m_gameId).getPlayer3() != null && GameById(m_gameId).getPlayer3().getId() == player.getId())
            {
                playerChips = GameById(m_gameId).getPlayer3().getChips();
                newChipTotal = playerChips - bet;
                GameById(m_gameId).getPlayer3().setChipsBet(bet);
                GameById(m_gameId).getPlayer1().setChips(newChipTotal);
            }
            if (GameById(m_gameId).getPlayer4() != null && GameById(m_gameId).getPlayer4().getId() == player.getId())
            {
                playerChips = GameById(m_gameId).getPlayer4().getChips();
                newChipTotal = playerChips - bet;
                GameById(m_gameId).getPlayer4().setChipsBet(bet);
                GameById(m_gameId).getPlayer1().setChips(newChipTotal);
            }
        }

        public void clearHands()
        {
            emptyHand = new List<Card>();
            // if playerX is not null empty their hand
            if (GameById(m_gameId).getPlayer1() != null)
            {
                GameById(m_gameId).getPlayer1().setHand(emptyHand);
            }
            if (GameById(m_gameId).getPlayer2() != null)
            {
                GameById(m_gameId).getPlayer2().setHand(emptyHand);
            }
            if (GameById(m_gameId).getPlayer3() != null)
            {
                GameById(m_gameId).getPlayer3().setHand(emptyHand);
            }
            if (GameById(m_gameId).getPlayer4() != null)
            {
                GameById(m_gameId).getPlayer4().setHand(emptyHand);
            }
        }

        public void dealHands()
        {
            // if playerX is not null empty their hand
            if (GameById(m_gameId).getPlayer1() != null)
            {
                GameById(m_gameId).getPlayer1().setHand(emptyHand);
            }
            if (GameById(m_gameId).getPlayer2() != null)
            {
                GameById(m_gameId).getPlayer2().setHand(emptyHand);
            }
            if (GameById(m_gameId).getPlayer3() != null)
            {
                GameById(m_gameId).getPlayer3().setHand(emptyHand);
            }
            if (GameById(m_gameId).getPlayer4() != null)
            {
                GameById(m_gameId).getPlayer4().setHand(emptyHand);
            }

            for (int x = 0; x < 2; x++)
            {
                dealerHit();

                // if playerX is not null give them a card
                if (GameById(m_gameId).getPlayer1() != null)
                {
                    Card aCard = GameById(m_gameId).getGameDeck().drawCard();
                    GameById(m_gameId).getPlayer1().addToHand(aCard);
                }
                if (GameById(m_gameId).getPlayer2() != null)
                {
                    Card aCard = GameById(m_gameId).getGameDeck().drawCard();
                    GameById(m_gameId).getPlayer2().addToHand(aCard);
                }
                if (GameById(m_gameId).getPlayer3() != null)
                {
                    Card aCard = GameById(m_gameId).getGameDeck().drawCard();
                    GameById(m_gameId).getPlayer3().addToHand(aCard);
                }
                if (GameById(m_gameId).getPlayer4() != null)
                {
                    Card aCard = GameById(m_gameId).getGameDeck().drawCard();
                    GameById(m_gameId).getPlayer4().addToHand(aCard);
                }
            }                
        }

        public void dealerHit()
        {
            m_hand.Add(GameById(m_gameId).getGameDeck().drawCard());
        }

        public void dealerStand()
        {
            m_standing = true;
        }

        public bool dealerIsStanding()
        {
            return m_standing;
        }

        public void playerHit(Player player)
        {
            PlayerById(player.getId()).addToHand(GameById(m_gameId).getGameDeck().drawCard());
        }

        public void playerStand(Player player, bool standing)
        {
            PlayerById(player.getId()).setStanding(standing);
        }

        public void split()
        {

        }

        public void dealerTurn()
        {
            while (!dealerIsStanding())
            {
                int total = dealerTotal();

                if (total < 17)
                {
                    dealerHit();
                }
                else
                {
                    dealerStand();
                }
            }            
        }

        public void checkWinner()
        {
            int player1_Total;
            int player2_Total;
            int player3_Total;
            int player4_Total;
            int dealer_Total = dealerTotal();

            if (dealer_Total == 21)
            {
                // if playerX is not null empty their hand
                if (GameById(m_gameId).getPlayer1() != null)
                {
                    GameById(m_gameId).getPlayer1().setWinner(false);
                }
                if (GameById(m_gameId).getPlayer2() != null)
                {
                    GameById(m_gameId).getPlayer2().setWinner(false);
                }
                if (GameById(m_gameId).getPlayer3() != null)
                {
                    GameById(m_gameId).getPlayer3().setWinner(false);
                }
                if (GameById(m_gameId).getPlayer4() != null)
                {
                    GameById(m_gameId).getPlayer4().setWinner(false);
                }
            }
            else
            {
                if (GameById(m_gameId).getPlayer1() != null)
                {
                    player1_Total = GameById(m_gameId).getPlayer1().getHandTotal();

                    if ((player1_Total > dealerTotal() && dealerTotal() < 21) && player1_Total <= 21)
                    {
                        GameById(m_gameId).getPlayer1().setWinner(true);
                    }
                }
                if (GameById(m_gameId).getPlayer2() != null)
                {
                    player2_Total = GameById(m_gameId).getPlayer2().getHandTotal();

                    if (player2_Total > dealerTotal() && player2_Total <= 21)
                    {
                        GameById(m_gameId).getPlayer2().setWinner(true);
                    }
                }
                if (GameById(m_gameId).getPlayer3() != null)
                {
                    player3_Total = GameById(m_gameId).getPlayer3().getHandTotal();

                    if (player3_Total > dealerTotal() && player3_Total <= 21)
                    {
                        GameById(m_gameId).getPlayer3().setWinner(true);
                    }
                }
                if (GameById(m_gameId).getPlayer4() != null)
                {
                    player4_Total = GameById(m_gameId).getPlayer4().getHandTotal();

                    if (player4_Total > dealerTotal() && player4_Total <= 21)
                    {
                        GameById(m_gameId).getPlayer4().setWinner(true);
                    }
                }
            }
        }

        // UTILITY FUNCTIONS
        public static Dealer DealerByGameId(int gameId)
        {
            Dealer? thisDealer = null;

            foreach (Dealer dealer in m_dealers)
            {
                if (gameId == dealer.getGameId())
                {
                    thisDealer = dealer;
                }
            }

            return thisDealer;
        }

        public static Game GameById(int gameId)
        {
            Game? thisGame = null;

            foreach (Game game in Game.m_games)
            {
                if (gameId == game.getID())
                {
                    thisGame = game;
                }
            }
            return thisGame;
        }

        public static Player PlayerById(int playerId)
        {
            Player? thisPlayer = null;

            foreach (Player player in Player.m_players)
            {
                if (playerId == player.getId())
                {
                    thisPlayer = player;
                }
            }
            return thisPlayer;
        }
    }
}
