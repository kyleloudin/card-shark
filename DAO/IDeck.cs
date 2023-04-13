using System;
using BlackIsJack.ViewModel;

namespace BlackIsJack.DAO
{
	public interface IDeck
	{
		List<Card> getCards(Deck deck);

        void shuffle(List<Card> cards);

		int listSize(List<Card> cards);

		void sortCardsByRank(List<Card> cards);

		void sortCardsByRankAndSuit(List<Card> cards);

    }
}

