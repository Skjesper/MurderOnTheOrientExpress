using OrientExpress.Game.Chapters;

public class Chapter4
{
    public static void Play()
    {
        Console.Clear();
        Console.WriteLine("Chapter 4: The Truth");
        Console.WriteLine("You gather everyone in the dining car.");
        Console.WriteLine("You now must decide: who killed Samuel Ratchett?");
        Console.WriteLine("[1] The conductor");
        Console.WriteLine("[2] One of the passengers");
        Console.WriteLine("[3] Everyone took part");

        string finalChoice = Console.ReadLine();

        Console.Clear();

        switch (finalChoice)
        {
            case "1":
                Console.WriteLine("Incorrect. The conductor was hiding something, but he wasn’t the killer.");
                break;
            case "2":
                Console.WriteLine("Partly true. But it’s more complex than that...");
                break;
            case "3":
                Console.WriteLine("Correct. Each passenger had a motive and played a role in the murder.");
                Console.WriteLine("It was justice, not murder. Ratchett was the gangster Cassetti, who ruined many lives.");
                Console.WriteLine("And so, they planned the perfect revenge — together.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                Play();
                return;
        }

        Console.WriteLine("\nThank you for playing.");
        Console.WriteLine("Would you like to restart?");
        Console.WriteLine("[1] Yes");
        Console.WriteLine("[2] No");

        string restart = Console.ReadLine();
        if (restart == "1")
        {
            Console.Clear();
            StartScreen startScreen = new StartScreen();
            startScreen.StartGame();
        }
        else
        {
            Console.WriteLine("Goodbye.");
        }
    }
}