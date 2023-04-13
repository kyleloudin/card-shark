using System;
using BlackIsJack.ViewModel;

namespace BlackIsJack.DAO
{
	public interface IPlayer
	{
		void placeYourBet();

		List<Card> playerCards();

		List<Card> dealerCards();

		int playerHandValue();

		int dealerHandValue();

		void doubleDown(Deck playingDeck);

		Card reveealDealerUpCard();

		void dealerHits(Deck playingDeck);

        void playerHits(Deck deckInUse);

    }
}

