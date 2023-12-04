public class Game
{
    private static int gameCount = 0;
    public int GameId { get; }

    public Game()
    {
        GameId = ++gameCount;
    }
}
