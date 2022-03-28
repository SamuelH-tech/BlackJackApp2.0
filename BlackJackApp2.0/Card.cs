using System;
using static BlackJackApp2._0.Enums;

namespace BlackJackApp2._0
{
    public class Card
    {
        private Suit m_suit;
        private CardNumber m_number;
        public Card(Suit suit, CardNumber number)
        {
            m_suit = suit;
            m_number = number;
        }

        public string getSuit()
        {
            return m_suit.ToString();
        }

        public int getNumber()
        {
            return (int)m_number;
        }

        public string toString()
        {
            string message = getSuit()+ " " + getNumber();

            return message;
        }
    }
}
