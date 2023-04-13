using System;
using BlackIsJack.ViewModel;

namespace BlackIsJack.DAO
{
	public interface ICard
	{

		void discardCards(List<Card> cards, Deck discardDeck);

		void draw(List<Card> cards, Deck deckInUse);

		Card getCard(List<Card> cards, int i);
    }
}

