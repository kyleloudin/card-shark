using System;
using BlackIsJack.ViewModel;
using System.Collections.Generic;
using System.Collections;

namespace BlackIsJack.ViewModel
{

    public class Deck
    {
        private List<Card> CARDS;
        private int numCards;
        private Constants _Constants;

        public Deck()
        {
            CARDS = new List<Card>();
            _Constants = new Constants();
        }

        public Deck(int numDecks)
        {
            _Constants = new Constants();
            numCards = numDecks * 52;
            CARDS = new List<Card>(new Card[numCards]);

            for (int i = 0; i < numDecks; i++)
            {
                foreach (string suit in _Constants.SUITS)
                {
                    foreach (string rank in _Constants.RANKS)
                    {
                        CARDS.Add(new Card(rank, suit));
                    }
                }
            }
        }

        public Card getCard(int i)
        {
            return CARDS[i];
        }

        public List<Card> getCards()
        {
            return CARDS;
        }

        public void removeCard(int i)
        {
            CARDS.RemoveAt(i);
        }

        public void newCard(Card newCard)
        {
            CARDS.Add(newCard);
        }

    }
}


