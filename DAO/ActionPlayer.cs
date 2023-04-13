using System;
using System.Numerics;
using BlackIsJack.ViewModel;

namespace BlackIsJack.DAO
{
    public class ActionPlayer : IPlayer
    {
        Player player = new Player();
        Player dealer = new Player();

        public List<Card> dealerCards()
        {
            return dealer.getHand();
        }

        public int dealerHandValue()
        {
            return dealer.getHandValue(dealer.getHand());
        }

        public void dealerHits(Deck playingDeck)
        {
            while (dealerHandValue() < 17 && playerHandValue() <= 21)
            {
                dealer.draw(playingDeck);
            }
        }

        public void doubleDown(Deck playingDeck)
        {
            if (playerHandValue() == 10 || playerHandValue() == 11)
            {
                int remainingMoney = (int)(player.getMoney() - player.getPlayerBet());
                if (remainingMoney >= player.getPlayerBet())
                {
                    player.doubleBet();
                    player.draw(playingDeck);

                }
                else if (remainingMoney < player.getPlayerBet())
                {
                    return;
                }
            }
        }

        public void placeYourBet()
        {
            if (player.getPlayerBet() > player.getMoney())
            {
                placeYourBet();
            }
            player.setPlayerBet(player.getPlayerBet());
        }

        public List<Card> playerCards()
        {
            return player.getHand();
        }

        public int playerHandValue()
        {
            return player.getHandValue(player.getHand());
        }

        public Card reveealDealerUpCard()
        {
            return dealerCards()[0];
        }

        public void playerHits(Deck deckInUse)
        {
            playerCards().Add(deckInUse.getCard(0));
            deckInUse.removeCard(0);
        }

    }
}

