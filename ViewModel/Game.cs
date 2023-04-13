using System;
namespace BlackIsJack.ViewModel
{
	public class Game
	{
        Deck playingDeck;
        Deck discardPile;
        Player player;
        Player dealer;

        public Game()
        {
           playingDeck = new Deck(1);
           discardPile = new Deck();
           player = new Player();
           dealer= new Player();
        }
    }
}

