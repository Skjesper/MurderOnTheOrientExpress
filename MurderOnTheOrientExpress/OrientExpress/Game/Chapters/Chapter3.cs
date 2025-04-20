public class Chapter3
{
    public static void Play()
    {
        Console.Clear();
        Console.WriteLine("Chapter 3: Revelations");
        Console.WriteLine("Clues and contradictions begin to surface.");
        Console.WriteLine("You now have to piece together the timeline of the murder.");
        Console.WriteLine("Where was everyone when Ratchett was killed?");
        Console.WriteLine("[1] Reconstruct timeline.");
        Console.WriteLine("[2] Re-interview a suspect.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Clear();
            Console.WriteLine("You examine the timeline. Some testimonies don’t align.");
            Console.WriteLine("- A passenger heard a cry at 12:15am.");
            Console.WriteLine("- The train stopped at 12:30 due to snow.");
            Console.WriteLine("- A knock on Ratchett’s door was heard at 1:00am.");
            Console.WriteLine("The timeline narrows the window of the murder. It had to happen before 12:30.");
        }
        else if (choice == "2")
        {
            Console.Clear();
            Console.WriteLine("You re-interview the conductor. Under pressure, he confesses:");
            Console.WriteLine("'I saw someone in a red kimono leave the victim's cabin around midnight...'");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            Play();
            return;
        }

        Console.WriteLine("\nYou feel you're getting closer to the truth.");
        Console.WriteLine("[1] Continue to final chapter");
        string input = Console.ReadLine();
        if (input == "1") Console.Clear();
    }
}