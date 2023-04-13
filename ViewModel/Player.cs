using System;
namespace BlackIsJack.ViewModel
{
	public class Player : Deck
	{
        public String name;

        public List<Card> hand;

        public double money;

        public double playerBet;

        public int handValue;

        public Player()
        {
            this.name = "";
            this.money = 0;
            this.hand = new List<Card>();
        }

        public string getName()
        {
            return name;
        }

        public List<Card> getHand()
        {
            return hand;
        }

        public double getMoney()
        {
            return money;
        }

        public double getPlayerBet()
        {
            return playerBet;
        }

        public int getHandValue(List<Card> cards)
        {
            int totalValue = 0;
            int aces = 0;
            foreach (Card card in cards)
            {
                switch (card.getRank())
                {
                    case "2" : totalValue += 2; break;
                    case "3" : totalValue += 3; break;
                    case "4" : totalValue += 4; break;
                    case "5" : totalValue += 5; break;
                    case "6" : totalValue += 6; break;
                    case "7" : totalValue += 7; break;
                    case "8" : totalValue += 8; break;
                    case "9" : totalValue += 9; break;
                    case "10" :
                    case "JACK" :
                    case "QUEEN" :
                    case "KING" :
                        totalValue += 10; break;
                    case "ACE" : aces += 1; break;
                }
            }
            for (int i = 0; i < aces; i++)
            {
                if (totalValue > 10)
                {
                    totalValue += 1;
                }
                else
                {
                    totalValue += 11;
                }
            }
            return totalValue;
        }

        internal void setPlayerBet(double playerBet)
        {
            this.playerBet = playerBet;
        }

        public void subtractMoney()
        {
            money -= playerBet;
        }

        public void addMoney()
        {
            money += playerBet;
        }

        public void doubleBet()
        {
            playerBet += playerBet;
        }

        public void draw(Deck deckInUse)
        {
            hand.Add(deckInUse.getCard(0));
            deckInUse.removeCard(0);
        }

    }
}

