class Program
{
    static void Main()
    {
        // Створення об'єктів класу GameAccount
        GameAccount player1 = new GameAccount("Player1");
        GameAccount player2 = new GameAccount("Player2");

        // Створення об'єктів класу 
        Game game1 = new Game();
        Game game2 = new Game();

        // Імітація декількох ігор
        player1.WinGame("Player2", 20);
        player2.LoseGame("Player1", 10);
        player1.LoseGame("Player2", 15);
        player2.WinGame("Player1", 25);

        // Виведення статистики для кожного гравця
        player1.GetStats();
        player2.GetStats();
    }
}
