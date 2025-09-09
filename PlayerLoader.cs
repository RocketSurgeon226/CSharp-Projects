namespace finalProject;

public static class PlayerLoader{
    private const string FilePath = "player_log.csv";

    public static Dictionary<string, Player> LoadPlayers(){
        var players = new Dictionary<string, Player>();
        if(!File.Exists(FilePath)){
            return players;
        }

        foreach(var line in File.ReadAllLines(FilePath)){
            var parts = line.Split(',');
            if(parts.Length < 5){
                continue;
            }

            var name = parts[0].Trim();
            int.TryParse(parts[1], out int wins);
            int.TryParse(parts[2], out int losses);
            int.TryParse(parts[3], out int ties);
            int.TryParse(parts[4], out int points);
            players[name] = new Player(name, wins, losses, ties, points);
        }
        return players;
    }

    public static void SavePlayers(Dictionary<string, Player> players){
        try{
            using var writer = new StreamWriter(FilePath);
            foreach(var player in players.Values){
                writer.WriteLine($"{player.Name},{player.Wins},{player.Losses},{player.Ties},{player.Points}");
            }
        }catch(Exception ex){
                Console.WriteLine($"Sorry, the game could not be saved.\n{ex.Message}");            
        }
    }
}
