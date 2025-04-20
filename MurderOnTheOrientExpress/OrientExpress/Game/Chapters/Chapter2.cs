using System;
using System.Collections.Generic;
using OrientExpress.Game.ChapterContent;
using OrientExpress.Game.Chapters;

namespace OrientExpress.Game.Chapters;

public class Chapter2
{
    private static HashSet<string> playerChoices = new HashSet<string>();

    public static void Play()
    {
        Console.Clear();
        Console.WriteLine(ChapterContent.Chapter2.ChapterDescription);
        Console.WriteLine(ChapterContent.Chapter2.ChapterChoices);

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                if (!playerChoices.Contains("Countess"))
                {
                    TalkToCountess();
                    playerChoices.Add("Countess");
                }
                else
                    Console.WriteLine("You have already spoken to the Countess.");
                break;
            case "2":
                if (!playerChoices.Contains("Colonel"))
                {
                    TalkToColonel();
                    playerChoices.Add("Colonel");
                }
                else
                    Console.WriteLine("You have already spoken to the Colonel.");
                break;
            case "3":
                if (!playerChoices.Contains("Mary"))
                {
                    TalkToMary();
                    playerChoices.Add("Mary");
                }
                else
                    Console.WriteLine("You have already spoken to Mary.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                Play();
                return;
        }

        if (playerChoices.Count == 3)
        {
            Console.Clear();
            Console.WriteLine("You’ve spoken to all passengers. Some stories don’t quite add up.");
            Console.WriteLine("You begin to sense that the truth is hidden beneath layers of lies.");
            Console.WriteLine("\n[1] Continue to Chapter 3");
            Console.WriteLine("[2] Exit");
            string input = Console.ReadLine();
            if (input == "1") Console.Clear();
        }
        else
        {
            Play();
        }
    }

    private static void TalkToCountess()
    {
        Console.WriteLine("Elena Andrenyi appears calm, too calm.");
        Console.WriteLine("'I stayed in my compartment all night,' she says. 'I heard nothing.'");
    }

    private static void TalkToColonel()
    {
        Console.WriteLine("Colonel Arbuthnot grunts. 'Ratchett was scum. But I didn’t kill him.'");
    }

    private static void TalkToMary()
    {
        Console.WriteLine("Mary Debenham fidgets. 'I was asleep. I didn’t hear anything until morning.'");
    }
}
