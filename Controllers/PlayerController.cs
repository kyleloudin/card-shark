//using System;
//using BlackIsJack.DAO;
//using BlackIsJack.ViewModel;
//using Microsoft.AspNetCore.Mvc;

//namespace BlackIsJack.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class PlayerController : ControllerBase
//    {
//        private IPlayer iPlayer;

//        public PlayerController(DAO.IPlayer iPlayer)
//        {
//            this.iPlayer = iPlayer;
//        }

//        void placeYourBet();

//        List<Card> playerCards();

//        List<Card> dealerCards();

//        int playerHandValue();

//        int dealerHandValue();

//        void doubleDown(Deck playingDeck);

//        Card reveealDealerUpCard();

//        void dealerHits(Deck playingDeck);

//        void playerHits(Deck deckInUse);

//    }
//}
