using LingoGame;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;


namespace LingoWeb.Controllers;

public class HomeController : Controller
{
    private IDistributedCache _cache;
    private readonly GameContainer _games;

    public HomeController(IDistributedCache cache, GameContainer games)
    {
        _cache = cache;
        _games = games;
    }

    public IActionResult Index()
    {
        _games.ClearFinished();
        var userId = _cache.GetString("userId");
        if (string.IsNullOrEmpty(userId))
        {
            userId = Guid.NewGuid().ToString();
            _cache.SetString("userId", userId);
        }
        Game game = _games.NewGame(userId);
        return View(game);
    }
    [HttpPost]
    public IActionResult Index(string[] guess)
    {          
        var userId = _cache.GetString("userId");
        if (string.IsNullOrEmpty(userId))
        {
            return RedirectToAction(nameof(Index));
        }
        var game = _games.GetGame(userId);
        
        if (game!.IsFinished) return View(game);
        LingoWord word = new LingoWord(string.Join("", guess));
        try
        {
            game?.Guess(word);
        }
        catch
        {
           
        }
        return View(game);
    }
    
}
