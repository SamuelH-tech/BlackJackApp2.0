using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackApp2._0
{
    public class Deck
    {
        public static Deck MainDeck = new Deck(new Deck(), new Deck(), new Deck(), new Deck());

        private List<Card> m_deck = new List<Card>();

        private Deck(Deck a, Deck b, Deck c, Deck d)
        {
            List<Deck> decks = new List<Deck>() { a, b, c, d };

            for (int x = 0; x < decks.Count; x++)
            {
                List<Card> currentDeck = decks[x].getDeck();

                for (int y = 0; y < currentDeck.Count; y++)
                {
                    m_deck.Add(currentDeck[y]);
                }
            }
        }
        private Deck() 
        {
            m_deck = BuildBaseDeck();           
        }
        public static Deck getMainDeck()
        {
            Deck aDeck = MainDeck;

            return aDeck;
        }

        private List<Card> getDeck()
        {
            return m_deck;
;       }

        private static List<Card> BuildBaseDeck() 
        {
            List<Card> newDeck = new List<Card>();

            newDeck = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                .Select(c => new Card((Enums.Suit)s, (Enums.CardNumber)c){ }))
                .ToList();

            return newDeck;
        }

        public void Shuffle()
        {
            m_deck  = m_deck.OrderBy(c => Guid.NewGuid())
                         .ToList();
        }

        public Card drawCard()
        {
            Card aCard = getDeck()[0];
            getDeck().RemoveAt(0);
            return aCard;
        }

        //HIT
        //STAND
        //DRAW CARD
    }
}
