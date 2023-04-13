using System;
using BlackIsJack.ViewModel;
using System.Collections;

namespace BlackIsJack.DAO
{
	public class ActionDeck
	{
        public List<Card> getCards(Deck deck)
        {
            return deck.getCards();
        }

        public int listSize(List<Card> cards)
        {
            return cards.Count();
        }

        public void shuffle(List<Card> cards)
        {
            int lastIndex = cards.Count() - 1;
            while (lastIndex > 0)
            {
                Card tempValue = cards[lastIndex];
                int randomIndex = new Random().Next(0, lastIndex);
                cards[lastIndex] = cards[randomIndex];
                cards[randomIndex] = tempValue;
                lastIndex--;
            }

        }

        public void sortCardsByRank(List<Card> cards)
        {
            ArrayList RANKS = new ArrayList() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "JACK", "QUEEN", "KING", "ACE" };
            cards.Sort((left, right) => RANKS.IndexOf(left.getRank()).CompareTo(RANKS.IndexOf(right.getRank())));
        }

        public void sortCardsByRankAndSuit(List<Card> cards)
        {
            ArrayList SUITS = new ArrayList() { "CLUBS", "DIAMONDS", "HEARTS", "SPADES" };
            sortCardsByRank(cards);
            cards.Sort((left, right) => SUITS.IndexOf(left.getSuit()).CompareTo(SUITS.IndexOf(right.getSuit())));
        }
    }
}

