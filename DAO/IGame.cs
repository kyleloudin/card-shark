using System;
using BlackIsJack.ViewModel;

namespace BlackIsJack.DAO
{
	public interface IGame
	{
		void startTheHand(Player player, Player dealer, Deck playingDeck);

		void compareHandValues(Player player, Player dealer);

        void timeToShuffle(Deck playingDeck, Deck discardPile);

		void clearTheTable(Player player, Player dealer, Deck discardPile);
    }
}

