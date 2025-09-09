/*
Description: Create a menu-driven rock, paper, scissors game in C# that a user plays against the computer with the ability to save and load a game and its associated play statistics. The game will also be able to display a leader board and global statistics.

Project Files: player_log.csvDownload player_log.csv

Requirements: Create Rock.

Create a Rock, Paper, Scissors game C# project named finalProject according to the requirements specified in this document. The user plays against the computer with the ability to save and load a game and its associated play statistics. The game will also be able to display a leader board and global statistics for all players.

During a round of play the user chooses rock, paper, or scissors from a menu and the computer makes its choice randomly. For each round it is possible for the user to win, , or tie. The statistics that are to be maintained for a game are wins, losses, and ties. When a game is saved the user’s name and play statistics (wins, losses, and ties) are to be saved. When a game is loaded based on the user’s name the statistics are loaded and additional game play add to the loaded statistics.

Rock Paper Scissors: Rules

    * Rock beats scissors
    * Scissors beats paper
    * Paper beats rock

    A Player will receive 10 points for a win, and 2 for a tie. A player will lose 3 points for a loss

Menus

    For menus in the game, the user makes a selection from the menu by entering the number of their choice. If the user enters something other than a number or a number in the range of the choices provided in the menu they are to be given feedback that their choice is not valid and asked for the input again. Under no circumstance should input from the user crash the program.

    When the program is run the following title, menu, and input prompt are to be displayed.

        Welcome to Rock, Paper, Scissors!

            1. Start New Game
            2. Load Game
            3. Quit

        Enter choice:

    User Choices:

    * 1. Starts a new game and the user is prompted for their name and game play is to proceed after their name is entered. There cannot be duplicate player names. If the player submits a name that already exists then they should be prompted to provide another name.
    * 2. Loads a game and they should be taken to a prompt to enter a name that is to be used to load a saved game.
    * 3. Quits the game and the program is to exit.

    1. Start New Game

        If the user chooses to start a new game the program is to prompt the user for their name using the following prompt.

            What is your name?

        After the name is entered the program is to respond with a line that is “Hello” followed by the name of the user, a period, and the phrase “Let’s play!” Example:

            Hello Kristofferson. Let’s play!

        After the hello statement is presented to the user, game play is to proceed. Game play is described below in the Game Play section.

    2. Load Game

        If the user chooses to load an existing game the program is to prompt the user for their name using the following prompt.

            What is your name?

        After the name is entered the program is to attempt determine if saved game data for that player exists by searching through the saved game data loaded from the player log file you were given. If the player exists, the information about the game and statistics are to be loaded, a welcome back message is to be presented to the user, and game play is to proceed. The round number displayed is to be based on the number of rounds previously played. (Note: number of rounds previously played is sum of wins, losses, and ties.) Game play is described below in the Game Play section.

        The welcome back message is to be “Welcome back” followed by the user’s name, a period, and the phrase “Let’s Play!” Example:

            Welcome back Kristofferson. Let’s play!

        If the player is not found, the user is to be presented with a message indicating the game could not be found and then presented with the startup menu described at the top of the requirements. The message is to be the user name followed by “, your game could not be found.” Example:

            Kristofferson, your game could not be found.

    3. Quit

        If the user chooses to quit, the program is to exit.

Game Play

    This section describes game play.

    For each round a line that includes the round number is to be displayed followed by a menu that let’s the user choose Rock, Paper, or Scissors as their choice for the round as shown below.

        Round <round number>

            1. Rock
            2. Paper
            3. Scissors

        What will it be?

    The user makes their choice and the computer chooses randomly. The result of the round is to be displayed using the following format:

        You chose <user choice>. The computer chose <computer choice>. You <win/lose>!

    Example:

        You chose Paper. The computer chose Rock. You win!

        A Player will receive 10 points for a win, and 2 for a tie. A player will lose 3 points for a loss

        After the round the user is to be presented with the following prompt and menu.

            What would you like to do?

            1. Play Again
            2. Transfer Points to Another Player
            3. View Your Statistics
            4. View Global Statistics
            5. Quit      

            Enter choice:

        If the user chooses 1 to play again, the user is to play another round. If the user chooses 2, the player will have the option to send some of their points to another player. If the user chooses 3 to view player statistics, the current statistics for the game are to be displayed. If the user chooses 4, they are presented with a menu to view several global stats. If the user chooses 5 to quit, the game and associated statistics are to be saved to the player log and the program is to exit.

    1. Play Again

        If the user chooses to play again the next round number is to be displayed and the user is to again choose Rock, Paper, or Scissors to play the round as described above.

    2. Transfer Points

        If the user chooses to transfer points they will be asked the following to questions:

            * How many points would you like to transfer? 
            * Enter name of the Player to transfer points to:

        Your application with then add the number of points being transferred to the player receiving the points and subtract the points from the player sending the points.

        If the the player sending the points does not have enough does not have enough points, or the player receiving the points does not exist the program should show an error

        Here is example output: No Errors

            Enter Choice: 
            2

            How many points would you like to transfer? 
            10

            Enter name of the Player to transfer points to: 
            Janae

            Points Transfer Successful: Your new point balance is 37!

            What would you like to do?

            1. Play Again
            2. Transfer Points to Another Player
            3. View Your Statistics
            4. View Global Statistics
            5. Quit

            Enter Choice: 

        Here is example output: With Errors

            Enter Choice: 
            2

            How many points would you like to transfer? 
            11234567

            Enter name of the Player to transfer points to: 
            Cookie Monster

            Points Transfer Failed: Either Insufficient Points or Player Name is incorrect!


            What would you like to do?

            1. Play Again
            2. Transfer Points to Another Player
            3. View Your Statistics
            4. View Global Statistics
            5. Quit

            Enter Choice: 

    3. View Statistics

        If the user chooses to view the statistics the following information is to be displayed:

                <user name>, here are your game play statistics…
                Wins: <number of wins>
                Losses: <number of losses>
                Ties: <number of ties>
                Win/Loss Ratio: <wins divided by losses formatted to two digits to right of decimal point>
                Points: <number of points>
                Player Level: <player level: (platinum, gold, silver, bronze)>

            Example:      
            
                Kristofferson, here are your game play statistics…
                Wins: 4
                Losses: 3
                Ties: 4
                Win/Loss Ratio: 1.33
                Points: 50
                Player Lever: Silver

        After the statistics are displayed, the user is to be presented with the menu shown above that is presented after playing a round.

            What would you like to do?

                1. Play Again
                2. Transfer Points to Another Player
                3. View Your Statistics
                4. View Global Statistics
                5. Quit      

                Enter choice:

    4. View Global Statistics
        If the user chooses to view the global statistics they will be presented with the following menu played:

        ------------------
        View Global Stats
        ------------------

        1. View Top 10 Players with the Most Wins
        2. View Most Games Played
        3. View Top 10 Players with the Most Points
        4. View Players in each Level
        5. View Total Games Played
        6. View Win/Loss Ratio
        7. Quit

        Enter Choice: 

        Below are examples of the output when the user chooses options 1 through 6:

        1
        --------------------------
        Top 10 Players: Most Wins
        --------------------------
        Mina: 9 wins
        Bart: 9 wins
        Brad: 9 wins
        Tania: 9 wins
        Daria: 9 wins
        Ron: 9 wins
        Janae: 8 wins
        Rosalee: 7 wins
        Shay: 7 wins
        Enoch: 7 wins


        2
        ----------------------
        Most Games Played
        ----------------------
        Brad: 24 games played
        Janae: 22 games played
        Rosalee: 20 games played
        Bart: 19 games played
        Daria: 19 games played


        3
        -------------------------
        Top 10 Players: Most Points
        ---------------------------
        Bart: 95 points
        Ron: 92 points
        Mina: 91 points
        Janae: 91 points
        Daria: 90 points
        Shay: 82 points
        Brad: 75 points
        Rosalee: 71 points
        Enoch: 69 points
        Tania: 66 points

        4
        --------------------
        Players By Level
        --------------------

        Gold Level
        -----------------

        Mina -- Level: Gold
        Bart -- Level: Gold
        Brad -- Level: Gold
        Daria -- Level: Gold
        Shay -- Level: Gold
        Ron -- Level: Gold
        Janae -- Level: Gold


        Silver Level
        -----------------

        Rosalee -- Level: Silver
        Tania -- Level: Silver
        Enoch -- Level: Silver
        Doug -- Level: Silver
        Tyson -- Level: Silver


        Bronze Level
        -----------------

        Peter -- Level: Bronze
        Denae -- Level: Bronze
        Kristofferson -- Level: Bronze


        Beginner Level
        -----------------

        Irene -- Level: Beginner
        Sylvia -- Level: Beginner
        Alma -- Level: Beginner
        Adela -- Level: Beginner
        Anais -- Level: Beginner
        Chad -- Level: Beginner

        

        5

        ------------------------------
        Total Games Played: 298
        ------------------------------


        6

        -------------------------------
        Overall Win/Loss Ratio: 1.48
        --------------------------------

    5. Quit

        If the user chooses to quit the game, the program is to automatically save the game and associated statistics in the player_log.csv file. If there is an exception saving the file, an error message reporting the error is to be presented to the user. The message is to be “Sorry ” followed by the user’s name and “, the game could not be saved.” Additionally, the actual error provided by the Exception object is to be displayed on the next line. Example:

            Sorry Kristofferson, the game could not be saved.

        If the file saves successfully the user is to be presented with a message indicating the success of the file save. The message is to be the user’s name followed by “, your game has been saved.” Example:

            Kristofferson, your game has been saved.

        Finally, the program is to exit.

Player Log File Format

    The data in the player_log.csv file is structured in the following way:

        <player name>, <wins>, <losses>, <ties>, <points>

    Data must be saved in that format.

    Coding Style: You are encouraged to develop your application in a modular style, by creating functions to perform the major functionality of the application. This will make your code much easier to develop, maintain, and debug.

    Player Objects: You should create a Player Class to create player objects for your players. The Player constructor should accept a player name, wins, loss, ties, and points.

    Player Level: The player Level must be property in the Player Class and be an enumerated type that is set with values Platinum, Gold, Silver, Bronze, Beginner based on the number of points a player has. Levels are set based on the following:

    * Platinum: 100 or more points
    * Gold: 75 - 99 points
    * Silver: 50 - 74 points
    * Bronze: 25 - 49 points
    * Beginner: 0 - 24 points
*/

