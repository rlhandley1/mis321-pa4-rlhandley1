using mis321_pa4_rlhandley1.Characters;
using mis321_pa4_rlhandley1.Menu;

Main();

static void Main()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.WriteLine(@" 
  _______ _            ____        _   _   _               __                            
 |__   __| |          |  _ \      | | | | | |             / _|                           
    | |  | |__   ___  | |_) | __ _| |_| |_| | ___    ___ | |_                            
    | |  | '_ \ / _ \ |  _ < / _` | __| __| |/ _ \  / _ \|  _|                           
    | |  | | | |  __/ | |_) | (_| | |_| |_| |  __/ | (_) | |                             
   _|_|_ |_| |_|\___| |____/ \__,_|\__|\__|_|\___|  \___/|_|    _                        
  / ____|    | |                       |  \/  |          | |   | |                       
 | |     __ _| |_   _ _ __  ___  ___   | \  / | __ _  ___| |___| |_ _ __ ___  _ __ ___   
 | |    / _` | | | | | '_ \/ __|/ _ \  | |\/| |/ _` |/ _ \ / __| __| '__/ _ \| '_ ` _ \  
 | |___| (_| | | |_| | |_) \__ \ (_) | | |  | | (_| |  __/ \__ \ |_| | | (_) | | | | | | 
  \_____\__,_|_|\__, | .__/|___/\___/  |_|  |_|\__,_|\___|_|___/\__|_|  \___/|_| |_| |_| 
                 __/ | |                                                                 
                |___/|_|                                                                 
                                                                                                                                                                
");
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine("\nSelect game mode:");
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.WriteLine("1. Multiplayer");
    System.Console.WriteLine("2. Single player");

    string gameMode = Console.ReadLine();
    Character player1, player2;

    if (gameMode == "1")
    {
        player1 = GetPlayer(); //setting up player 1
        player2 = GetPlayer(); //setting up player 2
    }
    else if (gameMode == "2")
    {
        player1 = GetPlayer(); //setting up player 1
        player2 = GetSinglePlayer(); //setting up player 2 as AI
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Invalid game mode selection. Try again");
        System.Threading.Thread.Sleep(2000);
        Main();
        return;
    }
    Console.Clear();

    bool isFirstPlayer = PlayTreasureHunt();
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.ForegroundColor = ConsoleColor.Magenta;
    System.Console.WriteLine("\nTHE STARTING STATS");
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.WriteLine($"\nPlayer: {player1.UserName}\nCharacter: {player1.CharacterName}\nMaxPower: {player1.MaxPower}\nHealth: {player1.Health}\nAttack Strength: {player1.AttackStrength}\nDefensive Power: {player1.DefensivePower}");
    System.Console.WriteLine($"\nPlayer: {player2.UserName}\nCharacter: {player2.CharacterName}\nMaxPower: {player2.MaxPower}\nHealth: {player2.Health}\nAttack Strength: {player2.AttackStrength}\nDefensive Power: {player2.DefensivePower}");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Get ready for the battle!");


    for (int i = 5; i >= 1; i--)
    {
        Console.WriteLine("Starting in " + i + "...");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
    }

    Console.WriteLine("\nLet the battle begin!");
    System.Threading.Thread.Sleep(1000);
    Console.Clear();

    GamePlay(isFirstPlayer, player1, player2);
    Winner(player1, player2);
}

static Character GetPlayer()
{
    Character player = new Character();

    Console.ForegroundColor = ConsoleColor.Gray;
    System.Console.WriteLine("\nPlease enter a username.");
    string playerName = Console.ReadLine();
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"\nWelcome {playerName}!");
    Menu menu = new Menu();
    int selectedCharacter = menu.GetSelectedCharacter();

    Random random = new Random();
    int maxPower = Character.GetMaxPower();

    switch (selectedCharacter)
    {
        case 1:
            player = new JackSparrow()
            {
                UserName = playerName,
                CharacterName = "Jack Sparrow",
                MaxPower = maxPower,
                Health = 100,
                AttackStrength = Character.GetAttackStrength(maxPower),
                DefensivePower = Character.GetDefensivePower(maxPower)
            };
            break;
        case 2:
            player = new DavyJones()
            {
                UserName = playerName,
                CharacterName = "Davy Jones",
                MaxPower = maxPower,
                Health = 100,
                AttackStrength = Character.GetAttackStrength(maxPower),
                DefensivePower = Character.GetDefensivePower(maxPower)
            };
            break;
        case 3:
            player = new WillTurner()
            {
                UserName = playerName,
                CharacterName = "Will Turner",
                MaxPower = maxPower,
                Health = 100,
                AttackStrength = Character.GetAttackStrength(maxPower),
                DefensivePower = Character.GetDefensivePower(maxPower)
            };
            break;
    }
    return player;
}

static Character GetSinglePlayer()
{
    Character player = new Character();

    string playerName = "Black Beard";

    Random random = new Random();
    int maxPower = Character.GetMaxPower();
    int selectedCharacter = random.Next(1, 4); // randomly select character for AI

    switch (selectedCharacter)
    {
        case 1:
            player = new JackSparrow()
            {
                UserName = playerName,
                CharacterName = "Jack Sparrow",
                MaxPower = maxPower,
                Health = 100,
                AttackStrength = Character.GetAttackStrength(maxPower),
                DefensivePower = Character.GetDefensivePower(maxPower)
            };
            break;
        case 2:
            player = new DavyJones()
            {
                UserName = playerName,
                CharacterName = "Davy Jones",
                MaxPower = maxPower,
                Health = 100,
                AttackStrength = Character.GetAttackStrength(maxPower),
                DefensivePower = Character.GetDefensivePower(maxPower)
            };
            break;
        case 3:
            player = new WillTurner()
            {
                UserName = playerName,
                CharacterName = "Will Turner",
                MaxPower = maxPower,
                Health = 100,
                AttackStrength = Character.GetAttackStrength(maxPower),
                DefensivePower = Character.GetDefensivePower(maxPower)
            };
            break;
    }
    return player;
}


static bool PlayTreasureHunt()
{
    // Randomly decide which player goes first
    Random randomNum = new Random();
    bool isFirstPlayer = randomNum.Next(2) == 0;
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.WriteLine("\nNow, we will randomly decide which player goes first by searching for the treasure...\n");
    System.Threading.Thread.Sleep(2000);
    

    Console.ForegroundColor = ConsoleColor.Green;
    if (isFirstPlayer)
    {
        System.Console.WriteLine("\nCongratulations! X marks the spot!");
        System.Console.WriteLine("\nPlayer 1 has found the treasure and will go first.");
    }
    else
    {
        System.Console.WriteLine("\nCongratulations! X marks the spot! ");
        System.Console.WriteLine("\nPlayer 2 has found the treasure and will go first.");
    }
    Console.ForegroundColor = ConsoleColor.White;
    return isFirstPlayer;
}

static void GamePlay(bool isFirstPlayer, Character player1, Character player2)
{
    // Continuous loop for game play until one player runs out of health
    while ((player1.Health > 0) && (player2.Health > 0))
    {
        System.Threading.Thread.Sleep(2000);
        if (isFirstPlayer)
        {
            player1.attackBehavior.Attack();
            Damage(isFirstPlayer, player1, player2);
            isFirstPlayer = false; //to let player2 go first next time
        }
        else
        {
            player2.attackBehavior.Attack();
            Damage(isFirstPlayer, player1, player2);
            isFirstPlayer = true; //to let player1 go first next time
        }
        //re-setting the players' attack strength & defensive power for each turn, but max power for whole round stays the same
        player1.AttackStrength = Character.GetAttackStrength(player1.MaxPower);
        player2.AttackStrength = Character.GetAttackStrength(player2.MaxPower);
        player1.DefensivePower = Character.GetDefensivePower(player1.MaxPower);
        player2.DefensivePower = Character.GetDefensivePower(player2.MaxPower);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();

    }
}
static void Damage(bool isFirstPlayer, Character player1, Character player2)
{
    double bonus = 1;

    if (isFirstPlayer)
    {
        if (((player1.CharacterName == "Jack Sparrow") && (player2.CharacterName == "Will Turner"))
            || ((player1.CharacterName == "Will Turner") && (player2.CharacterName == "Davy Jones"))
            || ((player1.CharacterName == "Davy Jones") && (player2.CharacterName == "Jack Sparrow")))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"\n{player1.CharacterName}'s attack was 20% more effective!");
            bonus = 1.2;
        }

        double damage = ((player1.AttackStrength - player2.DefensivePower) * (bonus));

        if (damage > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            player2.Health -= damage;
            System.Console.WriteLine($"\n{player2.CharacterName}'s damage: -{Math.Round(damage, 2)}");
        }
        else if (damage <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"\n{player2.CharacterName} deflected this round of attack. Moving on...");
        }
    }
    else
    {
        if (((player2.CharacterName == "Jack Sparrow") && (player1.CharacterName == "Will Turner"))
            || ((player2.CharacterName == "Will Turner") && (player1.CharacterName == "Davy Jones"))
            || ((player2.CharacterName == "Davy Jones") && (player1.CharacterName == "Jack Sparrow")))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"\n{player2.CharacterName}'s attack was 20% more effective!");
            bonus = 1.2;
        }

        double damage = ((player2.AttackStrength - player1.DefensivePower) * (bonus));

        if (damage > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            player1.Health -= damage;
            System.Console.WriteLine($"\n{player1.CharacterName}'s damage: -{Math.Round(damage, 2)}");
        }
        else if (damage <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"\n{player1.CharacterName} deflected this round of attack. Moving on...");
        }
    }

    DisplayStats(player1, player2);
}

static void DisplayStats(Character player1, Character player2)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nRetrieving player stats...");
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\n{player1.UserName}: {player1.CharacterName}\nHealth: {Math.Round(player1.Health, 2)}\nAttack Strength: {player1.AttackStrength}\nDefensive Power: {player1.DefensivePower}");
    Console.WriteLine($"\n{player2.UserName}: {player2.CharacterName}\nHealth: {Math.Round(player2.Health, 2)}\nAttack Strength: {player2.AttackStrength}\nDefensive Power: {player2.DefensivePower}");
}

static void Winner(Character player1, Character player2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nWe have a winner!");
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.Magenta;
    if (player1.Health > 0)
    {
        Console.WriteLine($"\nCongratulations {player1.UserName}! {player1.CharacterName} is the winner!\n");
    }
    else if (player2.Health > 0)
    {
        Console.WriteLine($"\nCongratulations {player2.UserName}! {player2.CharacterName} is the winner!\n");
    }
    AskToPlayAgain();

}

static void AskToPlayAgain()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.WriteLine("\nWould you like to play again?\n1. Yes\n2. No");

    string input = System.Console.ReadLine();

    if (input == "1")
    {
        Console.Clear();
        Main();
    }
    else if (input == "2")
    {
        Console.Clear();
        System.Console.WriteLine("\nThanks for Playing! Goodbye!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("\nInvalid input. Please select either 1 or 2.");
        Console.ForegroundColor = ConsoleColor.White;
        // Call the function again to ask for input
        AskToPlayAgain();
    }

}



