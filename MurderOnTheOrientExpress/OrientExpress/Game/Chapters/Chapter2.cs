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
        Console.WriteLine(ChapterContent.Chapter2.ChapterTitle);
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
                {
                    Console.WriteLine(ChapterContent.Chapter2.Countess.AlreadySpoken);
                    Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
                    Console.ReadKey();
                }
                break;
            case "2":
                if (!playerChoices.Contains("Colonel"))
                {
                    TalkToColonel();
                    playerChoices.Add("Colonel");
                }
                else
                {
                    Console.WriteLine(ChapterContent.Chapter2.Colonel.AlreadySpoken);
                    Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
                    Console.ReadKey();
                }
                break;
            case "3":
                if (!playerChoices.Contains("Mary"))
                {
                    TalkToMary();
                    playerChoices.Add("Mary");
                }
                else
                {
                    Console.WriteLine(ChapterContent.Chapter2.Mary.AlreadySpoken);
                    Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
                    Console.ReadKey();
                }
                break;
            default:
                Console.WriteLine(ChapterContent.Chapter2.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
                Console.ReadKey();
                Play();
                return;
        }

        if (playerChoices.Count == 3)
        {
            ShowSummary();
        }
        else
        {
            Play();
        }
    }

    private static void TalkToCountess()
    {
        Console.Clear(); 
        Console.WriteLine(ChapterContent.Chapter2.Countess.Description);
        Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
        Console.ReadKey();
    }

    private static void TalkToColonel()
    {
        Console.Clear();
        Console.WriteLine(ChapterContent.Chapter2.Colonel.Description);
        Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
        Console.ReadKey();
    }

    private static void TalkToMary()
    {
        Console.Clear();
        Console.WriteLine(ChapterContent.Chapter2.Mary.Description);
        Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
        Console.ReadKey();
    }
    
    private static void ShowSummary()
    {
        bool validChoice = false;
        
        while (!validChoice)
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter2.ChapterSummary);
            Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.NextChapterChoices);
            
            string input = Console.ReadLine();
            
            if (input == "1") 
            {
                validChoice = true;
                Console.Clear();
                Chapter3.Play();
            }
            else if (input == "2")
            {
                validChoice = true;
                Console.WriteLine(ChapterContent.Chapter2.Messages.ThanksForPlaying);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(ChapterContent.Chapter2.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter2.Messages.PressAnyKey);
                Console.ReadKey();
                // Loop fortsätter
            }
        }
    }
}