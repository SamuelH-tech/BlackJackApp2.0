using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackApp2._0
{
    public class Player
    {
        public static List<Player> m_players = new List<Player>();

        private const int LOWER_LIMIT = 100000001;
        private const int UPPER_LIMIT = 999999999;        
        private const int NEW_PLAYER_DEFAULT = 0;
        private Random rnd = new Random();

        private int m_id;
        private string m_name;
        private List<Card> m_hand;
        private int m_handTotal;
        private int m_chips;
        private int m_chipsBet;
        private int m_handsWon;
        private int m_handsLost;
        private int m_chipsWon;
        private bool m_standing;
        private bool m_isWinner;
        
        public Player()
        {
            m_id = rnd.Next(LOWER_LIMIT, UPPER_LIMIT);
            m_name = null;
            m_hand = new List<Card>();
            m_chips = 5000;
            m_chipsBet = 0;
            m_handsWon = NEW_PLAYER_DEFAULT;
            m_handsLost = NEW_PLAYER_DEFAULT;
            m_chipsWon = NEW_PLAYER_DEFAULT;
            m_standing = false;
            m_players.Add(this);
        }

        public Player(string name)
        {
            m_id = rnd.Next(LOWER_LIMIT, UPPER_LIMIT);
            m_name = name;
            m_hand = new List<Card>();
            m_chips = 5000;
            m_chipsBet = 0;
            m_handsWon = NEW_PLAYER_DEFAULT;
            m_handsLost = NEW_PLAYER_DEFAULT;
            m_chipsWon = NEW_PLAYER_DEFAULT;
            m_standing = false;
            m_players.Add(this);
        }

        public int getId()
        {
            return m_id;
        }
        public List<Card> getHand()
        {
            return m_hand;
        }
        public void setHand(List<Card> hand)
        {
            m_hand = hand;
        }
        public int getHandTotal()
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
                else if ((int)card.getNumber() > 10)
                {
                    handTotalA += 10;
                    handTotalB += 10;
                }
                else
                {
                    handTotalA += ((int)card.getNumber());
                    handTotalB += ((int)card.getNumber());
                }
            }

            if(handTotalA  == 21 || (handTotalA < 21 && handTotalA >= handTotalB))
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
        public string getName()
        {
            return m_name;
        }
        public void setName(string name)
        {
            m_name = name;
        }
        public int getChips()
        {
            return m_chips;
        }
        public void setChips(int chips)
        {
            m_chips = chips;
        }
        public int getChipsBet()
        {
            return m_chipsBet;
        }
        public void setChipsBet(int chips)
        {
            m_chipsBet = chips;
        }
        public int getHandsWon()
        {
            return m_handsWon;
        }
        public void handWon()
        {
            m_handsWon++;
        }
        public int getHandsLost()
        {
            return m_handsLost;
        }
        public void handLost()
        {
            m_handsLost++;
        }
        public int getChipsWon()
        {
            return m_chipsWon;
        }
        public void setChipsWon(int chipsWon)
        {
            m_chipsWon = chipsWon;
        }
        public void addToHand(Card aCard)
        {
            m_hand.Add(aCard);
        }
        public void placeBet(int bet)
        {
            m_chipsBet = bet;
        }
        public void setStanding(bool standing)
        {
            m_standing = standing;
        }
        public bool getStanding()
        {
            return m_standing;
        }
        public void setWinner(bool isWinner)
        {
            m_isWinner = isWinner;
        }
        public bool getWinner()
        {
            return m_isWinner;
        }
    }
}
