using System;
using System.Collections.Generic;

public class GameAccount
{
    public string UserName { get; set; }
    public int CurrentRating { get; set; }
    public int GamesCount { get; set; }
    private List<Dictionary<string, object>> gameHistory;

    public GameAccount(string username)
    {
        UserName = username;
        CurrentRating = 1000; // Початковий рейтинг
        GamesCount = 0;
        gameHistory = new List<Dictionary<string, object>>();
    }

    private void ValidateRating(int rating)
    {
        if (rating < 0)
        {
            throw new ArgumentException("Рейтинг не може бути від'ємним");
        }
    }

    public void WinGame(string opponentName, int rating)
    {
        ValidateRating(rating);
        CurrentRating += rating;
        GamesCount++;
        gameHistory.Add(new Dictionary<string, object>
        {
            { "opponent", opponentName },
            { "result", "Win" },
            { "rating", rating },
            { "index", GamesCount }
        });
    }

    public void LoseGame(string opponentName, int rating)
    {
        ValidateRating(rating);
        CurrentRating = Math.Max(1, CurrentRating - rating);
        GamesCount++;
        gameHistory.Add(new Dictionary<string, object>
        {
            { "opponent", opponentName },
            { "result", "Loss" },
            { "rating", rating },
            { "index", GamesCount }
        });
    }

    public void GetStats()
    {
        Console.WriteLine($"Статистика для гравця {UserName}:");
        Console.WriteLine("| Проти кого | Результат | Рейтинг | Індекс |");
        Console.WriteLine("|------------|------------|---------|--------|");
        foreach (var game in gameHistory)
        {
            Console.WriteLine($"| {game["opponent"]} | {game["result"]} | {game["rating"]} | {game["index"]} |");
        }
    }
}
