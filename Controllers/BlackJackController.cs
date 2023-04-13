using System.Numerics;
using BlackIsJack.DAO;
using BlackIsJack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BlackIsJack.Controllers;

[ApiController]
[Route("[controller]")]
public class BlackJackController : ControllerBase
{
    private ICard _card;
    private IDeck _deck;
    private IGame _game;
    private IPlayer _player;

    public BlackJackController(ICard card, IDeck deck, IGame game, IPlayer player)
    {
        _card = card;
        _deck = deck;
        _game = game;
        _player = player;
    }

    //public IActionResult Index(Deck discardPile, Player dealer, Player player)
    //{
    //    _game.clearTheTable(player, dealer, discardPile);
    //    return void;
    //}


    [HttpGet]
    public IEnumerable<Card> Get()
    {
        return 
            Enumerable
            .Range(1, 1)
            .Select(index => new Card("2", "Clubs"))
            .ToArray();
    }
}