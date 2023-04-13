using System;
namespace BlackIsJack.ViewModel
{
	public class Card
	{
        public string rank
        {
            get;
        }
        public string suit
        {
            get;
        }
        

        public Card(string rank, string suit)
		{
            this.rank = rank;
            this.suit = suit;
		}

        public string getRank()
        {
            return rank;
        }

        public string getSuit()
        {
            return suit;
        }
    }
}