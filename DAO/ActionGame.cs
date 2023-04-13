using System;
using System.Collections;
using System.Numerics;
using BlackIsJack.ViewModel;

namespace BlackIsJack.DAO
{
	public class ActionGame : IGame, ICard, IDeck
	{
        public void startTheHand(Player player, Player dealer, Deck playingDeck)
        {
            player.draw(playingDeck);
            dealer.draw(playingDeck);
            player.draw(playingDeck);
            dealer.draw(playingDeck);
        }

        public void compareHandValues(Player player, Player dealer)
        {
            if (dealer.getHandValue(dealer.getCards()) > 21)
            {
                player.addMoney();
            }
            else if (dealer.getHandValue(dealer.getCards()) > player.getHandValue(player.getCards())
                    && dealer.getHandValue(dealer.getCards()) >= 17 && dealer.getHandValue(dealer.getCards()) <= 21)
            {
                player.subtractMoney();
            }
            else if (player.getHandValue(player.getCards()) == dealer.getHandValue(dealer.getCards()))
            {
                return;
            }
            else if (player.getHandValue(player.getCards()) > dealer.getHandValue(dealer.getCards())
                && player.getHandValue(player.getCards()) <= 21)
            {
                player.addMoney();
            }
        }

        public void timeToShuffle(Deck playingDeck, Deck discardPile)
        {
            if (playingDeck.getCards().Count() <= 15)
            {
               discardCards(playingDeck.getCards(), discardPile);
               discardCards(discardPile.getCards(), playingDeck);
               shuffle(playingDeck.getCards());
            }
        }

        public List<Card> getCards(Deck deck)
        {
            return deck.getCards();
        }

        public Card getCard(List<Card> cards, int i)
        {
            return cards[i];
        }

        public void discardCards(List<Card> cards, Deck discardDeck)
        {
            int deckSize = cards.Count;
            for (int i = 0; i < deckSize; i++)
            {
                discardDeck.newCard(getCard(cards, i));
                cards.RemoveAt(0);
            }
        }

        public void clearTheTable(Player player, Player dealer, Deck discardPile)
        {
            discardCards(player.getCards(), discardPile);
            discardCards(dealer.getCards(), discardPile);
        }

        public void draw(List<Card> cards, Deck deckInUse)
        {
            cards.Add(deckInUse.getCard(0));
            deckInUse.removeCard(0);
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

