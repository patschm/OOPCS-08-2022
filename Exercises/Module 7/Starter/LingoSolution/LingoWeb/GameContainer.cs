namespace LingoWeb;

// Dirty trick. Better would be serializing game objects in session state.
public class GameContainer
{
    private readonly Dictionary<string, Game> _games = new Dictionary<string, Game>();

    public Game NewGame(string userid)
    {
        var game = new Game();
        if (!_games.TryAdd(userid, game))
        {
            _games[userid] = game;
        }
        return game;
    }
    public Game? GetGame(string userId)
    {
        if (_games.TryGetValue(userId, out var game))
        {
            return game;
        }
        return null;
    }
    public void ClearFinished()
    {
        var toBeDeleted = _games.Where(g => g.Value.IsFinished == true);
        foreach(var item in toBeDeleted)
        {
            _games.Remove(item.Key);
        }
    }
}