namespace finalProject;

class Program
{
    static Dictionary<string, Player> players = PlayerLoader.LoadPlayers();
    static Player currentPlayer = null;
    static Random rng = new Random();

    static void Main(string[] args)
    {
        while(true){
            Console.WriteLine("Welcome to Rock, Paper, Scissors!\n\n    1. Start New Game\n    2. Load Game\n    3. Quit\n\nEnter Choice: ");
            var input = Console.ReadLine();
            switch(input){
                case "1" : 
                    StartNewGame(); 
                    break;
                case "2" : 
                    LoadGame(); 
                    break;
                case "3" : 
                    Quit(); 
                    return;
                default: 
                    Console.WriteLine("Invalid input. Try again");
                    break;
            }
        }

        static void StartNewGame(){
            while(true){
                Console.WriteLine("\nWhat is your name? ");
                var name = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(name)){
                    Console.WriteLine("Name can't be empty.");
                    continue;
                }
                if(players.ContainsKey(name)){
                    Console.WriteLine("Name already exists. Please choose another name.");
                    continue;
                }
                currentPlayer = new Player(name);
                players[name] = currentPlayer;
                Console.WriteLine($"Hello {name}. Let's play!");
                PlayRounds();
                break;
            }
        }
        
        static void LoadGame(){
            while(true){
                Console.Write("What is your name? ");
                var name = Console.ReadLine();
                if(players.TryGetValue(name, out currentPlayer)){
                    Console.WriteLine($"Welcome back {name}. Let's play!");
                    PlayRounds();
                    break;
                }else{
                    Console.WriteLine($"{name}, your game could not be found.");
                    break;
                }
            }
            
        }

