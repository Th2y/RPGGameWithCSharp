using RPGGameWithCSharp.src.Entities.Hero;
using RPGGameWithCSharp.src.Entities.Hero.BlackWizard;
using RPGGameWithCSharp.src.Entities.Hero.Knight;
using RPGGameWithCSharp.src.Entities.Hero.Ninja;
using RPGGameWithCSharp.src.Entities.Hero.WhiteWizard;

List<string> availableOptions = ["Arus", "Jenica", "Topapa", "Wedge"];
Console.WriteLine("Welcome to the Character Selection Menu!");

Hero player1 = CreatePlayer("Player 1", availableOptions);
Hero player2 = CreatePlayer("Player 2", availableOptions);

Console.WriteLine();
Console.WriteLine(player1);
Console.WriteLine(player2);

Battle(player1, player2);

static Hero CreatePlayer(string playerName, List<string> availableOptions)
{
    Console.WriteLine();
    Console.WriteLine($"{playerName}, choose your character:");

    for (int i = 0; i < availableOptions.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {availableOptions[i]}");
    }

    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= availableOptions.Count)
    {
        string selectedCharacter = availableOptions[choice - 1];
        availableOptions.Remove(selectedCharacter);

        switch (selectedCharacter)
        {
            case "Arus":
                return new Arus(playerName);
            case "Jenica":
                return new Jenica(playerName);
            case "Topapa":
                return new Topapa(playerName);
            case "Wedge":
                return new Wedge(playerName);
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                return CreatePlayer(playerName, availableOptions);
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return CreatePlayer(playerName, availableOptions);
    }
}

static void Battle(Hero player1, Hero player2)
{
    Console.WriteLine();
    Console.WriteLine($"Let the battle begin between {player1.Name} and {player2.Name}!");

    while (!player1.IsDie && !player2.IsDie)
    {
        Console.WriteLine();

        player1.Attack(player2);
        if (player2.IsDie) break;

        player2.Attack(player1);
        if (player1.IsDie) break;
    }
}