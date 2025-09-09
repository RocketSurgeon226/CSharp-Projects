namespace finalProject;

public class Player{
    public string Name {get; set;}
    public int Wins {get; set;}
    public int Losses {get; set;}
    public int Ties {get; set;}
    public int Points {get; set;}
    public PlayerLevel Level => GetLevel();

    public Player(string name, int wins = 0, int losses = 0, int ties = 0, int points = 0){
        Name = name;
        Wins = wins;
        Losses = losses;
        Ties = ties;
        Points = points;
    }

    private PlayerLevel GetLevel(){
        return Points switch{
            >= 100 => PlayerLevel.Platinum,
            >= 75 => PlayerLevel.Gold,
            >= 50 => PlayerLevel.Silver,
            >= 25 => PlayerLevel.Bronze,
            _ => PlayerLevel.Beginner
        };
    }

    public int TotalGames => Wins + Losses + Ties;
    public double WinLossRatio => Losses == 0? Wins : Math.Round((double)Wins / Losses, 2);
}