        static void Quit(){
            try{
                PlayerLoader.SavePlayers(players);
                Console.WriteLine($"{currentPlayer?.Name}, your game has been saved.");
            }catch(Exception ex){
                Console.WriteLine($"{currentPlayer?.Name}, the game could not be saved.\n{ex.Message}.");
            }
        }

        static void PlayRounds(){
            int round = currentPlayer.TotalGames + 1;
            bool keepPlaying = true;
            while(keepPlaying){
                Console.WriteLine($"\nRound {round}\n\n    1. Rock\n    2. Paper\n    3. Scissors\n\nWhat will it be?");
                if(!Enum.TryParse<Move>(Console.ReadLine(), out var userChoice)){
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                var computerChoice = (Move)rng.Next(1,4);
                Console.WriteLine($"You chose {userChoice}. The computer chose {computerChoice}.");
                string result;

                if(userChoice == computerChoice){
                    result = "tie";
                    currentPlayer.Ties++;
                    currentPlayer.Points += 2;
                }else if((userChoice == Move.Rock && computerChoice == Move.Scissors) ||
                        (userChoice == Move.Scissors && computerChoice == Move.Paper) ||
                        (userChoice == Move.Paper && computerChoice == Move.Rock)){
                            result = "win";
                            currentPlayer.Wins++;
                            currentPlayer.Points += 10;
                }else{
                    result = "lose";
                    currentPlayer.Losses++;
                    currentPlayer.Points -= 3;
                }

                Console.WriteLine($"You {result}!");
                keepPlaying = PostRoundMenu();
                if(keepPlaying){
                    round++;
                }
            }
        }

        static bool PostRoundMenu(){
            while(true){
                Console.WriteLine("\nWhat would you like to do?\n\n1. Play Again\n2. Transfer Points to Another Player\n3. View Your Statistics\n4. View Global Statistics\n5. Quit\n\nEnter Choice: ");
                var input = Console.ReadLine();
                switch(input){
                    case "1" : 
                        return true;
                    case "2" : TransferPoints(); 
                        break;
                    case "3" : ViewStats(); 
                        break;
                    case "4" : ViewGlobalStats(); 
                        break;
                    case "5" : Quit();
                        Environment.Exit(0); 
                        return false;
                    default: Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            }
        }

        static void TransferPoints(){
            Console.Write("How many points would you like to transfer? ");
            if(!int.TryParse(Console.ReadLine(), out int amount) || amount <= 0){
                Console.WriteLine("Invalid amount.");
                return;
            }
            Console.Write("Enter name of the Player to transfer points to: ");
            var name = Console.ReadLine();
            if(!players.TryGetValue(name, out var target) || currentPlayer.Points < amount){
                Console.WriteLine("Points Transfer Failed: either Insufficient Points or Player Name is incorrect!");
                return;
            }
            currentPlayer.Points -= amount;
            target.Points += amount;
            Console.Write($"Points Transfer Successful: Your new point balance is {currentPlayer.Points}!");
        }

        static void ViewStats(){
            Console.WriteLine($"\n{currentPlayer.Name}, here are your game play statistics...\nWins: {currentPlayer.Wins}\nLosses: {currentPlayer.Losses}\nTies: {currentPlayer.Ties}\nWin/Loss Ratio: {currentPlayer.WinLossRatio:F2}\nPoints: {currentPlayer.Points}\nPlayer Level: {currentPlayer.Level}\n");
        }

        static void ViewGlobalStats(){
            Console.WriteLine("\n----------------------------\nView Global Stats\n------------------------------\n\n1. View Top 10 Players with the most Wins\n2. View Most Games played\n3. View Top 10 Players with Most Points\n4. View Players in each Level\n5. View Total Games Played\n6. View Win/Loss Ratio\n7. Quit\n\nEnter Choice: ");
            switch(Console.ReadLine()){

                case "1":
                    Console.WriteLine("---------------------------\nTop 10 Players: Most Wins\n--------------------------------");
                    foreach(var p in players.Values.OrderByDescending(p => p.Wins).Take(10)){
                        Console.WriteLine($"{p.Name}: {p.Wins} wins");  
                    }
                    break;

                case "2":
                    Console.WriteLine("-----------------------------\nMost Games Played\n---------------------------------");
                    foreach(var p in players.Values.OrderByDescending(p => p.TotalGames).Take(5)){
                        Console.WriteLine($"{p.Name}: {p.TotalGames} games played");  
                    }
                    break;

                case "3":
                    Console.WriteLine("-----------------------------\nTop 10 Players: Most Points\n---------------------------------");
                    foreach(var p in players.Values.OrderByDescending(p => p.Points).Take(10)){
                        Console.WriteLine($"{p.Name}: {p.Points} points");
                    }
                    break;

                case "4":
                    Console.WriteLine("----------------------------\nPlayers By Level\n--------------------------------");
                    foreach(var lvl in Enum.GetValues(typeof(PlayerLevel)).Cast<PlayerLevel>()){
                        Console.WriteLine($"{lvl} Level\n---------------");
                        foreach(var p in players.Values.Where(p => p.Level == lvl)){
                            Console.WriteLine($"{p.Name} -- Level: {p.Level}");
                        }
                        Console.WriteLine();
                        }
                    break;

                case "5":
                    Console.WriteLine($"\n----------------------------\nTotal Games Played: {players.Values.Sum(p => p.TotalGames)}\n----------------------------");
                    break;

                case "6":
                    double totalWins = players.Values.Sum(p => p.Wins);
                    double totalLosses = players.Values.Sum(p => p.Losses);
                    double ratio = totalLosses == 0 ? totalWins : totalWins / totalLosses;
                    Console.WriteLine($"\n----------------------------\nOverall Win/Loss Ratio: {ratio:F2}\n----------------------------\n");
                    break;

                case "7" :
                    break;

                default: 
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    
    }
}
